namespace WindowsMediaExample
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelRightBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.quantitySongs = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.songList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.volume = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.musicFiles = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.songName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelRightBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmPlayer
            // 
            this.wmPlayer.Enabled = true;
            this.wmPlayer.Location = new System.Drawing.Point(0, 51);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(615, 356);
            this.wmPlayer.TabIndex = 0;
            this.wmPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WmPlayer_PlayStateChange);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(853, 51);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(628, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 51);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(703, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 51);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "𺊮";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(778, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 51);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.DarkRed;
            this.panelRight.Controls.Add(this.panelRightBottom);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(615, 51);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(238, 430);
            this.panelRight.TabIndex = 2;
            // 
            // panelRightBottom
            // 
            this.panelRightBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRightBottom.Controls.Add(this.label1);
            this.panelRightBottom.Controls.Add(this.quantitySongs);
            this.panelRightBottom.Controls.Add(this.songList);
            this.panelRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightBottom.Location = new System.Drawing.Point(0, 52);
            this.panelRightBottom.Name = "panelRightBottom";
            this.panelRightBottom.Size = new System.Drawing.Size(238, 378);
            this.panelRightBottom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad de\r\nCanciones";
            // 
            // quantitySongs
            // 
            this.quantitySongs.ArrayCount = 3;
            this.quantitySongs.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantitySongs.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantitySongs.ColorLight = System.Drawing.Color.DodgerBlue;
            this.quantitySongs.DecimalShow = true;
            this.quantitySongs.ElementPadding = new System.Windows.Forms.Padding(4);
            this.quantitySongs.ElementWidth = 10;
            this.quantitySongs.ItalicFactor = 0F;
            this.quantitySongs.Location = new System.Drawing.Point(136, 319);
            this.quantitySongs.Name = "quantitySongs";
            this.quantitySongs.Size = new System.Drawing.Size(90, 39);
            this.quantitySongs.TabIndex = 7;
            this.quantitySongs.TabStop = false;
            this.quantitySongs.Value = "0";
            // 
            // songList
            // 
            this.songList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songList.Dock = System.Windows.Forms.DockStyle.Top;
            this.songList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 19;
            this.songList.Location = new System.Drawing.Point(0, 0);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(238, 304);
            this.songList.TabIndex = 4;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.SongList_SelectedIndexChanged);
            this.songList.DoubleClick += new System.EventHandler(this.SongList_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 52);
            this.panel1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 52);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(119, 0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(119, 52);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBottom.Controls.Add(this.songName);
            this.panelBottom.Controls.Add(this.groupBox2);
            this.panelBottom.Controls.Add(this.groupBox1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 481);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(853, 86);
            this.panelBottom.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(118, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(85, 85);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(209, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 39);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVolume);
            this.groupBox1.Controls.Add(this.volume);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(623, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(8, 19);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(104, 45);
            this.tbVolume.SmallChange = 5;
            this.tbVolume.TabIndex = 6;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.Value = 100;
            this.tbVolume.Scroll += new System.EventHandler(this.TbVolume_Scroll);
            // 
            // volume
            // 
            this.volume.ArrayCount = 3;
            this.volume.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volume.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volume.ColorLight = System.Drawing.Color.DodgerBlue;
            this.volume.DecimalShow = true;
            this.volume.ElementPadding = new System.Windows.Forms.Padding(4);
            this.volume.ElementWidth = 10;
            this.volume.ItalicFactor = 0F;
            this.volume.Location = new System.Drawing.Point(118, 16);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(90, 39);
            this.volume.TabIndex = 5;
            this.volume.TabStop = false;
            this.volume.Value = "100";
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(56, 22);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 39);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(6, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 39);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // musicFiles
            // 
            this.musicFiles.FileName = "musicFiles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnPrevious);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.ForeColor = System.Drawing.Color.White;
            this.songName.Location = new System.Drawing.Point(308, 32);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(0, 21);
            this.songName.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 413);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(522, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.AutoSize = true;
            this.txtDuration.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.ForeColor = System.Drawing.Color.White;
            this.txtDuration.Location = new System.Drawing.Point(534, 448);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(0, 16);
            this.txtDuration.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(853, 567);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.wmPlayer);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRightBottom.ResumeLayout(false);
            this.panelRightBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Panel panelRightBottom;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbVolume;
        private DmitryBrant.CustomControls.SevenSegmentArray volume;
        private DmitryBrant.CustomControls.SevenSegmentArray quantitySongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog musicFiles;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtDuration;
    }
}

