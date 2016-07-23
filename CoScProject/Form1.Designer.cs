namespace CoScProject
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cOSCREPORTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOSCDataSet = new CoScProject.COSCDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BarcodeReport1 = new CoScProject.BarcodeReport();
            this.Generate = new System.Windows.Forms.Button();
            this.ddlJobList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblReportNo = new System.Windows.Forms.Label();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcodeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.btnGetOrderDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeJob = new System.Windows.Forms.Button();
            this.cmbJobNo = new System.Windows.Forms.ComboBox();
            this.lblInfoOrError = new System.Windows.Forms.Label();
            this.gdvProductdetails = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarcodeIDInv = new System.Windows.Forms.TextBox();
            this.btnFetchInvnetory = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJobNoInventory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gdvDetailsInventory = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClearReport = new System.Windows.Forms.Button();
            this.reportViewerDispatched = new Microsoft.Reporting.WinForms.ReportViewer();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.COSCREPORTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRpts = new CoScProject.DataSetRpts();
            this.COSCREPORTSTableAdapter = new CoScProject.DataSetRptsTableAdapters.COSCREPORTSTableAdapter();
            this.cOSCREPORTSTableAdapter1 = new CoScProject.COSCDataSetTableAdapters.COSCREPORTSTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cOSCREPORTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSCDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProductdetails)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetailsInventory)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COSCREPORTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRpts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cOSCREPORTSBindingSource1
            // 
            this.cOSCREPORTSBindingSource1.DataMember = "COSCREPORTS";
            this.cOSCREPORTSBindingSource1.DataSource = this.cOSCDataSet;
            // 
            // cOSCDataSet
            // 
            this.cOSCDataSet.DataSetName = "COSCDataSet";
            this.cOSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 1301);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Indigo;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.crystalReportViewer1);
            this.tabPage1.Controls.Add(this.Generate);
            this.tabPage1.Controls.Add(this.ddlJobList);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1492, 1275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate Sticker";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 54);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.BarcodeReport1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1280, 600);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // Generate
            // 
            this.Generate.ForeColor = System.Drawing.Color.Black;
            this.Generate.Location = new System.Drawing.Point(290, 16);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // ddlJobList
            // 
            this.ddlJobList.FormattingEnabled = true;
            this.ddlJobList.Location = new System.Drawing.Point(117, 16);
            this.ddlJobList.Name = "ddlJobList";
            this.ddlJobList.Size = new System.Drawing.Size(121, 21);
            this.ddlJobList.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "JobName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lblInfoOrError);
            this.tabPage2.Controls.Add(this.gdvProductdetails);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1492, 1275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barcode Scanning";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.lblReportNo);
            this.groupBox3.Controls.Add(this.btnDispatch);
            this.groupBox3.Location = new System.Drawing.Point(616, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 113);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dispatch";
            // 
            // lblReportNo
            // 
            this.lblReportNo.AutoSize = true;
            this.lblReportNo.Location = new System.Drawing.Point(15, 57);
            this.lblReportNo.Name = "lblReportNo";
            this.lblReportNo.Size = new System.Drawing.Size(70, 13);
            this.lblReportNo.TabIndex = 23;
            this.lblReportNo.Text = "Report status";
            // 
            // btnDispatch
            // 
            this.btnDispatch.Location = new System.Drawing.Point(9, 25);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(84, 23);
            this.btnDispatch.TabIndex = 20;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBarcodeId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVehicleNo);
            this.groupBox2.Controls.Add(this.btnGetOrderDetails);
            this.groupBox2.Location = new System.Drawing.Point(310, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 114);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode ID";
            // 
            // txtBarcodeId
            // 
            this.txtBarcodeId.Location = new System.Drawing.Point(99, 22);
            this.txtBarcodeId.Name = "txtBarcodeId";
            this.txtBarcodeId.Size = new System.Drawing.Size(100, 20);
            this.txtBarcodeId.TabIndex = 1;
            this.txtBarcodeId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeId_KeyDown);
            this.txtBarcodeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeId_KeyUp);
            this.txtBarcodeId.Leave += new System.EventHandler(this.txtBarcodeId_Leave);
            this.txtBarcodeId.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBarcodeId_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enter Vehicle No";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(99, 52);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleNo.TabIndex = 18;
            // 
            // btnGetOrderDetails
            // 
            this.btnGetOrderDetails.Location = new System.Drawing.Point(49, 86);
            this.btnGetOrderDetails.Name = "btnGetOrderDetails";
            this.btnGetOrderDetails.Size = new System.Drawing.Size(125, 23);
            this.btnGetOrderDetails.TabIndex = 2;
            this.btnGetOrderDetails.Text = "Get Product Details";
            this.btnGetOrderDetails.UseVisualStyleBackColor = true;
            this.btnGetOrderDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnChangeJob);
            this.groupBox1.Controls.Add(this.cmbJobNo);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Job.No";
            // 
            // btnChangeJob
            // 
            this.btnChangeJob.Location = new System.Drawing.Point(63, 66);
            this.btnChangeJob.Name = "btnChangeJob";
            this.btnChangeJob.Size = new System.Drawing.Size(56, 21);
            this.btnChangeJob.TabIndex = 24;
            this.btnChangeJob.Text = "Change Job";
            this.btnChangeJob.UseVisualStyleBackColor = true;
            this.btnChangeJob.Click += new System.EventHandler(this.btnChangeJob_Click);
            // 
            // cmbJobNo
            // 
            this.cmbJobNo.FormattingEnabled = true;
            this.cmbJobNo.Location = new System.Drawing.Point(63, 26);
            this.cmbJobNo.Name = "cmbJobNo";
            this.cmbJobNo.Size = new System.Drawing.Size(121, 21);
            this.cmbJobNo.TabIndex = 16;
            this.cmbJobNo.SelectedIndexChanged += new System.EventHandler(this.cmbJobNo_SelectedIndexChanged_1);
            // 
            // lblInfoOrError
            // 
            this.lblInfoOrError.AutoSize = true;
            this.lblInfoOrError.Location = new System.Drawing.Point(14, 220);
            this.lblInfoOrError.Name = "lblInfoOrError";
            this.lblInfoOrError.Size = new System.Drawing.Size(0, 13);
            this.lblInfoOrError.TabIndex = 14;
            // 
            // gdvProductdetails
            // 
            this.gdvProductdetails.AllowUserToAddRows = false;
            this.gdvProductdetails.AllowUserToDeleteRows = false;
            this.gdvProductdetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdvProductdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gdvProductdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProductdetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gdvProductdetails.Location = new System.Drawing.Point(17, 129);
            this.gdvProductdetails.Name = "gdvProductdetails";
            this.gdvProductdetails.Size = new System.Drawing.Size(1214, 200);
            this.gdvProductdetails.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.gdvDetailsInventory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1492, 1275);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtBarcodeIDInv);
            this.groupBox5.Controls.Add(this.btnFetchInvnetory);
            this.groupBox5.Location = new System.Drawing.Point(351, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Barcode ID";
            // 
            // txtBarcodeIDInv
            // 
            this.txtBarcodeIDInv.Location = new System.Drawing.Point(73, 13);
            this.txtBarcodeIDInv.Name = "txtBarcodeIDInv";
            this.txtBarcodeIDInv.Size = new System.Drawing.Size(100, 20);
            this.txtBarcodeIDInv.TabIndex = 4;
            // 
            // btnFetchInvnetory
            // 
            this.btnFetchInvnetory.Location = new System.Drawing.Point(58, 60);
            this.btnFetchInvnetory.Name = "btnFetchInvnetory";
            this.btnFetchInvnetory.Size = new System.Drawing.Size(115, 23);
            this.btnFetchInvnetory.TabIndex = 5;
            this.btnFetchInvnetory.Text = "Fetch Inventory";
            this.btnFetchInvnetory.UseVisualStyleBackColor = true;
            this.btnFetchInvnetory.Click += new System.EventHandler(this.btnFetchInvnetory_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbJobNoInventory);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(33, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Job Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Job No";
            // 
            // cmbJobNoInventory
            // 
            this.cmbJobNoInventory.FormattingEnabled = true;
            this.cmbJobNoInventory.Location = new System.Drawing.Point(53, 21);
            this.cmbJobNoInventory.Name = "cmbJobNoInventory";
            this.cmbJobNoInventory.Size = new System.Drawing.Size(121, 21);
            this.cmbJobNoInventory.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Job";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gdvDetailsInventory
            // 
            this.gdvDetailsInventory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdvDetailsInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDetailsInventory.Location = new System.Drawing.Point(33, 128);
            this.gdvDetailsInventory.Name = "gdvDetailsInventory";
            this.gdvDetailsInventory.Size = new System.Drawing.Size(821, 150);
            this.gdvDetailsInventory.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClearReport);
            this.tabPage4.Controls.Add(this.reportViewerDispatched);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1492, 1275);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClearReport
            // 
            this.btnClearReport.Location = new System.Drawing.Point(651, 0);
            this.btnClearReport.Name = "btnClearReport";
            this.btnClearReport.Size = new System.Drawing.Size(75, 23);
            this.btnClearReport.TabIndex = 1;
            this.btnClearReport.Text = "Clear Report";
            this.btnClearReport.UseVisualStyleBackColor = true;
            this.btnClearReport.Click += new System.EventHandler(this.btnClearReport_Click);
            // 
            // reportViewerDispatched
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.cOSCREPORTSBindingSource1;
            this.reportViewerDispatched.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerDispatched.LocalReport.ReportEmbeddedResource = "CoScProject.VedaReport.rdlc";
            this.reportViewerDispatched.LocalReport.ReportPath = "VedaReport.rdlc";
            this.reportViewerDispatched.Location = new System.Drawing.Point(33, 23);
            this.reportViewerDispatched.Name = "reportViewerDispatched";
            this.reportViewerDispatched.Size = new System.Drawing.Size(983, 448);
            this.reportViewerDispatched.TabIndex = 0;
            // 
            // COSCREPORTSBindingSource
            // 
            this.COSCREPORTSBindingSource.DataMember = "COSCREPORTS";
            this.COSCREPORTSBindingSource.DataSource = this.DataSetRpts;
            // 
            // DataSetRpts
            // 
            this.DataSetRpts.DataSetName = "DataSetRpts";
            this.DataSetRpts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // COSCREPORTSTableAdapter
            // 
            this.COSCREPORTSTableAdapter.ClearBeforeFill = true;
            // 
            // cOSCREPORTSTableAdapter1
            // 
            this.cOSCREPORTSTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "COSC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOSCREPORTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSCDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProductdetails)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetailsInventory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.COSCREPORTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRpts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetOrderDetails;
        private System.Windows.Forms.TextBox txtBarcodeId;
        private System.Windows.Forms.DataGridView gdvProductdetails;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblInfoOrError;
        private System.Windows.Forms.ComboBox cmbJobNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnDispatch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDispatched;
        private System.Windows.Forms.Label lblReportNo;
        private DataSetRpts DataSetRpts;
        private System.Windows.Forms.BindingSource COSCREPORTSBindingSource;
        private DataSetRptsTableAdapters.COSCREPORTSTableAdapter COSCREPORTSTableAdapter;
        private COSCDataSet cOSCDataSet;
        private System.Windows.Forms.BindingSource cOSCREPORTSBindingSource1;
        private COSCDataSetTableAdapters.COSCREPORTSTableAdapter cOSCREPORTSTableAdapter1;
        private System.Windows.Forms.Button btnChangeJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbJobNoInventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarcodeIDInv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFetchInvnetory;
        private System.Windows.Forms.DataGridView gdvDetailsInventory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ComboBox ddlJobList;
        private System.Windows.Forms.Label label6;
        private BarcodeReport BarcodeReport1;

        private System.Windows.Forms.Button btnClearReport;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}

