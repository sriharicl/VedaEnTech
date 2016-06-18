using Microsoft.Reporting.WinForms;
using Neodynamic.SDK.BarcodeReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoScProject.COSCDataSetTableAdapters;
using CoScProject.DataSetRptsTableAdapters;
using System.IO;
namespace CoScProject
{
    public partial class Form1 : Form
    {

        private static string coscConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["VedConnections"].ConnectionString;
        string getSpecificProductCommand = "";
        public int firstScan = 0;
        public bool barcodeChanged = false;
        DataTable tableforReports = new DataTable();
        DataTable tableFillSpecificDetails = new DataTable();
        private string reportNumber;
        private int[] scannedBarcodeIds;
        private string oldBarcodeID = "";

        int i = 1;
        int k = 0;
        int noOfScans = 0;
        int rowC = 0;
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        public int noofScans = 0;



        //form initiation: Loads all components that are needed.
        public Form1()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            //set the size of the form
            this.MaximumSize = new System.Drawing.Size(1300, 1300);

            //Read the input from USB or Serial Port

            // GetAllPorts();
            // string[] Arrayh;
            //Arrayh= SerialPort.GetPortNames();
            //MessageBox.Show(Arrayh[0]);
        }
        //Get the scanned id to the form
        public List<string> GetAllPorts()
        {
            List<String> allPorts = new List<String>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allPorts.Add(portName);
            }
            return allPorts;
        }
        //Load the job numbers in the dropdown.
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["VedConnections"].ConnectionString;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadJobNumbers";
                SqlDataReader sdr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(sdr);
                IList<string> jobList = new List<string>();
                jobList.Add("Select");

                while (sdr.Read())
                {
                    jobList.Add(sdr[0].ToString());
                }
                con.Close();
                ddlJobList.DataSource = jobList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // TODO: This line of code loads data into the 'cOSCDataSet.COSCREPORTS' table. You can move, or remove it, as needed.
            this.cOSCREPORTSTableAdapter1.Fill(this.cOSCDataSet.COSCREPORTS);
            CoscDAL objCoscDAL = new CoscDAL();
            DataTable dtJobs = objCoscDAL.getJobs();
            cmbJobNo.Enabled = true;
            cmbJobNo.DataSource = dtJobs;
            //cmbJobNo.Items.Add("---Select Job---");

            cmbJobNo.ValueMember = "jobno";
            cmbJobNo.DisplayMember = "jobno";
            //for job details in inventory
            cmbJobNoInventory.DataSource = dtJobs;
            cmbJobNoInventory.ValueMember = "jobno";
            cmbJobNoInventory.DisplayMember = "jobno";

            cmbJobNo.Enabled = true;


            //Data from Scanner to txtBarcodeID

            //SerialPort _serialPort = new SerialPort("COM1");
            //_serialPort.BaudRate = 9600;
            //_serialPort.Parity = Parity.None;
            //_serialPort.StopBits = StopBits.One;
            //_serialPort.DataBits = 8;
            //_serialPort.Handshake = Handshake.None;
            //_serialPort.RtsEnable = true;

            //_serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            //_serialPort.Open();

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            txtBarcodeId.Text = indata;
        }


        //Get Details Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text == "")
            {
                errorProvider1.SetError(txtVehicleNo, "Enter Vehicle No.");
                MessageBox.Show("Enter Vehicle No.");
            }
            else
            {
                errorProvider1.Clear();
                string barcodeID = txtBarcodeId.Text;
                firstScan += 1;
                FillData(barcodeID);
            }



        }
        //this is for searching the product with the barcode id
        private void FillData(string barcodeID)
        {
            //  dictionary.Add(Convert.ToInt32(barcodeID), i);
            try
            {

                //load data into the gridview
                if (barcodeID != null && barcodeID != "")
                {

                    SqlConnection connProductDetails = new SqlConnection(coscConnectionString);
                    connProductDetails.Open();
                    SqlCommand commProductDetails = new SqlCommand("getProductDetails", connProductDetails);
                    commProductDetails.CommandType = CommandType.StoredProcedure;
                    commProductDetails.Parameters.AddWithValue("@barcodeId", barcodeID);
                    commProductDetails.Parameters.AddWithValue("@JobNo", cmbJobNo.Text);
                    SqlDataAdapter dataAdapterFillSpecificDetails = new SqlDataAdapter();
                    dataAdapterFillSpecificDetails.SelectCommand = commProductDetails;
                    dataAdapterFillSpecificDetails.Fill(tableFillSpecificDetails);

                    //The data set is empty : for a job there is no product matching with the barcode id - Throw a error message
                    if (tableFillSpecificDetails.Rows.Count == 0)
                    {
                        MessageBox.Show("Sorry! No matching details found. Please check the Jobno and barcode id.");
                        firstScan--;
                    }
                    // the scan when it contains job number other than selected job number

                    //else if (Convert.ToString(tableFillSpecificDetails.Rows[noOfScans][1])!=cmbJobNo.Text)
                    //{
                    //    MessageBox.Show("Current Job is currently being scanned");
                    //}
                    else
                    {
                        if (firstScan < 2)
                        {
                            gdvProductdetails.Columns.Add("barcodeid", "Id");
                            gdvProductdetails.Columns.Add("jobno", "Job");
                            gdvProductdetails.Columns.Add("projectname", "Project");
                            gdvProductdetails.Columns.Add("customer", "Customer");
                            gdvProductdetails.Columns.Add("area", "Area");
                            gdvProductdetails.Columns.Add("serialno", "S.No");
                            gdvProductdetails.Columns.Add("itemdescription", "Description");
                            gdvProductdetails.Columns.Add("w", "Width");
                            gdvProductdetails.Columns.Add("h", "Height");
                            gdvProductdetails.Columns.Add("w1", "Width1");
                            gdvProductdetails.Columns.Add("h1", "Height1");
                            gdvProductdetails.Columns.Add("length", "Length");
                            gdvProductdetails.Columns.Add("numberofunits", "No.units");
                            gdvProductdetails.Columns.Add("gauge", "Gauge");
                            gdvProductdetails.Columns.Add("uom", "Uom");
                            gdvProductdetails.Columns.Add("unitquantity", "UnitQuantity");
                            gdvProductdetails.Columns.Add("totalquantity", "TotalQuantity");
                            gdvProductdetails.Columns.Add("inventory", "inventory");


                            //
                            tableforReports.Columns.Add("reportnumber", typeof(String));
                            tableforReports.Columns.Add("vehiclenumber", typeof(String));
                            tableforReports.Columns.Add("reportdate", typeof(DateTime));
                            tableforReports.Columns.Add("barcodeid", typeof(Int32));
                            tableforReports.Columns.Add("jobno", typeof(String));
                            tableforReports.Columns.Add("projectname", typeof(String));
                            tableforReports.Columns.Add("customer", typeof(String));
                            tableforReports.Columns.Add("area", typeof(String));
                            tableforReports.Columns.Add("serialno", typeof(String));
                            tableforReports.Columns.Add("itemdescription", typeof(String));
                            tableforReports.Columns.Add("w", typeof(Int32));
                            tableforReports.Columns.Add("h", typeof(Int32));
                            tableforReports.Columns.Add("w1", typeof(Int32));
                            tableforReports.Columns.Add("h1", typeof(Int32));
                            tableforReports.Columns.Add("length", typeof(Int32));
                            tableforReports.Columns.Add("numberofunits", typeof(Int32));
                            tableforReports.Columns.Add("gauge", typeof(Int32));
                            tableforReports.Columns.Add("uom", typeof(String));
                            tableforReports.Columns.Add("unitquantity", typeof(Double));
                            tableforReports.Columns.Add("totalquantity", typeof(Double));
                            tableforReports.Columns.Add("seqno", typeof(Int32));


                        }

                        //index check for multiple
                        int i = 0;
                        Dictionary<int,int> dictionary =  new Dictionary<int, int>();

                        dictionary.Add(i, Convert.ToInt32(barcodeID));
                        
                        //add condition to to enable different barcode id scans
                        //DataRow dr = tableFillSpecificDetails.Rows[noofScans];
                        //noofScans++;

                       //if(barcodeID == oldBarcodeID)
                       //    avoidDuplicateDetails();


                        DataRow dr = tableFillSpecificDetails.Rows[noOfScans];
                        if (oldBarcodeID != "" && barcodeID != oldBarcodeID || !dictionary.ContainsKey(Convert.ToInt32(barcodeID)))
                        {
                            if (!dictionary.ContainsKey(Convert.ToInt32(barcodeID)))
                            {
                                dictionary.Add(Convert.ToInt32(barcodeID), rowC);
                                rowC = rowC + 1;
                                {
                                    //if (barcodeID != oldBarcodeID)
                                    {
                                        gdvProductdetails.Rows.Add(
                                        dr[0].ToString(),
                                        dr[1].ToString(),
                                        dr[2].ToString(),
                                        dr[3].ToString(),
                                        dr[4].ToString(),
                                        dr[5].ToString(),
                                        dr[6].ToString(),
                                        dr[7].ToString(),
                                        dr[8].ToString(),
                                        dr[9].ToString(),
                                        dr[10].ToString(),
                                        dr[11].ToString(),
                                        dr[12].ToString(),
                                        dr[13].ToString(),
                                        dr[14].ToString(),
                                        dr[15].ToString(),
                                        dr[16].ToString(),
                                        dr[17].ToString()

                                        );

                                        CoscDAL _coscDal = new CoscDAL();
                                        int maxNo = _coscDal.getMaxReportNumber();

                                        //generate Number

                                        reportNumber = "COSC" + maxNo + "RPT";

                                        string vehicleNumber = txtVehicleNo.Text;
                                        DateTime dateNow = DateTime.Now.Date;
                                        tableforReports.Rows.Add(
                                        reportNumber,
                                        vehicleNumber,
                                        dateNow,
                                        Convert.ToString(dr[0]),
                                        Convert.ToString(dr[1]),
                                        Convert.ToString(dr[2]),
                                        Convert.ToString(dr[3]),
                                        Convert.ToString(dr[4]),
                                        Convert.ToString(dr[5]),
                                        Convert.ToString(dr[6]),
                                        Convert.ToString(dr[7]) == string.Empty ? 0 : Convert.ToInt32(dr[7]),
                                        Convert.ToString(dr[8]) == string.Empty ? 0 : Convert.ToInt32(dr[8]),
                                        Convert.ToString(dr[9]) == string.Empty ? 0 : Convert.ToInt32(dr[9]),
                                        Convert.ToString(dr[10]) == string.Empty ? 0 : Convert.ToInt32(dr[10]),
                                        Convert.ToString(dr[11]) == string.Empty ? 0 : Convert.ToInt32(dr[11]),
                                        Convert.ToString(dr[12]) == string.Empty ? 0 : Convert.ToInt32(dr[12]),
                                        Convert.ToString(dr[13]) == string.Empty ? 0 : Convert.ToInt32(dr[13]),
                                        Convert.ToString(dr[14]),
                                        Convert.ToString(dr[15]),
                                        Convert.ToString(dr[16]), maxNo);
                                        tableforReports.AcceptChanges();

                                        int columnCount = gdvProductdetails.Columns.Count;

                                        for (int j = 0; j < columnCount; j++)
                                        {
                                            gdvProductdetails.Columns[j].ReadOnly = true;

                                        }
                                        gdvProductdetails.Columns[0].Visible = false;

                                        //resize the data grid after loading the data
                                        gdvProductdetails.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                                    }

                                }
                            }
                            else
                            {
                                int value1;
                                dictionary.TryGetValue(Convert.ToInt32(barcodeID), out value1);
                                incrementQuantity(value1);

                            }
                            
                        }
                        else
                        {
                            // dictionary.Add(Convert.ToInt32(barcodeID), rowC);
                            int value;
                            dictionary.TryGetValue(Convert.ToInt32(barcodeID), out value);
                            incrementQuantity(value);

                        }
                        noOfScans += 1;

                    }

                }
                else
                {
                    MessageBox.Show("Please check and re-enter the barcode");
                    firstScan--;
                }
            }
            catch (Exception e)
            {
                 MessageBox.Show(e.ToString());
            }
            oldBarcodeID = txtBarcodeId.Text;


        }
        //This will avoid retrieving already scanned barcode id details
        private void incrementQuantity(int rowNumber)
        {
            //To check if the barcode id has already been scanned.
            if (gdvProductdetails.Rows.Count != 0)
            {
                {
                    {
                        int quant = Convert.ToInt32(gdvProductdetails.Rows[rowNumber].Cells[12].Value);
                        int inventory = Convert.ToInt32(gdvProductdetails.Rows[rowNumber].Cells[17].Value);
                        quant += 1;
                        //check if the quant is > inventory
                        if (quant <= inventory)
                        {
                            gdvProductdetails.Rows[rowNumber].Cells[12].Value = quant.ToString();
                            tableforReports.Rows[rowNumber][15] = quant.ToString();

                        }
                    }
                }
            }
        }
        //generate report button
        private void btnDispatch_Click(object sender, EventArgs e)
        {
            btnDispatch.Enabled = false;
            btnClearReport.Enabled = true;
            DataGridView gdvReportForDispatch = new DataGridView();
            reportViewerDispatched.Visible = true;
            using (SqlConnection con = new SqlConnection(coscConnectionString))
            {
                con.Open();

                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                {
                    //Set the database table name
                    if (txtBarcodeId.Text != null && txtBarcodeId.Text != "")
                    {

                        sqlBulkCopy.DestinationTableName = "COSCREPORTS";

                        //Map the DataTable columns with that of the database table
                        sqlBulkCopy.ColumnMappings.Add("reportnumber", "reportnumber");
                        sqlBulkCopy.ColumnMappings.Add("vehiclenumber", "vehiclenumber");
                        sqlBulkCopy.ColumnMappings.Add("reportdate", "reportdate");
                        sqlBulkCopy.ColumnMappings.Add("barcodeid", "barcodeid");
                        sqlBulkCopy.ColumnMappings.Add("jobno", "jobno");
                        sqlBulkCopy.ColumnMappings.Add("projectname", "projectname");
                        sqlBulkCopy.ColumnMappings.Add("customer", "customer");
                        sqlBulkCopy.ColumnMappings.Add("area", "area");
                        sqlBulkCopy.ColumnMappings.Add("serialno", "serialno");
                        sqlBulkCopy.ColumnMappings.Add("itemdescription", "itemdescription");
                        sqlBulkCopy.ColumnMappings.Add("w", "w");
                        sqlBulkCopy.ColumnMappings.Add("h", "h");
                        sqlBulkCopy.ColumnMappings.Add("w1", "w1");
                        sqlBulkCopy.ColumnMappings.Add("h1", "h1");
                        sqlBulkCopy.ColumnMappings.Add("length", "length");
                        sqlBulkCopy.ColumnMappings.Add("numberofunits", "numberofunits");
                        sqlBulkCopy.ColumnMappings.Add("gauge", "gauge");
                        sqlBulkCopy.ColumnMappings.Add("uom", "uom");
                        sqlBulkCopy.ColumnMappings.Add("unitquantity", "unitquantity");
                        sqlBulkCopy.ColumnMappings.Add("totalquantity", "totalquantity");
                        sqlBulkCopy.ColumnMappings.Add("seqno", "seqno");
                        try
                        {
                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                            }
                            sqlBulkCopy.BatchSize = 10000;
                            sqlBulkCopy.BulkCopyTimeout = 0;
                            sqlBulkCopy.WriteToServer(tableforReports);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check and re-enter the barcode");
                    }
                }
            }
            updateInventory();
            GenerateReport();
            txtBarcodeId.Text = "";
            txtVehicleNo.Text = "";
            oldBarcodeID = "";
            noOfScans = 0;
            dictionary.Clear();
            rowC = 0;

        }
        private void updateInventory()
        {
            DataTable inventoryUpdate = new DataTable();
            if (gdvProductdetails.RowCount != 0)
            {
                foreach (DataGridViewRow dr in gdvProductdetails.Rows)
                {
                    int quantity = Convert.ToInt32(dr.Cells[12].Value);
                    string barcode = dr.Cells[0].Value.ToString();
                    SqlConnection conn = new SqlConnection(coscConnectionString);
                    conn.Open();
                    SqlCommand cmdInventory = new SqlCommand("UpdateInventoryQuantity", conn);
                    cmdInventory.CommandType = CommandType.StoredProcedure;
                    cmdInventory.Parameters.AddWithValue("@quantity", quantity);
                    cmdInventory.Parameters.AddWithValue("@barcode", barcode);
                    cmdInventory.ExecuteNonQuery();
                }
            }
        }
        private void GenerateReport()
        {
            try
            {
                //generate report
                this.gdvProductdetails.DataSource = null;
                this.gdvProductdetails.Rows.Clear();
                lblReportNo.Text = reportNumber + " " + "created.";
                reportViewerDispatched.Reset();
                reportViewerDispatched.ProcessingMode = ProcessingMode.Local;
                reportViewerDispatched.LocalReport.DataSources.Clear();
                reportViewerDispatched.Clear();
                BindingSource bs = new BindingSource();
                bs.DataSource = tableforReports;
                ReportDataSource dataSource = new ReportDataSource();
                dataSource.Name = "DataSet1";
                dataSource.Value = bs;
                string jobNumber = cmbJobNo.Text;
                string vehicleNumber = txtVehicleNo.Text;
                string reportDate = Convert.ToString(DateTime.Now.Date);
                ReportParameter[] rp = new ReportParameter[4];
                rp[0] = new ReportParameter("jobNumber", jobNumber);
                rp[1] = new ReportParameter("vehicleNumber", vehicleNumber);
                rp[2] = new ReportParameter("reportNumber", reportNumber);
                rp[3] = new ReportParameter("reportDate", reportDate);
                //"E:\\Projects\\CoScProject\\CoScProject\\VedaReport.rdlc";
                reportViewerDispatched.LocalReport.ReportPath = "../../VedaReport.rdlc";
                reportViewerDispatched.LocalReport.SetParameters(rp);
                reportViewerDispatched.LocalReport.DataSources.Add(dataSource);
                //create pdf and excel 
                Byte[] mybytes = reportViewerDispatched.LocalReport.Render("EXCEL");
                Byte[] mybytes2 = reportViewerDispatched.LocalReport.Render("PDF");
                createPdf(mybytes2, reportNumber);
                createExcel(mybytes, reportNumber);
                reportViewerDispatched.LocalReport.Refresh();
                reportViewerDispatched.AutoSize = true;
                reportViewerDispatched.RefreshReport();
                //enable job no after completing the report generation
                cmbJobNo.Enabled = true;
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }

        }
        string pdfPath = @"/../../VedaenTechPdfDump/";
        string excelPath = @"/../../VedaenTechExcelDump/";
        private void createExcel(byte[] mybytes, string reportNumber)
        {
            if (!Directory.Exists(excelPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(excelPath);
                using (FileStream fs = File.Create(excelPath + reportNumber + ".xls"))
                {
                    fs.Write(mybytes, 0, mybytes.Length);
                }
            }
            else
            {
                using (FileStream fs = File.Create(excelPath + reportNumber + ".xls"))
                {
                    fs.Write(mybytes, 0, mybytes.Length);
                }
            }
        }

        private void createPdf(byte[] mybytes, string reportNumber)
        {
            if (!Directory.Exists(pdfPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(pdfPath);
                using (FileStream fs = File.Create(pdfPath + reportNumber + ".pdf"))
                {
                    fs.Write(mybytes, 0, mybytes.Length);
                }
            }
            else
            {
                using (FileStream fs = File.Create(pdfPath + reportNumber + ".pdf"))
                {
                    fs.Write(mybytes, 0, mybytes.Length);
                }
            }

        }
        private void cmbJobNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbJobNo.Enabled = false;
        }

        //this will enable the job dropdown.

        private void btnChangeJob_Click(object sender, EventArgs e)
        {
            cmbJobNo.Enabled = true;
            txtBarcodeId.Text = "";
            txtVehicleNo.Text = "";
        }
        private void btnFetchInvnetory_Click(object sender, EventArgs e)
        {

            SqlConnection connInventory = new SqlConnection(coscConnectionString);
            connInventory.Open();
            SqlCommand commInvetory = new SqlCommand("getInventoryDetails", connInventory);
            commInvetory.CommandType = CommandType.StoredProcedure;
            commInvetory.Parameters.AddWithValue("@barcodeId", txtBarcodeIDInv.Text);
            commInvetory.Parameters.AddWithValue("@JobNo", cmbJobNoInventory.Text);
            SqlDataAdapter daInvenory = new SqlDataAdapter();
            daInvenory.SelectCommand = commInvetory;
            DataTable dtInventory = new DataTable();
            daInvenory.Fill(dtInventory);
            gdvDetailsInventory.DataSource = dtInventory;

        }


        private void Generate_Click(object sender, EventArgs e)
        {
            Barcodes barcodeDetails = new Barcodes();
            DataTable datatable = barcodeDetails._Barcodes;
            DataTable dt = new DataTable();
            //dt.TableName = "Master";
            string selectedJob = ddlJobList.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["VedConnections"].ConnectionString;
            conn.Open();
            try
            {
                SqlCommand generateCmd = new SqlCommand();
                generateCmd.Connection = conn;
                generateCmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@jobno";
                param.Value = selectedJob;
                generateCmd.Parameters.Add(param);
                generateCmd.CommandText = "LoadBarcodes";
                SqlDataReader sdr = generateCmd.ExecuteReader();
                //DataTable dt = new DataTable();
                dt.Load(sdr);
                assignDataToReport(dt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void assignDataToReport(DataTable dt)
        {
            BarcodeReport report = new BarcodeReport();
            DataTable manipulatedDataTable = dt.Clone();
            //manipulatedDataTable.TableName = "Processed";
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["Quantity"]) > 1)
                    {
                        //dr.BeginEdit();
                        int toCreate = Convert.ToInt32(dr["Quantity"]);
                        for (int i = 0; i < toCreate - 1; i++)
                        {
                            DataRow manipulatedDatarow = manipulatedDataTable.NewRow();
                            manipulatedDatarow["CustomerName"] = dr["CustomerName"];
                            manipulatedDatarow["ProjectName"] = dr["ProjectName"];
                            manipulatedDatarow["JobNO"] = dr["JobNO"];
                            manipulatedDatarow["SerialNO"] = dr["SerialNO"];
                            manipulatedDatarow["ItemDescription"] = dr["ItemDescription"];
                            manipulatedDatarow["W"] = dr["W"];
                            manipulatedDatarow["H"] = dr["H"];
                            manipulatedDatarow["W1"] = dr["W1"];
                            manipulatedDatarow["H1"] = dr["H1"];
                            manipulatedDatarow["Guage"] = dr["Guage"];
                            manipulatedDatarow["Barcode"] = "*";
                            manipulatedDatarow["Barcode"] = dr["Barcode"];
                            manipulatedDatarow["Barcode"] = "*";
                            manipulatedDataTable.Rows.Add(manipulatedDatarow);

                        }
                    }
                    else
                    {
                        DataRow manipulatedDatarow1 = manipulatedDataTable.NewRow();
                        manipulatedDatarow1["CustomerName"] = dr["CustomerName"];
                        manipulatedDatarow1["ProjectName"] = dr["ProjectName"];
                        manipulatedDatarow1["JobNO"] = dr["JobNO"];
                        manipulatedDatarow1["SerialNO"] = dr["SerialNO"];
                        manipulatedDatarow1["ItemDescription"] = dr["ItemDescription"];
                        manipulatedDatarow1["W"] = dr["W"];
                        manipulatedDatarow1["H"] = dr["H"];
                        manipulatedDatarow1["W1"] = dr["W1"];
                        manipulatedDatarow1["H1"] = dr["H1"];
                        manipulatedDatarow1["Guage"] = dr["Guage"];
                        manipulatedDatarow1["Barcode"] = "*";
                        manipulatedDatarow1["Barcode"] = dr["Barcode"];
                        manipulatedDatarow1["Barcode"] = "*";
                        manipulatedDataTable.Rows.Add(manipulatedDatarow1);
                    }
                }

                report.Database.Tables["Barcodes"].SetDataSource((DataTable)manipulatedDataTable);

                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

      

        private void btnClearReport_Click(object sender, EventArgs e)
        {
            btnClearReport.Enabled = false;
            btnDispatch.Enabled = true;
            tableforReports.Clear();
            tableFillSpecificDetails.Clear();
            reportViewerDispatched.RefreshReport();

        }


    }
}
