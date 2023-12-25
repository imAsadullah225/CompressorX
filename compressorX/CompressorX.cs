using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compressorX
{
    public partial class CompressorX : Form
    {
        public CompressorX()
        {
            InitializeComponent();
        }

        //Form Exit button code
        private void exit_BTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Form Minmized Button code
        private void minimized_BTN_Click(object sender, EventArgs e)
        {
            WindowState =  FormWindowState.Minimized;
        }

        //Bottom Panel Buttons

        public static bool isCompressorOpen = false;
        public static bool isDecompressorOpen = false;

        private void gotoCompressFile_BTN_Click(object sender, EventArgs e)
        {
            if (isCompressorOpen == false && isDecompressorOpen == false)
            {
                compress_Form compressForm = new compress_Form();
                compressForm.Show();

                isCompressorOpen = true;
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }

        private void gotoDecompress_BTN_Click(object sender, EventArgs e)
        {
            if(isDecompressorOpen == false && isCompressorOpen == false)
            {
                decompress_Form decompressForm = new decompress_Form();
                decompressForm.Show();

                isDecompressorOpen = true;
            }
            else
                System.Media.SystemSounds.Beep.Play();
            
        }


        //Mouse Drage Move Code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void mouseMoveDrag_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
