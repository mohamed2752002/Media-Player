namespace WindowsFormsApp5
{
    partial class Media
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.SeekBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.VolumeBtn = new System.Windows.Forms.Button();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.pausebtn = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.FullScreenBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.RestoreBtn);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.MaximizeBtn);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 69);
            this.panel1.TabIndex = 1;
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestoreBtn.BackgroundImage")));
            this.RestoreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RestoreBtn.FlatAppearance.BorderSize = 0;
            this.RestoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreBtn.Location = new System.Drawing.Point(1140, 25);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(34, 41);
            this.RestoreBtn.TabIndex = 6;
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Visible = false;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.BackgroundImage")));
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(1081, 25);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(42, 35);
            this.MinimizeBtn.TabIndex = 5;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaximizeBtn.BackgroundImage")));
            this.MaximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Location = new System.Drawing.Point(1140, 22);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(34, 41);
            this.MaximizeBtn.TabIndex = 5;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(1191, 22);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 41);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Violet;
            this.panel2.Controls.Add(this.FullScreenBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.VolumeSlider);
            this.panel2.Controls.Add(this.SeekBar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ForwardBtn);
            this.panel2.Controls.Add(this.VolumeBtn);
            this.panel2.Controls.Add(this.MuteBtn);
            this.panel2.Controls.Add(this.PreviousBtn);
            this.panel2.Controls.Add(this.stopBtn);
            this.panel2.Controls.Add(this.playBtn);
            this.panel2.Controls.Add(this.pausebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 85);
            this.panel2.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.Violet;
            this.AddBtn.Location = new System.Drawing.Point(3, 27);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(65, 55);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.BackColor = System.Drawing.Color.MediumOrchid;
            this.VolumeSlider.Location = new System.Drawing.Point(975, 26);
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(178, 56);
            this.VolumeSlider.TabIndex = 5;
            this.VolumeSlider.Value = 4;
            // 
            // SeekBar
            // 
            this.SeekBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeekBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeekBar.Location = new System.Drawing.Point(122, 4);
            this.SeekBar.Name = "SeekBar";
            this.SeekBar.Size = new System.Drawing.Size(1001, 19);
            this.SeekBar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(38, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(1149, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumOrchid;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(1187, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(887, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "volume";
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForwardBtn.BackgroundImage")));
            this.ForwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardBtn.FlatAppearance.BorderSize = 0;
            this.ForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardBtn.Location = new System.Drawing.Point(680, 27);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(42, 50);
            this.ForwardBtn.TabIndex = 3;
            this.ForwardBtn.UseVisualStyleBackColor = true;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolumeBtn.BackgroundImage")));
            this.VolumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeBtn.FlatAppearance.BorderSize = 0;
            this.VolumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolumeBtn.Location = new System.Drawing.Point(902, 23);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(42, 50);
            this.VolumeBtn.TabIndex = 3;
            this.VolumeBtn.UseVisualStyleBackColor = true;
            this.VolumeBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // MuteBtn
            // 
            this.MuteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MuteBtn.BackgroundImage")));
            this.MuteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MuteBtn.FlatAppearance.BorderSize = 0;
            this.MuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteBtn.Location = new System.Drawing.Point(902, 21);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(42, 50);
            this.MuteBtn.TabIndex = 2;
            this.MuteBtn.UseVisualStyleBackColor = true;
            this.MuteBtn.Visible = false;
            this.MuteBtn.Click += new System.EventHandler(this.MuteBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousBtn.BackgroundImage")));
            this.PreviousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousBtn.FlatAppearance.BorderSize = 0;
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.Location = new System.Drawing.Point(499, 27);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(42, 50);
            this.PreviousBtn.TabIndex = 2;
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopBtn.BackgroundImage")));
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(620, 27);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(42, 50);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stop_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Location = new System.Drawing.Point(556, 33);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(46, 38);
            this.playBtn.TabIndex = 0;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pausebtn
            // 
            this.pausebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pausebtn.BackgroundImage")));
            this.pausebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pausebtn.FlatAppearance.BorderSize = 0;
            this.pausebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausebtn.Location = new System.Drawing.Point(556, 33);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(54, 38);
            this.pausebtn.TabIndex = 1;
            this.pausebtn.UseVisualStyleBackColor = true;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 69);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1234, 545);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // FullScreenBtn
            // 
            this.FullScreenBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullScreenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullScreenBtn.BackgroundImage")));
            this.FullScreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FullScreenBtn.Enabled = false;
            this.FullScreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreenBtn.Location = new System.Drawing.Point(418, 35);
            this.FullScreenBtn.Name = "FullScreenBtn";
            this.FullScreenBtn.Size = new System.Drawing.Size(61, 42);
            this.FullScreenBtn.TabIndex = 11;
            this.FullScreenBtn.UseVisualStyleBackColor = true;
            this.FullScreenBtn.Click += new System.EventHandler(this.FullScreenBtn_Click);
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1234, 699);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Media";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button pausebtn;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button VolumeBtn;
        private System.Windows.Forms.Button MuteBtn;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar SeekBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddBtn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button FullScreenBtn;
    }
}

