/* 
 Name: Amanda Blakley
 Course: ISM4300 
 Title: BullSong Mediaplayer - Final project 
 */

using System;
using System.Windows.Forms;

namespace BullSong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare variables  

        string[] paths, files;

        /* Listbox click event 
           The listbox is populated with media files and automatically plays the selected item
           This class also calls the timer and progressbar methods
        */

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            bullSongMediaPlayer.URL = paths[track_list.SelectedIndex]; // Set the URL property to the file path
            bullSongMediaPlayer.Ctlcontrols.play();
            timer1.Start();

            /* The default volume is set to 50% and can be adjusted 
               The volume label displays the volume level in terms of percentage
            */

            trackBar1.Value = 50;
            bullSongMediaPlayer.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value + "%";
        }

        /* Play button click event 
           The select file automatially plays and the state is displayed as "Playing" 
           in the Message label in the top right hand corner if the player
        */
        private void btn_play_Click(object sender, EventArgs e)
        {
            bullSongMediaPlayer.Ctlcontrols.play();
            lbl_msg.Text = "Playing...";
        }

        /* Pause button click event 
           The select file automatially plays and the state is displayed as "Paused" 
           in the Message label in the top right hand corner if the player
         */
        private void btn_pause_Click(object sender, EventArgs e)
        {
            bullSongMediaPlayer.Ctlcontrols.pause();
            lbl_msg.Text = "Paused";
        }

        /* Stop button click event 
           The select file automatially plays and the state is displayed as "Stop" 
           in the Message label in the top right hand corner if the player
        */
        private void btn_stop_Click(object sender, EventArgs e)
        {
            bullSongMediaPlayer.Ctlcontrols.stop();
            lbl_msg.Text = "Stop";
        }

        /* Next button click event 
           If the user clicks the "Next" button, the player advances to 
           the next track contained in the listbox
        */
        private void btn_fwd_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        /* Previous button click event 
           If the user clicks the "Previous" button, the player advances to 
           the last track contained in the listbox
        */
        private void btn_prev_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        /* Timer tick event 
           This class handles the progress bar and displays 
           the "Start" and "End" track times in their respective labels
        */

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(bullSongMediaPlayer.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)bullSongMediaPlayer.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)bullSongMediaPlayer.Ctlcontrols.currentPosition;
            }

            // Displays current time status and total track duration 

            lbl_track_start.Text = bullSongMediaPlayer.Ctlcontrols.currentPositionString;
            lbl_track_end.Text = bullSongMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();
        }

        /* Trackbar scroll event 
           If the user clicks the adjusts the scrollbar, the volume 
           level is displayed in the Volume label
        */

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            bullSongMediaPlayer.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value.ToString() + "%";
        }

        /* Exit button click event 
           If the user clicks the "Exit" button, a messagebox appears
           asking the user if they would like to exit the application
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this program?", "Exit", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// Maximize button click event 
        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        // Minimize button click event
        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /* Form load event
           Sets and displays initial volume value in a label
       */
        private void Form1_Load(object sender, EventArgs e)
        {
            bullSongMediaPlayer.uiMode = "None";
            bullSongMediaPlayer.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value + "%";
        }

        /* Open Button click event. 
           A standard window's dialog box will open with showdialog method. 
           Multiselect is enabled by settings it to true, so we are able to select multiple files when we open the Dialog Box.
           A for loop is executed in order to add files to the listbox.
        */
        private void btn_open_Click(object sender, EventArgs e) 
        {
            using (OpenFileDialog ofd = new OpenFileDialog() // Openfiledialog control to open a dialog window 
            {
                Multiselect = true,
                ValidateNames = true,
                Filter = "WMV|*.wmv |WAV|*.wav|MP3|*.mp3|MKV|*.mkv|MP4|*.mp4|AVI|*.avi|MOV|*.mov"
            })
                /* 
                    If the user selects the "okay" button in the window's dialog box
                    then the for loop is executed 
                */

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;
                    for (int x = 0; x < files.Length; x++) // for loop executes and files are added to listbox
                    {
                        track_list.Items.Add(files[x]);
                    }
                }
        }
    }
}
