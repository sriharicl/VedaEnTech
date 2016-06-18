namespace $rootnamespace$
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudScanTimeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboScanDirection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudScanlineDistance = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudScanlineThickness = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMinNumOfDataChars = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxNumOfBarcodes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSymbologies = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnHighPriority = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLowPriority = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnOpenImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnReadBarcodes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnRot0 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRot90 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRot180 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRot270 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnInvert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSupport = new System.Windows.Forms.ToolStripButton();
            this.imgViewer = new BarcodeReaderSDKAppDemo.ImageViewer();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanlineDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanlineThickness)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinNumOfDataChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNumOfBarcodes)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(978, 546);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(978, 607);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // lblFileName
            // 
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.imgViewer);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(978, 546);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.nudScanTimeout);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboScanDirection);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudScanlineDistance);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudScanlineThickness);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scan Settings";
            // 
            // nudScanTimeout
            // 
            this.nudScanTimeout.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudScanTimeout.Location = new System.Drawing.Point(128, 102);
            this.nudScanTimeout.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudScanTimeout.Name = "nudScanTimeout";
            this.nudScanTimeout.Size = new System.Drawing.Size(67, 21);
            this.nudScanTimeout.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Scan Timeout (ms):";
            // 
            // cboScanDirection
            // 
            this.cboScanDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScanDirection.FormattingEnabled = true;
            this.cboScanDirection.Location = new System.Drawing.Point(128, 75);
            this.cboScanDirection.Name = "cboScanDirection";
            this.cboScanDirection.Size = new System.Drawing.Size(104, 21);
            this.cboScanDirection.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Scan Direction:";
            // 
            // nudScanlineDistance
            // 
            this.nudScanlineDistance.Location = new System.Drawing.Point(128, 47);
            this.nudScanlineDistance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudScanlineDistance.Name = "nudScanlineDistance";
            this.nudScanlineDistance.Size = new System.Drawing.Size(67, 21);
            this.nudScanlineDistance.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scanline Distance (px):";
            // 
            // nudScanlineThickness
            // 
            this.nudScanlineThickness.Location = new System.Drawing.Point(128, 20);
            this.nudScanlineThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudScanlineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScanlineThickness.Name = "nudScanlineThickness";
            this.nudScanlineThickness.Size = new System.Drawing.Size(67, 21);
            this.nudScanlineThickness.TabIndex = 5;
            this.nudScanlineThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scanline Thickness (px):";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudMinNumOfDataChars);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudMaxNumOfBarcodes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstSymbologies);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode Symbologies";
            // 
            // nudMinNumOfDataChars
            // 
            this.nudMinNumOfDataChars.Location = new System.Drawing.Point(128, 289);
            this.nudMinNumOfDataChars.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMinNumOfDataChars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinNumOfDataChars.Name = "nudMinNumOfDataChars";
            this.nudMinNumOfDataChars.Size = new System.Drawing.Size(67, 21);
            this.nudMinNumOfDataChars.TabIndex = 5;
            this.nudMinNumOfDataChars.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min. num of data chars:";
            // 
            // nudMaxNumOfBarcodes
            // 
            this.nudMaxNumOfBarcodes.Location = new System.Drawing.Point(128, 263);
            this.nudMaxNumOfBarcodes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMaxNumOfBarcodes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxNumOfBarcodes.Name = "nudMaxNumOfBarcodes";
            this.nudMaxNumOfBarcodes.Size = new System.Drawing.Size(67, 21);
            this.nudMaxNumOfBarcodes.TabIndex = 3;
            this.nudMaxNumOfBarcodes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max. num of barcodes:";
            // 
            // lstSymbologies
            // 
            this.lstSymbologies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSymbologies.CheckOnClick = true;
            this.lstSymbologies.FormattingEnabled = true;
            this.lstSymbologies.Location = new System.Drawing.Point(7, 54);
            this.lstSymbologies.Name = "lstSymbologies";
            this.lstSymbologies.Size = new System.Drawing.Size(225, 196);
            this.lstSymbologies.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(7, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 36);
            this.panel1.TabIndex = 6;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnHighPriority,
            this.tsbtnLowPriority,
            this.toolStripSeparator4,
            this.tsbtnInfo});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(225, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnHighPriority
            // 
            this.tsbtnHighPriority.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHighPriority.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHighPriority.Image")));
            this.tsbtnHighPriority.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHighPriority.Name = "tsbtnHighPriority";
            this.tsbtnHighPriority.Size = new System.Drawing.Size(23, 22);
            this.tsbtnHighPriority.Text = "Set a higher priority";
            this.tsbtnHighPriority.Click += new System.EventHandler(this.tsbtnHighPriority_Click);
            // 
            // tsbtnLowPriority
            // 
            this.tsbtnLowPriority.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLowPriority.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLowPriority.Image")));
            this.tsbtnLowPriority.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLowPriority.Name = "tsbtnLowPriority";
            this.tsbtnLowPriority.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLowPriority.Text = "Set a lower priority";
            this.tsbtnLowPriority.Click += new System.EventHandler(this.tsbtnLowPriority_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnInfo
            // 
            this.tsbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInfo.Image")));
            this.tsbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInfo.Name = "tsbtnInfo";
            this.tsbtnInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnInfo.Click += new System.EventHandler(this.tsbtnInfo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOpenImage,
            this.toolStripSeparator1,
            this.tsbtnReadBarcodes,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tsbtnRot0,
            this.tsbtnRot90,
            this.tsbtnRot180,
            this.tsbtnRot270,
            this.toolStripSeparator3,
            this.tsbtnInvert,
            this.toolStripSeparator5,
            this.tsbtnSupport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 39);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbtnOpenImage
            // 
            this.tsbtnOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpenImage.Image")));
            this.tsbtnOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenImage.Name = "tsbtnOpenImage";
            this.tsbtnOpenImage.Size = new System.Drawing.Size(121, 36);
            this.tsbtnOpenImage.Text = "Open image...";
            this.tsbtnOpenImage.Click += new System.EventHandler(this.tsbtnOpenImage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnReadBarcodes
            // 
            this.tsbtnReadBarcodes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReadBarcodes.Image")));
            this.tsbtnReadBarcodes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReadBarcodes.Name = "tsbtnReadBarcodes";
            this.tsbtnReadBarcodes.Size = new System.Drawing.Size(135, 36);
            this.tsbtnReadBarcodes.Text = "Read barcodes...";
            this.tsbtnReadBarcodes.Click += new System.EventHandler(this.tsbtnReadBarcodes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 36);
            this.toolStripLabel1.Text = "Rotation:";
            // 
            // tsbtnRot0
            // 
            this.tsbtnRot0.Checked = true;
            this.tsbtnRot0.CheckOnClick = true;
            this.tsbtnRot0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnRot0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRot0.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRot0.Image")));
            this.tsbtnRot0.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRot0.Name = "tsbtnRot0";
            this.tsbtnRot0.Size = new System.Drawing.Size(36, 36);
            // 
            // tsbtnRot90
            // 
            this.tsbtnRot90.CheckOnClick = true;
            this.tsbtnRot90.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRot90.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRot90.Image")));
            this.tsbtnRot90.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRot90.Name = "tsbtnRot90";
            this.tsbtnRot90.Size = new System.Drawing.Size(36, 36);
            this.tsbtnRot90.Text = "Barcodes might be rotated 90 degrees";
            // 
            // tsbtnRot180
            // 
            this.tsbtnRot180.CheckOnClick = true;
            this.tsbtnRot180.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRot180.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRot180.Image")));
            this.tsbtnRot180.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRot180.Name = "tsbtnRot180";
            this.tsbtnRot180.Size = new System.Drawing.Size(36, 36);
            this.tsbtnRot180.Text = "Barcodes might be rotated 180 degrees";
            // 
            // tsbtnRot270
            // 
            this.tsbtnRot270.CheckOnClick = true;
            this.tsbtnRot270.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRot270.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRot270.Image")));
            this.tsbtnRot270.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRot270.Name = "tsbtnRot270";
            this.tsbtnRot270.Size = new System.Drawing.Size(36, 36);
            this.tsbtnRot270.Text = "Barcodes might be rotated 270 degrees";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnInvert
            // 
            this.tsbtnInvert.CheckOnClick = true;
            this.tsbtnInvert.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInvert.Image")));
            this.tsbtnInvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInvert.Name = "tsbtnInvert";
            this.tsbtnInvert.Size = new System.Drawing.Size(163, 36);
            this.tsbtnInvert.Text = "Enable Light Barcodes";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnSupport
            // 
            this.tsbtnSupport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSupport.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSupport.Image")));
            this.tsbtnSupport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSupport.Name = "tsbtnSupport";
            this.tsbtnSupport.Size = new System.Drawing.Size(114, 36);
            this.tsbtnSupport.Text = "Contact Support...";
            this.tsbtnSupport.Click += new System.EventHandler(this.tsbtnSupport_Click);
            // 
            // imgViewer
            // 
            this.imgViewer.AutoScroll = true;
            this.imgViewer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgViewer.Location = new System.Drawing.Point(10, 10);
            this.imgViewer.Name = "imgViewer";
            this.imgViewer.PictureFile = "";
            this.imgViewer.Size = new System.Drawing.Size(694, 526);
            this.imgViewer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 607);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Neodynamic Barcode Reader SDK (C#)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanlineDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanlineThickness)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinNumOfDataChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNumOfBarcodes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ImageViewer imgViewer;
        private System.Windows.Forms.CheckedListBox lstSymbologies;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblFileName;
        private System.Windows.Forms.ToolStripButton tsbtnOpenImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnReadBarcodes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnInvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMaxNumOfBarcodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudMinNumOfDataChars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudScanTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboScanDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudScanlineDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudScanlineThickness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnRot0;
        private System.Windows.Forms.ToolStripButton tsbtnRot90;
        private System.Windows.Forms.ToolStripButton tsbtnRot180;
        private System.Windows.Forms.ToolStripButton tsbtnRot270;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnHighPriority;
        private System.Windows.Forms.ToolStripButton tsbtnLowPriority;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnSupport;
    }
}

