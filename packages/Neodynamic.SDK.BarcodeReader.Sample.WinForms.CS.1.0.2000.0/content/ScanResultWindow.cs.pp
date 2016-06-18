using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Neodynamic.SDK.BarcodeReader;

namespace $rootnamespace$
{
    public partial class ScanResultWindow : Form
    {
        public ScanResultWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        List<BarcodeScanResult> _result = new List<BarcodeScanResult>();

        public List<BarcodeScanResult> Result
        {
            get { return _result; }
            set { _result = value; }
        }


        private void FormatResult()
        {
            
            if (_result.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < _result.Count; i++)
                {
                    sb.Append(String.Format("DATA: {0}\r\nTYPE: {1}", FormatData(_result[i].Text, chkHex.Checked), _result[i].Symbology.ToString()));
                    sb.Append("\r\n");
                    sb.Append("--------------------------------------------");
                    sb.Append("\r\n");
                }

                txtInfo.Text = sb.ToString();
            }
            else
                txtInfo.Text = "No barcode found! Some tips:\r\n\r\n* Please fine-tune the Scan settings.\r\n* Is the correct barcode symbology selected?\r\n* Is the barcode rotated? Select and check the Rotation buttons on the toolbar.\r\n* Is a light barcode on a dark background? Enable Light Barcodes on the toolbar.\r\n\r\nSend us your image to support@neodynamic.com so our engineers can assist you.";
        }


        private string FormatData(string data, bool convertToHex)
        {
            if (convertToHex)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(Convert.ToString((byte)data[i], 16));
                    if (i < data.Length - 1)
                        sb.Append(" ");
                }
                return sb.ToString();
            }
            else
            {
                return data;
            }
        }


        private void ScanResultWindow_Load(object sender, EventArgs e)
        {
            FormatResult();
        }

        private void chkHex_CheckedChanged(object sender, EventArgs e)
        {
            FormatResult();
        }

    }
}
