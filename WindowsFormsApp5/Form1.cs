using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    
    public partial class Media : Form
    {
        string videoPath ,videoTitle;
        public Media()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pausebtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            playBtn.Visible = true;
            pausebtn.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            RestoreBtn.Visible = true;
            MaximizeBtn.Visible = false;
            this.WindowState = FormWindowState.Maximized;   
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.Ctlcontrols.play();
            playBtn.Visible=false;
            pausebtn.Visible = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
             axWindowsMediaPlayer1.Ctlcontrols. stop();
            playBtn.Visible=true;
            pausebtn.Visible=false;

        }

        private void mediaplayer_Click(object sender, EventArgs e)
        {

        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            MaximizeBtn.Visible = true;
            RestoreBtn.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MuteBtn.Visible = true;
            VolumeBtn.Visible = false;
            VolumeSlider.Value = 0;
        }

        private void MuteBtn_Click(object sender, EventArgs e)
        {
            VolumeBtn.Visible = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();

        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();

        }

        private void FullScreenBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen=true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
            
        {
            
            
            playBtn.Visible = false;
            pausebtn.Visible = true;
           
            FullScreenBtn.Enabled = true;

            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect=false,Filter="MP4 File|*.mp4|All File|*.*"};
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                videoPath=openFileDialog.FileName;
                videoTitle=openFileDialog.SafeFileName;
                axWindowsMediaPlayer1.URL = videoPath;
                
            }
        }
    }
}
