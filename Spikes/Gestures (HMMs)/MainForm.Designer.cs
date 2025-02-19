﻿namespace Gestures.HMMs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabSamples = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClassify = new System.Windows.Forms.Button();
            this.btnSampleRunAnalysis = new System.Windows.Forms.Button();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.colComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEigenValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCumulativeProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvClass = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbCanvasClassification = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tbPenWidth = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.saveDataDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDataDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLearnHMM = new System.Windows.Forms.Button();
            this.btnLearnHCRF = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lbLoadedGesture = new System.Windows.Forms.Label();
            this.lbRecError = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.chartPattern = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKinectRaw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblKinectRawStream = new System.Windows.Forms.Label();
            this.lblWavePattern = new System.Windows.Forms.Label();
            this.panelUserLabeling = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbWhat = new System.Windows.Forms.Label();
            this.panelClassification = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbDoesPatternEql = new System.Windows.Forms.Label();
            this.cbGesture = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHmmMatch = new System.Windows.Forms.Label();
            this.lbHcrfMatch = new System.Windows.Forms.Label();
            this.captureTime = new System.Windows.Forms.Timer(this.components);
            this.btnautotrain = new System.Windows.Forms.Button();
            this.cbWaveType = new System.Windows.Forms.ComboBox();
            this.lbHcrfGoodWave = new System.Windows.Forms.Label();
            this.lbHcrfBadWave = new System.Windows.Forms.Label();
            this.lbHmmBadWave = new System.Windows.Forms.Label();
            this.lbHmmGoodWave = new System.Windows.Forms.Label();
            this.lbTotalRecs = new System.Windows.Forms.Label();
            this.btnCompAuto = new System.Windows.Forms.Button();
            this.recordTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileWaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabSamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenWidth)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuFile.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKinectRaw)).BeginInit();
            this.panelUserLabeling.SuspendLayout();
            this.panelClassification.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSamples
            // 
            this.tabSamples.Controls.Add(this.splitContainer3);
            this.tabSamples.Location = new System.Drawing.Point(4, 22);
            this.tabSamples.Name = "tabSamples";
            this.tabSamples.Padding = new System.Windows.Forms.Padding(3);
            this.tabSamples.Size = new System.Drawing.Size(636, 370);
            this.tabSamples.TabIndex = 0;
            this.tabSamples.Text = "Samples (Input)";
            this.tabSamples.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer3.Size = new System.Drawing.Size(630, 364);
            this.splitContainer3.SplitterDistance = 448;
            this.splitContainer3.TabIndex = 8;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.groupBox15);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer7.Size = new System.Drawing.Size(448, 364);
            this.splitContainer7.SplitterDistance = 156;
            this.splitContainer7.TabIndex = 9;
            // 
            // groupBox15
            // 
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(0, 0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(156, 364);
            this.groupBox15.TabIndex = 8;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Training";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numThreshold);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.btnClassify);
            this.groupBox6.Controls.Add(this.btnSampleRunAnalysis);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(178, 364);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // numThreshold
            // 
            this.numThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numThreshold.DecimalPlaces = 6;
            this.numThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numThreshold.Location = new System.Drawing.Point(89, 203);
            this.numThreshold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(82, 20);
            this.numThreshold.TabIndex = 7;
            this.numThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 12;
            // 
            // btnClassify
            // 
            this.btnClassify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClassify.Enabled = false;
            this.btnClassify.Location = new System.Drawing.Point(7, 310);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(165, 48);
            this.btnClassify.TabIndex = 1;
            this.btnClassify.Text = "Classify";
            this.btnClassify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClassify.UseVisualStyleBackColor = true;
            // 
            // btnSampleRunAnalysis
            // 
            this.btnSampleRunAnalysis.Location = new System.Drawing.Point(0, 0);
            this.btnSampleRunAnalysis.Name = "btnSampleRunAnalysis";
            this.btnSampleRunAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnSampleRunAnalysis.TabIndex = 13;
            // 
            // tabOverview
            // 
            this.tabOverview.Location = new System.Drawing.Point(0, 0);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Size = new System.Drawing.Size(200, 100);
            this.tabOverview.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer2.Size = new System.Drawing.Size(630, 364);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer4.Size = new System.Drawing.Size(630, 207);
            this.splitContainer4.SplitterDistance = 407;
            this.splitContainer4.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // colComponent
            // 
            this.colComponent.Name = "colComponent";
            // 
            // colEigenValue
            // 
            this.colEigenValue.Name = "colEigenValue";
            // 
            // colProportion
            // 
            this.colProportion.Name = "colProportion";
            // 
            // colCumulativeProportion
            // 
            this.colCumulativeProportion.Name = "colCumulativeProportion";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(624, 134);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(636, 370);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "Classes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.groupBox9);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.groupBox10);
            this.splitContainer9.Size = new System.Drawing.Size(636, 370);
            this.splitContainer9.SplitterDistance = 256;
            this.splitContainer9.TabIndex = 3;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dgvClasses);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(256, 370);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Classes";
            // 
            // dgvClasses
            // 
            this.dgvClasses.Location = new System.Drawing.Point(0, 0);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.Size = new System.Drawing.Size(240, 150);
            this.dgvClasses.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 100);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lvClass
            // 
            this.lvClass.Location = new System.Drawing.Point(0, 0);
            this.lvClass.Name = "lvClass";
            this.lvClass.Size = new System.Drawing.Size(121, 97);
            this.lvClass.TabIndex = 0;
            this.lvClass.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(200, 100);
            this.tabPage4.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 100);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // lbCanvasClassification
            // 
            this.lbCanvasClassification.Location = new System.Drawing.Point(0, 0);
            this.lbCanvasClassification.Name = "lbCanvasClassification";
            this.lbCanvasClassification.Size = new System.Drawing.Size(100, 23);
            this.lbCanvasClassification.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox11.Controls.Add(this.button5);
            this.groupBox11.Controls.Add(this.tbPenWidth);
            this.groupBox11.Controls.Add(this.button7);
            this.groupBox11.Location = new System.Drawing.Point(8, 176);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(204, 191);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Drawing Canvas";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Classify";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tbPenWidth
            // 
            this.tbPenWidth.Location = new System.Drawing.Point(149, 19);
            this.tbPenWidth.Minimum = 1;
            this.tbPenWidth.Name = "tbPenWidth";
            this.tbPenWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbPenWidth.Size = new System.Drawing.Size(45, 128);
            this.tbPenWidth.TabIndex = 5;
            this.tbPenWidth.Value = 3;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(111, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Location = new System.Drawing.Point(218, 0);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(418, 370);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Discriminant functions relative response";
            // 
            // groupBox16
            // 
            this.groupBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox16.Controls.Add(this.label8);
            this.groupBox16.Location = new System.Drawing.Point(14, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(198, 167);
            this.groupBox16.TabIndex = 9;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Classification";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 148);
            this.label8.TabIndex = 3;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox17
            // 
            this.groupBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox17.Controls.Add(this.button8);
            this.groupBox17.Controls.Add(this.trackBar1);
            this.groupBox17.Controls.Add(this.button9);
            this.groupBox17.Location = new System.Drawing.Point(8, 176);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(204, 191);
            this.groupBox17.TabIndex = 8;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Drawing Canvas";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Classify";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(149, 19);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 128);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 3;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(111, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Location = new System.Drawing.Point(218, 0);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(418, 370);
            this.groupBox18.TabIndex = 7;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Discriminant functions relative response";
            // 
            // saveDataDialog
            // 
            this.saveDataDialog.DefaultExt = "xml";
            this.saveDataDialog.Filter = "Compressed Database files|*.cdb|All files|*.*";
            this.saveDataDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDataDialog_FileOk);
            // 
            // openDataDialog
            // 
            this.openDataDialog.DefaultExt = "xml";
            this.openDataDialog.FileName = "openFileDialog1";
            this.openDataDialog.Filter = "Compressed Database files|*.cdb|All files|*.*";
            this.openDataDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDataDialog_FileOk);
            // 
            // menuFile
            // 
            this.menuFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuFile.Name = "contextMenuStrip1";
            this.menuFile.Size = new System.Drawing.Size(104, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.openDataStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "Save";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.saveDataStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(795, 657);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 40);
            this.button4.TabIndex = 36;
            this.button4.Text = "Database";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFile_MouseDown);
            // 
            // btnLearnHMM
            // 
            this.btnLearnHMM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLearnHMM.Enabled = false;
            this.btnLearnHMM.Location = new System.Drawing.Point(12, 657);
            this.btnLearnHMM.Name = "btnLearnHMM";
            this.btnLearnHMM.Size = new System.Drawing.Size(144, 40);
            this.btnLearnHMM.TabIndex = 35;
            this.btnLearnHMM.Text = "Create a Hidden Markov Model Classifier";
            this.btnLearnHMM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLearnHMM.UseCompatibleTextRendering = true;
            this.btnLearnHMM.UseVisualStyleBackColor = true;
            this.btnLearnHMM.Click += new System.EventHandler(this.btnLearnHMM_Click);
            // 
            // btnLearnHCRF
            // 
            this.btnLearnHCRF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLearnHCRF.Enabled = false;
            this.btnLearnHCRF.Location = new System.Drawing.Point(161, 657);
            this.btnLearnHCRF.Name = "btnLearnHCRF";
            this.btnLearnHCRF.Size = new System.Drawing.Size(158, 40);
            this.btnLearnHCRF.TabIndex = 35;
            this.btnLearnHCRF.Text = "Create a Hidden Conditional Random Field";
            this.btnLearnHCRF.UseCompatibleTextRendering = true;
            this.btnLearnHCRF.UseVisualStyleBackColor = true;
            this.btnLearnHCRF.Click += new System.EventHandler(this.btnLearnHCRF_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.lbLoadedGesture);
            this.panel.Controls.Add(this.lbRecError);
            this.panel.Controls.Add(this.btnRecord);
            this.panel.Controls.Add(this.chartPattern);
            this.panel.Controls.Add(this.chartKinectRaw);
            this.panel.Controls.Add(this.lblKinectRawStream);
            this.panel.Controls.Add(this.lblWavePattern);
            this.panel.Controls.Add(this.panelUserLabeling);
            this.panel.Controls.Add(this.panelClassification);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(659, 639);
            this.panel.TabIndex = 43;
            // 
            // lbLoadedGesture
            // 
            this.lbLoadedGesture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoadedGesture.AutoSize = true;
            this.lbLoadedGesture.Font = new System.Drawing.Font("Segoe WP Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadedGesture.ForeColor = System.Drawing.Color.Green;
            this.lbLoadedGesture.Location = new System.Drawing.Point(165, 330);
            this.lbLoadedGesture.Name = "lbLoadedGesture";
            this.lbLoadedGesture.Size = new System.Drawing.Size(135, 17);
            this.lbLoadedGesture.TabIndex = 51;
            this.lbLoadedGesture.Text = "Gesture {Foo} loaded";
            // 
            // lbRecError
            // 
            this.lbRecError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRecError.AutoSize = true;
            this.lbRecError.BackColor = System.Drawing.Color.White;
            this.lbRecError.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecError.ForeColor = System.Drawing.Color.Red;
            this.lbRecError.Location = new System.Drawing.Point(313, 109);
            this.lbRecError.Name = "lbRecError";
            this.lbRecError.Size = new System.Drawing.Size(147, 15);
            this.lbRecError.TabIndex = 50;
            this.lbRecError.Text = "Could not classify pattern";
            this.lbRecError.Visible = false;
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRecord.Location = new System.Drawing.Point(168, 103);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(139, 23);
            this.btnRecord.TabIndex = 49;
            this.btnRecord.Text = "Start Recording...";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // chartPattern
            // 
            this.chartPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPattern.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chartPattern.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPattern.Legends.Add(legend1);
            this.chartPattern.Location = new System.Drawing.Point(8, 144);
            this.chartPattern.Name = "chartPattern";
            this.chartPattern.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Yellow;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPattern.Series.Add(series1);
            this.chartPattern.Size = new System.Drawing.Size(637, 164);
            this.chartPattern.TabIndex = 48;
            this.chartPattern.Text = "chart1";
            // 
            // chartKinectRaw
            // 
            this.chartKinectRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chartKinectRaw.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chartKinectRaw.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartKinectRaw.Legends.Add(legend2);
            this.chartKinectRaw.Location = new System.Drawing.Point(8, 365);
            this.chartKinectRaw.Name = "chartKinectRaw";
            this.chartKinectRaw.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Yellow;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartKinectRaw.Series.Add(series2);
            this.chartKinectRaw.Size = new System.Drawing.Size(637, 164);
            this.chartKinectRaw.TabIndex = 47;
            this.chartKinectRaw.Text = "chart1";
            // 
            // lblKinectRawStream
            // 
            this.lblKinectRawStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKinectRawStream.AutoSize = true;
            this.lblKinectRawStream.BackColor = System.Drawing.Color.White;
            this.lblKinectRawStream.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinectRawStream.Location = new System.Drawing.Point(8, 330);
            this.lblKinectRawStream.Name = "lblKinectRawStream";
            this.lblKinectRawStream.Size = new System.Drawing.Size(122, 17);
            this.lblKinectRawStream.TabIndex = 46;
            this.lblKinectRawStream.Text = "Kinect Raw Stream";
            // 
            // lblWavePattern
            // 
            this.lblWavePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWavePattern.AutoSize = true;
            this.lblWavePattern.BackColor = System.Drawing.Color.White;
            this.lblWavePattern.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWavePattern.Location = new System.Drawing.Point(8, 109);
            this.lblWavePattern.Name = "lblWavePattern";
            this.lblWavePattern.Size = new System.Drawing.Size(150, 17);
            this.lblWavePattern.TabIndex = 45;
            this.lblWavePattern.Text = "Wave Pattern Captured";
            // 
            // panelUserLabeling
            // 
            this.panelUserLabeling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUserLabeling.BackColor = System.Drawing.Color.White;
            this.panelUserLabeling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserLabeling.Controls.Add(this.btnClear);
            this.panelUserLabeling.Controls.Add(this.btnInsert);
            this.panelUserLabeling.Controls.Add(this.label7);
            this.panelUserLabeling.Controls.Add(this.cbClass);
            this.panelUserLabeling.Controls.Add(this.lbWhat);
            this.panelUserLabeling.Location = new System.Drawing.Point(8, 560);
            this.panelUserLabeling.Name = "panelUserLabeling";
            this.panelUserLabeling.Size = new System.Drawing.Size(461, 74);
            this.panelUserLabeling.TabIndex = 43;
            this.panelUserLabeling.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(225, 21);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Forget my pattern, clear the screen.";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(222, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(225, 35);
            this.btnInsert.TabIndex = 27;
            this.btnInsert.Text = "Insert my pattern into the database!";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "I\'ve got a";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.Items.AddRange(new object[] {
            "Good Wave",
            "Bad Wave"});
            this.cbClass.Location = new System.Drawing.Point(81, 35);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(101, 21);
            this.cbClass.TabIndex = 23;
            // 
            // lbWhat
            // 
            this.lbWhat.AutoSize = true;
            this.lbWhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhat.Location = new System.Drawing.Point(8, 11);
            this.lbWhat.Name = "lbWhat";
            this.lbWhat.Size = new System.Drawing.Size(203, 27);
            this.lbWhat.TabIndex = 25;
            this.lbWhat.Text = "What have you captured?";
            this.lbWhat.UseCompatibleTextRendering = true;
            // 
            // panelClassification
            // 
            this.panelClassification.BackColor = System.Drawing.Color.White;
            this.panelClassification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClassification.Controls.Add(this.button3);
            this.panelClassification.Controls.Add(this.button2);
            this.panelClassification.Controls.Add(this.lbDoesPatternEql);
            this.panelClassification.Location = new System.Drawing.Point(28, 4);
            this.panelClassification.Name = "panelClassification";
            this.panelClassification.Size = new System.Drawing.Size(461, 74);
            this.panelClassification.TabIndex = 44;
            this.panelClassification.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "No...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Yes!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbDoesPatternEql
            // 
            this.lbDoesPatternEql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDoesPatternEql.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoesPatternEql.Location = new System.Drawing.Point(8, 11);
            this.lbDoesPatternEql.Name = "lbDoesPatternEql";
            this.lbDoesPatternEql.Size = new System.Drawing.Size(437, 25);
            this.lbDoesPatternEql.TabIndex = 25;
            this.lbDoesPatternEql.Text = "Does the pattern match {Foo} ?";
            this.lbDoesPatternEql.UseCompatibleTextRendering = true;
            // 
            // cbGesture
            // 
            this.cbGesture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGesture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGesture.Items.AddRange(new object[] {
            "NO GESTURES DETECTED"});
            this.cbGesture.Location = new System.Drawing.Point(641, 668);
            this.cbGesture.Name = "cbGesture";
            this.cbGesture.Size = new System.Drawing.Size(133, 21);
            this.cbGesture.TabIndex = 44;
            this.cbGesture.SelectedIndexChanged += new System.EventHandler(this.cbGesture_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe WP Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Target Gesture";
            // 
            // lbHmmMatch
            // 
            this.lbHmmMatch.AutoSize = true;
            this.lbHmmMatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHmmMatch.Location = new System.Drawing.Point(692, 12);
            this.lbHmmMatch.Name = "lbHmmMatch";
            this.lbHmmMatch.Size = new System.Drawing.Size(295, 27);
            this.lbHmmMatch.TabIndex = 46;
            this.lbHmmMatch.Text = "HMM Total Matched {foo} : {centfoo}";
            this.lbHmmMatch.UseCompatibleTextRendering = true;
            // 
            // lbHcrfMatch
            // 
            this.lbHcrfMatch.AutoSize = true;
            this.lbHcrfMatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHcrfMatch.Location = new System.Drawing.Point(692, 161);
            this.lbHcrfMatch.Name = "lbHcrfMatch";
            this.lbHcrfMatch.Size = new System.Drawing.Size(293, 27);
            this.lbHcrfMatch.TabIndex = 47;
            this.lbHcrfMatch.Text = "HCRF Total Matched {foo} : {centfoo}";
            this.lbHcrfMatch.UseCompatibleTextRendering = true;
            // 
            // captureTime
            // 
            this.captureTime.Tick += new System.EventHandler(this.captureTime_Tick);
            // 
            // btnautotrain
            // 
            this.btnautotrain.Location = new System.Drawing.Point(692, 443);
            this.btnautotrain.Name = "btnautotrain";
            this.btnautotrain.Size = new System.Drawing.Size(175, 23);
            this.btnautotrain.TabIndex = 48;
            this.btnautotrain.Text = "Start Auto Training";
            this.btnautotrain.UseVisualStyleBackColor = true;
            this.btnautotrain.Click += new System.EventHandler(this.btnautotrain_Click);
            // 
            // cbWaveType
            // 
            this.cbWaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWaveType.Items.AddRange(new object[] {
            "Good Wave",
            "Bad Wave"});
            this.cbWaveType.Location = new System.Drawing.Point(873, 445);
            this.cbWaveType.Name = "cbWaveType";
            this.cbWaveType.Size = new System.Drawing.Size(101, 21);
            this.cbWaveType.TabIndex = 49;
            // 
            // lbHcrfGoodWave
            // 
            this.lbHcrfGoodWave.AutoSize = true;
            this.lbHcrfGoodWave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHcrfGoodWave.Location = new System.Drawing.Point(692, 202);
            this.lbHcrfGoodWave.Name = "lbHcrfGoodWave";
            this.lbHcrfGoodWave.Size = new System.Drawing.Size(187, 27);
            this.lbHcrfGoodWave.TabIndex = 50;
            this.lbHcrfGoodWave.Text = "HCRF Good wave: {foo}";
            this.lbHcrfGoodWave.UseCompatibleTextRendering = true;
            // 
            // lbHcrfBadWave
            // 
            this.lbHcrfBadWave.AutoSize = true;
            this.lbHcrfBadWave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHcrfBadWave.Location = new System.Drawing.Point(692, 239);
            this.lbHcrfBadWave.Name = "lbHcrfBadWave";
            this.lbHcrfBadWave.Size = new System.Drawing.Size(178, 27);
            this.lbHcrfBadWave.TabIndex = 51;
            this.lbHcrfBadWave.Text = "HCRF Bad Wave: {foo}";
            this.lbHcrfBadWave.UseCompatibleTextRendering = true;
            // 
            // lbHmmBadWave
            // 
            this.lbHmmBadWave.AutoSize = true;
            this.lbHmmBadWave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHmmBadWave.Location = new System.Drawing.Point(692, 93);
            this.lbHmmBadWave.Name = "lbHmmBadWave";
            this.lbHmmBadWave.Size = new System.Drawing.Size(180, 27);
            this.lbHmmBadWave.TabIndex = 53;
            this.lbHmmBadWave.Text = "HMM Bad Wave: {foo}";
            this.lbHmmBadWave.UseCompatibleTextRendering = true;
            // 
            // lbHmmGoodWave
            // 
            this.lbHmmGoodWave.AutoSize = true;
            this.lbHmmGoodWave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHmmGoodWave.Location = new System.Drawing.Point(692, 56);
            this.lbHmmGoodWave.Name = "lbHmmGoodWave";
            this.lbHmmGoodWave.Size = new System.Drawing.Size(189, 27);
            this.lbHmmGoodWave.TabIndex = 52;
            this.lbHmmGoodWave.Text = "HMM Good wave: {foo}";
            this.lbHmmGoodWave.UseCompatibleTextRendering = true;
            // 
            // lbTotalRecs
            // 
            this.lbTotalRecs.AutoSize = true;
            this.lbTotalRecs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRecs.Location = new System.Drawing.Point(741, 293);
            this.lbTotalRecs.Name = "lbTotalRecs";
            this.lbTotalRecs.Size = new System.Drawing.Size(159, 27);
            this.lbTotalRecs.TabIndex = 54;
            this.lbTotalRecs.Text = "Total Records: {foo}";
            this.lbTotalRecs.UseCompatibleTextRendering = true;
            // 
            // btnCompAuto
            // 
            this.btnCompAuto.Location = new System.Drawing.Point(741, 518);
            this.btnCompAuto.Name = "btnCompAuto";
            this.btnCompAuto.Size = new System.Drawing.Size(175, 23);
            this.btnCompAuto.TabIndex = 55;
            this.btnCompAuto.Text = "Compute Auto Train";
            this.btnCompAuto.UseVisualStyleBackColor = true;
            this.btnCompAuto.Click += new System.EventHandler(this.btnCompAuto_Click);
            // 
            // recordTimer
            // 
            this.recordTimer.Tick += new System.EventHandler(this.recordTimer_Tick);
            // 
            // saveFileWaveDialog
            // 
            this.saveFileWaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileWaveDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(988, 704);
            this.Controls.Add(this.btnCompAuto);
            this.Controls.Add(this.lbTotalRecs);
            this.Controls.Add(this.lbHmmBadWave);
            this.Controls.Add(this.lbHmmGoodWave);
            this.Controls.Add(this.lbHcrfBadWave);
            this.Controls.Add(this.lbHcrfGoodWave);
            this.Controls.Add(this.cbWaveType);
            this.Controls.Add(this.btnautotrain);
            this.Controls.Add(this.lbHcrfMatch);
            this.Controls.Add(this.lbHmmMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGesture);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnLearnHMM);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLearnHCRF);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabSamples.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenWidth)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuFile.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKinectRaw)).EndInit();
            this.panelUserLabeling.ResumeLayout(false);
            this.panelUserLabeling.PerformLayout();
            this.panelClassification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabSamples;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.Button btnSampleRunAnalysis;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEigenValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCumulativeProportion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListView lvClass;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lbCanvasClassification;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar tbPenWidth;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.SaveFileDialog saveDataDialog;
        private System.Windows.Forms.OpenFileDialog openDataDialog;
        private System.Windows.Forms.ContextMenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLearnHMM;
        private System.Windows.Forms.Button btnLearnHCRF;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbRecError;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPattern;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKinectRaw;
        private System.Windows.Forms.Label lblKinectRawStream;
        private System.Windows.Forms.Label lblWavePattern;
        private System.Windows.Forms.Panel panelUserLabeling;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbWhat;
        private System.Windows.Forms.Panel panelClassification;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbDoesPatternEql;
        private System.Windows.Forms.Label lbLoadedGesture;
        private System.Windows.Forms.ComboBox cbGesture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHmmMatch;
        private System.Windows.Forms.Label lbHcrfMatch;
        private System.Windows.Forms.Timer captureTime;
        private System.Windows.Forms.Button btnautotrain;
        private System.Windows.Forms.ComboBox cbWaveType;
        private System.Windows.Forms.Label lbHcrfGoodWave;
        private System.Windows.Forms.Label lbHcrfBadWave;
        private System.Windows.Forms.Label lbHmmBadWave;
        private System.Windows.Forms.Label lbHmmGoodWave;
        private System.Windows.Forms.Label lbTotalRecs;
        private System.Windows.Forms.Button btnCompAuto;
        private System.Windows.Forms.Timer recordTimer;
        private System.Windows.Forms.SaveFileDialog saveFileWaveDialog;
    }
}

