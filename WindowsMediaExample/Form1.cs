using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaExample
{
    public partial class Form1 : Form
    {
        // Drag Window Panel
        private bool draggable;
        private int mouseX;
        private int mouseY;
        // Controls
        private bool isPlaying = false;
        private string[] mp3Files;
        private string[] routeFiles;
        private string file;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbVolume.Value = wmPlayer.settings.volume;
            volume.Value = tbVolume.Value.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState.ToString() == "Maximized")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Drag Window
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }

        // Windows media player
        private void BtnStop_Click(object sender, EventArgs e)
        {
            wmPlayer.Ctlcontrols.stop();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            btnQuitar.Visible = true;
            musicFiles.Multiselect = true;
            musicFiles.Filter = "Music (.mp3)|*.mp3";
            if (musicFiles.ShowDialog() == DialogResult.OK)
            {
                mp3Files = musicFiles.SafeFileNames;
                routeFiles = musicFiles.FileNames;
                foreach(var mp3File in mp3Files)
                {
                    songList.Items.Add(mp3File);
                }
            }
            quantitySongs.Value = songList.Items.Count.ToString();
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            wmPlayer.settings.autoStart = false;
            if (wmPlayer.URL == "")
            {
                wmPlayer.URL = routeFiles[0];
                songList.SelectedIndex = 0;
            }
            if (isPlaying == false)
            {
                wmPlayer.Ctlcontrols.play();
            }
            else if(isPlaying == true)
            {
                wmPlayer.Ctlcontrols.pause();
            }
        }
        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            file = routeFiles[songList.SelectedIndex];
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            if (songList.SelectedIndex <= 0)
                btnPrevious.Enabled = false;
            if (songList.SelectedIndex == songList.Items.Count-1)
                btnNext.Enabled = false;
        }
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            file = routeFiles[--songList.SelectedIndex];
            wmPlayer.URL = file;
            wmPlayer.Ctlcontrols.play();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            file = routeFiles[++songList.SelectedIndex];
            wmPlayer.URL = file;
            wmPlayer.Ctlcontrols.play();
//            Image img = wmPlayer.currentMedia.imageSourceHeight;
            //            label2.Text = wmPlayer.currentMedia.durationString;
//            wmPlayer.Ctlcontrols.currentItem.sourceURL
//            Image im = wmPlayer.Ctlcontrols.currentItem.

        }
        private void SongList_DoubleClick(object sender, EventArgs e)
        {
            wmPlayer.URL = file;
            wmPlayer.Ctlcontrols.play();
        }
        private void WmPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 1:    // Stopped
                    songName.Text = "";
                    isPlaying = false;
                    time.Enabled = false;
                    break;
                case 2:    // Paused
                    btnPlay.Load("images/013-play.png");
                    isPlaying = false;
                    time.Enabled = false;
                    break;

                case 3:    // Playing
                    songName.Text = wmPlayer.currentMedia.name;
                    txtDuration.Text = wmPlayer.currentMedia.durationString;
                    btnPlay.Load("images/021-pause.png");
                    isPlaying = true;
                    time.Enabled = true;
                    int total = (int)wmPlayer.currentMedia.duration;
                    progressBar1.Maximum = total;
                    trackBar1.Maximum = total;
                    break;
            }
        }
        private void TbVolume_Scroll(object sender, EventArgs e)
        {
            wmPlayer.settings.volume = tbVolume.Value;
            volume.Value = tbVolume.Value.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {


            /*
            //            int d = wmPlayer.currentMedia.duration;
                        label2.Text = wmPlayer.currentMedia.duration.ToString();
            //            progressBar1.Maximum = wmPlayer.currentMedia.duration;
            //            progressBar1.Value = int.Parse(wmPlayer.Ctlcontrols.currentPositionString);
                        txtActual.Text = wmPlayer.Ctlcontrols.currentPositionString;

                        int min = (int)(wmPlayer.currentMedia.duration / 60000);
                        double seg1 = min - (wmPlayer.currentMedia.duration / 60000);
                        int seg2 = (int)(seg1 * 60);
                        int asds = ((min * 60) + seg2);
                        progressBar1.Maximum = (min * 60) + seg2;
                        txtLeft.Text = asds.ToString();
             */

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)wmPlayer.Ctlcontrols.currentPosition;
            trackBar1.Value = (int)wmPlayer.Ctlcontrols.currentPosition;
            txtActual.Text = wmPlayer.Ctlcontrols.currentPositionString;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            wmPlayer.Ctlcontrols.currentPosition = trackBar1.Value;
        }
    }
}
