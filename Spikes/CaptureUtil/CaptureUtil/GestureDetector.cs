﻿#region

using System;
using System.Collections.Generic;
using Microsoft.Kinect;
using Microsoft.Kinect.VisualGestureBuilder;

#endregion

// ReSharper disable GCSuppressFinalizeForTypeWithoutDestructor

namespace CaptureUtil
{
    /// <summary>
    ///     Gesture Detector class which listens for VisualGestureBuilderFrame events from
    ///     the service and updates the associated GestureResultView object with the latest
    ///     results for the 'Seated' gesture
    /// </summary>
    public sealed class GestureDetector : IDisposable
    {
        /// <summary> Path to the gesture database that was trained with VGB </summary>
        private readonly string gestureDatabase = @"Database\HandFlap.gbd";

        /// <summary>
        ///     Gesture frame reader which will handle gesture events coming from the sensor
        /// </summary>
        private VisualGestureBuilderFrameReader _vgbFrameReader;

        /// <summary>
        ///     Gesture frame source which should be tied to a body tracking ID
        /// </summary>
        private VisualGestureBuilderFrameSource _vgbFrameSource;

        private ChartInteraction _chartInteraction;

        public static int MaxPlotPoints { get; } = 90;

        private List<String> _gestureNameList;
         
        public List<String> GestureNames
        {
            get { return _gestureNameList; } 
        }

        private string selectedGesture;

        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Gets the GestureResultView object which stores the detector results for
        ///     display in the UI
        /// </summary>
        private GestureResultView GestureResultView { get; }

        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Gets or sets the body tracking ID associated with the current detector
        ///     The tracking ID can change whenever a body comes in/out of scope
        /// </summary>
        public ulong TrackingId
        {
            get { return _vgbFrameSource.TrackingId; }

            set
            {
                if (_vgbFrameSource.TrackingId != value)
                {
                    _vgbFrameSource.TrackingId = value;
                }
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Gets or sets a value indicating whether or not the detector is currently
        ///     paused. If the body tracking ID associated with the detector is not valid,
        ///     then the detector should be paused
        /// </summary>
        public bool IsPaused
        {
            get { return _vgbFrameReader.IsPaused; }

            set
            {
                if (_vgbFrameReader.IsPaused != value)
                {
                    _vgbFrameReader.IsPaused = value;
                }
            }
        }

        //--------------------------------------------------------------------------------
        public string GestureDatabase
        {
            get { return gestureDatabase; }
        }

        public string SelectedGesture
        {
            get
            {
                return selectedGesture;
            }

            set
            {
                selectedGesture = value;
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Initializes a new instance of the GestureDetector class along with the gesture
        ///     frame source and reader
        /// </summary>
        /// <param name="kinectSensor">
        ///     Active sensor to initialize the
        ///     VisualGestureBuilderFrameSource object with
        /// </param>
        /// <param name="gestureResultView">
        ///     GestureResultView object to store gesture
        ///     results of a single body to
        /// </param>
        public GestureDetector(KinectSensor kinectSensor,
                               GestureResultView gestureResultView)
        {
            if (kinectSensor == null)
            {
                throw new ArgumentNullException(nameof(kinectSensor));
            }

            if (gestureResultView == null)
            {
                throw new ArgumentNullException(nameof(gestureResultView));
            }

            //Initialize the GUI controls for handing kinect stream values.
            _chartInteraction = new ChartInteraction(MaxPlotPoints);

            _gestureNameList = new List<string>();

            GestureResultView = gestureResultView;

            // create the vgb source. The associated body tracking ID will be set when a 
            //  valid body frame arrives from the sensor.
            _vgbFrameSource = new VisualGestureBuilderFrameSource(kinectSensor, 0);
            _vgbFrameSource.TrackingIdLost += Source_TrackingIdLost;

            // open the reader for the vgb frames
            _vgbFrameReader = _vgbFrameSource.OpenReader();
            if (_vgbFrameReader != null)
            {
                _vgbFrameReader.IsPaused = true;
                _vgbFrameReader.FrameArrived += Reader_GestureFrameArrived;
            }

            // load the 'Seated' gesture from the gesture database
            using (VisualGestureBuilderDatabase database =
                new VisualGestureBuilderDatabase(gestureDatabase))
            {
                //Add all continuous types of gestures from the database to the frame
                // processor.
                foreach (Gesture gesture in database.AvailableGestures)
                {
                    if (gesture.GestureType == GestureType.Continuous)
                    {
                        _gestureNameList.Add(gesture.Name);

                        _vgbFrameSource.AddGesture(gesture);
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Disposes all unmanaged resources for the class
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Disposes the VisualGestureBuilderFrameSource and
        ///     VisualGestureBuilderFrameReader objects
        /// </summary>
        /// <param name="disposing">
        ///     True if Dispose was called directly, false if the GC
        ///     handles the disposing
        /// </param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_vgbFrameReader != null)
                {
                    _vgbFrameReader.FrameArrived -= Reader_GestureFrameArrived;
                    _vgbFrameReader.Dispose();
                    _vgbFrameReader = null;
                }

                if (_vgbFrameSource != null)
                {
                    _vgbFrameSource.TrackingIdLost -= Source_TrackingIdLost;
                    _vgbFrameSource.Dispose();
                    _vgbFrameSource = null;
                }
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Handles gesture detection results arriving from the sensor for the associated
        ///     body tracking Id
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void Reader_GestureFrameArrived(object sender,
                                                VisualGestureBuilderFrameArrivedEventArgs
                                                    e)
        {
            var frameReference = e.FrameReference;
            ContinuousGestureResult result = null;

            using (VisualGestureBuilderFrame frame = frameReference.AcquireFrame())
            {
                //Obtain the latest continuous gesture from the frame
                var continuousGestureResults = frame?.ContinuousGestureResults;

                if (continuousGestureResults != null)
                {
                    // Process each gesture from the received frame.
                    foreach (Gesture gesture in _vgbFrameSource.Gestures)
                    {
                        if (gesture.Name != SelectedGesture)
                            continue;

                        result = null;
                        continuousGestureResults.TryGetValue(gesture, out result);

                        if (result != null)
                        {
                            //Insert results from gesture into the wave.
                            _chartInteraction.Insert(result.Progress);
                        } //if
                    } //for-each
                } //if
            } //using(...)
        } //Reader_GestureFrameArrived(..)


        //--------------------------------------------------------------------------------
        /// <summary>
        ///     Handles the TrackingIdLost event for the VisualGestureBuilderSource object
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void Source_TrackingIdLost(object sender, TrackingIdLostEventArgs e)
        {
            // update the GestureResultView object to show the 'Not Tracked' image in the 
            //  UI
            GestureResultView.UpdateGestureResult(false, false, 0.0f);
        }
    }
}