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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void tsbtnOpenImage_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void OpenImage()
        {

            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Open Image File";
            fileDialog.Filter = "Image files (*.bmp;*.jpg;*.gif;*.png;*.tif)|*.bmp;*.jpg;*.gif;*.png;*.tif";

            fileDialog.FilterIndex = 3;
            fileDialog.FileName = "";
            fileDialog.ShowDialog();

            if (fileDialog.FileName == "")
                return;

            imgViewer.PictureFile = fileDialog.FileName;

            lblFileName.Text = "File: " + fileDialog.FileName;

            _imageFilePath = fileDialog.FileName;

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                toolStrip1.Renderer = Antiufo.Controls.Windows7Renderer.Instance;
                toolStrip2.Renderer = Antiufo.Controls.Windows7Renderer.Instance;
            }

            //load supported barcode symbologies
            string[] barcodeSymbologies = Enum.GetNames(typeof(Symbology));
            Array.Sort(barcodeSymbologies);
            lstSymbologies.Items.AddRange(barcodeSymbologies);

            //load scan directions...
            cboScanDirection.Items.AddRange(Enum.GetNames(typeof(ScanDirection)));
            cboScanDirection.SelectedIndex = 1;

        }


        BarcodeReaderHints _readerHints = new BarcodeReaderHints();

        private void UpdateReaderHints()
        {
            if (tsbtnRot0.Checked == false &&
                tsbtnRot90.Checked == false &&
                tsbtnRot180.Checked == false &&
                tsbtnRot270.Checked == false)
            {
                _readerHints.BarcodeRotation = BarcodeRotation.None;
            }
            else
            {
                if (tsbtnRot0.Checked)
                    _readerHints.BarcodeRotation = BarcodeRotation.None;
                if (tsbtnRot90.Checked)
                {
                    if (tsbtnRot0.Checked)
                        _readerHints.BarcodeRotation |= BarcodeRotation.Degrees90;
                    else
                        _readerHints.BarcodeRotation = BarcodeRotation.Degrees90;
                }
                if (tsbtnRot180.Checked)
                {
                    if (tsbtnRot0.Checked || tsbtnRot90.Checked)
                        _readerHints.BarcodeRotation |= BarcodeRotation.Degrees180;
                    else
                        _readerHints.BarcodeRotation = BarcodeRotation.Degrees180;
                }
                if (tsbtnRot270.Checked)
                {
                    if (tsbtnRot0.Checked || tsbtnRot90.Checked || tsbtnRot180.Checked)
                        _readerHints.BarcodeRotation |= BarcodeRotation.Degrees270;
                    else
                        _readerHints.BarcodeRotation = BarcodeRotation.Degrees270;
                }
            }

            _readerHints.InvertSourceImage = tsbtnInvert.Checked;

            _readerHints.MaxNumOfBarcodes = (int)nudMaxNumOfBarcodes.Value;

            _readerHints.ScanlineThickness = (int)nudScanlineThickness.Value;
            _readerHints.ScanlineDistance = (int)nudScanlineDistance.Value;
            _readerHints.ScanDirection = (ScanDirection)Enum.Parse(typeof(ScanDirection), cboScanDirection.SelectedItem.ToString());
            _readerHints.ScanTimeout = (int)nudScanTimeout.Value;

            int minSymbolLength = (int)nudMinNumOfDataChars.Value;
            _readerHints.CodabarMinSymbolLength = minSymbolLength;
            _readerHints.Code128MinSymbolLength = minSymbolLength;
            _readerHints.Code39MinSymbolLength = minSymbolLength;
            _readerHints.Code93MinSymbolLength = minSymbolLength;
            _readerHints.Industrial2of5MinSymbolLength = minSymbolLength;
            _readerHints.Interleaved2of5MinSymbolLength = minSymbolLength;            
            
        }

        
        private BarcodeReader _reader = new BarcodeReader();
        private string _imageFilePath = string.Empty;
        private ScanResultWindow _resultWindow = new ScanResultWindow();


        private void tsbtnReadBarcodes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_imageFilePath))
            {
                MessageBox.Show("Please open an image file containing some barcode.", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lstSymbologies.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a barcode symbology from the list.", "Barcode Symbologies", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                //set barcode reader hints...
                UpdateReaderHints();
                _reader.Hints = _readerHints;
                //set the barcode symbologies selected by the user...
                _reader.Symbology.Clear();
                foreach (object symbology in lstSymbologies.CheckedItems)
                {
                    _reader.Symbology.Add((Symbology)Enum.Parse(typeof(Symbology), symbology.ToString()));
                }
                
                try
                {
                    //perform scan...
                    _resultWindow.Result = _reader.Scan(_imageFilePath);
                    _resultWindow.ShowDialog();                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbtnHighPriority_Click(object sender, EventArgs e)
        {
            ResetBarcodeSymbologiesPriority(-1);
        }

        private void tsbtnLowPriority_Click(object sender, EventArgs e)
        {
            ResetBarcodeSymbologiesPriority(1);
        }

        private void ResetBarcodeSymbologiesPriority(int priority)
        {
            int selectedIndex = lstSymbologies.SelectedIndex;
            
            if (selectedIndex > -1)
            {
                string symbologyName = lstSymbologies.SelectedItem.ToString();
                bool isChecked = lstSymbologies.CheckedIndices.Contains(selectedIndex);
                
                selectedIndex += priority;

                if (selectedIndex >= 0 && selectedIndex < lstSymbologies.Items.Count)
                {                    
                    lstSymbologies.Items.RemoveAt(selectedIndex - priority);
                    lstSymbologies.Items.Insert(selectedIndex, symbologyName);
                    lstSymbologies.SetItemChecked(selectedIndex, isChecked);
                    lstSymbologies.SelectedIndex = selectedIndex;
                }
            }
        }

        
        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you know what barcode symbologies you are going to deal with, then select those only i.e. do not select additional symbologies if they are not needed because that will impact the reader performance. In addition, you can control the symbology priority using the up/down arrow buttons.", "Barcode Symbologies Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void tsbtnSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.neodynamic.com/Support/Support.aspx");
        }

        
    }
}
