using System;
using System.Windows.Forms;
using System.Drawing;

namespace $rootnamespace$
{
    public class ImageViewer : Panel
    {
        //based on http://www.codeproject.com/KB/linq/ScrollablePicturebox.aspx

        PictureBox innerPicture = new PictureBox();
        private string mPictureFile = string.Empty;
        private bool mAutoScroll = true;

        public ImageViewer()
        {
            // add the inner picture
            innerPicture.Top = 0;
            innerPicture.Left = 0;
            innerPicture.SizeMode = PictureBoxSizeMode.Normal;
            
            Controls.Add(innerPicture);
        }


        public string PictureFile
        {
            get
            {
                return mPictureFile;
            }
            set
            {
                mPictureFile = value;

                if (!string.IsNullOrEmpty(mPictureFile))
                {
                    // set the image to the image file
                    innerPicture.Image = Image.FromFile(mPictureFile);

                    // resize the image to match the image file
                    innerPicture.Size = innerPicture.Image.Size;
                }
                else
                {
                    innerPicture.Image = null;
                }
            }
        }


        public override bool AutoScroll
        {
            get
            {
                return mAutoScroll;
            }
            set
            {
                mAutoScroll = value;
            }
        }


        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                // Change SB_THUMBTRACK to SB_THUMBPOSITION
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }


    }
}
