using System;
using System.Windows.Forms;

namespace ddvidplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Video Files|*.mp4;*.avi;*.wmv;*.mov";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
