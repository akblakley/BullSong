namespace BullSong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.PictureBox();
            this.btn_prev = new System.Windows.Forms.PictureBox();
            this.btn_fwd = new System.Windows.Forms.PictureBox();
            this.btn_pause = new System.Windows.Forms.PictureBox();
            this.btn_stop = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.bullSongMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullSongMediaPlayer)).BeginInit();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 55);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(645, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(682, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(719, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "BullSong";
            // 
            // btn_open
            // 
            this.btn_open.Image = global::BullSong.Properties.Resources.Open_grey_16x;
            this.btn_open.Location = new System.Drawing.Point(483, 25);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(85, 39);
            this.btn_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_open.TabIndex = 6;
            this.btn_open.TabStop = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = global::BullSong.Properties.Resources.PreviousFrame_16x;
            this.btn_prev.Location = new System.Drawing.Point(28, 25);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(85, 39);
            this.btn_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_prev.TabIndex = 5;
            this.btn_prev.TabStop = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_fwd
            // 
            this.btn_fwd.Image = global::BullSong.Properties.Resources.NextFrameArrow_16x;
            this.btn_fwd.Location = new System.Drawing.Point(210, 25);
            this.btn_fwd.Name = "btn_fwd";
            this.btn_fwd.Size = new System.Drawing.Size(85, 39);
            this.btn_fwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_fwd.TabIndex = 4;
            this.btn_fwd.TabStop = false;
            this.btn_fwd.Click += new System.EventHandler(this.btn_fwd_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Image = global::BullSong.Properties.Resources.Pause_grey_16x;
            this.btn_pause.Location = new System.Drawing.Point(119, 25);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(85, 39);
            this.btn_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pause.TabIndex = 3;
            this.btn_pause.TabStop = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Image = global::BullSong.Properties.Resources.RecordStop_16x;
            this.btn_stop.Location = new System.Drawing.Point(392, 25);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(85, 39);
            this.btn_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_stop.TabIndex = 2;
            this.btn_stop.TabStop = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.Image = global::BullSong.Properties.Resources.PlayVideo_16x;
            this.btn_play.Location = new System.Drawing.Point(301, 25);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(85, 39);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 1;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // bullSongMediaPlayer
            // 
            this.bullSongMediaPlayer.Enabled = true;
            this.bullSongMediaPlayer.Location = new System.Drawing.Point(61, 61);
            this.bullSongMediaPlayer.Name = "bullSongMediaPlayer";
            this.bullSongMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bullSongMediaPlayer.OcxState")));
            this.bullSongMediaPlayer.Size = new System.Drawing.Size(619, 346);
            this.bullSongMediaPlayer.TabIndex = 7;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.lbl_volume);
            this.controlsGroupBox.Controls.Add(this.labelVolume);
            this.controlsGroupBox.Controls.Add(this.trackBar1);
            this.controlsGroupBox.Controls.Add(this.track_list);
            this.controlsGroupBox.Controls.Add(this.btn_prev);
            this.controlsGroupBox.Controls.Add(this.btn_pause);
            this.controlsGroupBox.Controls.Add(this.btn_open);
            this.controlsGroupBox.Controls.Add(this.btn_fwd);
            this.controlsGroupBox.Controls.Add(this.btn_play);
            this.controlsGroupBox.Controls.Add(this.btn_stop);
            this.controlsGroupBox.Location = new System.Drawing.Point(33, 419);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(702, 208);
            this.controlsGroupBox.TabIndex = 8;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(645, 97);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(34, 19);
            this.lbl_volume.TabIndex = 11;
            this.lbl_volume.Text = "0%";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(581, 179);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(64, 19);
            this.labelVolume.TabIndex = 10;
            this.labelVolume.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(585, 25);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 151);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // track_list
            // 
            this.track_list.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 23;
            this.track_list.Location = new System.Drawing.Point(28, 61);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(540, 119);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(61, 397);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(619, 10);
            this.progressBar1.TabIndex = 9;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Black;
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.Location = new System.Drawing.Point(66, 70);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(101, 19);
            this.lbl_msg.TabIndex = 9;
            this.lbl_msg.Text = "MediaPlayer";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Location = new System.Drawing.Point(6, 391);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(49, 19);
            this.lbl_track_start.TabIndex = 12;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Location = new System.Drawing.Point(686, 391);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(49, 19);
            this.lbl_track_end.TabIndex = 13;
            this.lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(757, 639);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.bullSongMediaPlayer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BullSong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullSongMediaPlayer)).EndInit();
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.PictureBox btn_stop;
        private System.Windows.Forms.PictureBox btn_pause;
        private System.Windows.Forms.PictureBox btn_fwd;
        private System.Windows.Forms.PictureBox btn_prev;
        private System.Windows.Forms.PictureBox btn_open;
        private AxWMPLib.AxWindowsMediaPlayer bullSongMediaPlayer;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

