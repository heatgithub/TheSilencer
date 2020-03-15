using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TheSilencer
{
    public partial class MainForm : Form
    {
        enum MusicProgramActivity
        {
            NotPlaying,
            Playing,
            Advertisement,
            Unknown
        }


        /// <summary>
        /// The Main Form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// While the main form loads
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // set the name as the forms title
            this.Text = "The Silencer";

            // display the name and version
            labelVersion.Text = "The Silencer - v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            labelVersion.Text += " (" + System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString("yyyy-MM-dd") + ")";

            // enter default values
            textBoxMusicProgram.Text = "Visual Studio".Substring(7, 1) + '\u0070'.ToString() + 'o'.ToString() + ((char)(232 / 2)).ToString() + "i" + ((char)102).ToString() + ((char)('$' + 'U')).ToString();
            textBoxDelay.Text = "500";

            // force a refresh
            //btnRefresh_Click(sender, e);
        }
        

        /// <summary>
        /// Clicking the Start button
        /// </summary>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            string musicProgramName = textBoxMusicProgram.Text.Trim();
            string musicProgramWindowTitle = GetWindowTitleFromProcessByName(musicProgramName);
            int musicProgramId = GetIdFromProcessByName(musicProgramName);

            // show info about the music program
            DisplayMusicProgramInfo(musicProgramId, musicProgramName);

            // start the timer
            textBoxMusicProgram.Enabled = false;
            textBoxDelay.Enabled = false;
            TheTimer.Interval = ToInteger(textBoxDelay.Text.Trim());
            TheTimer.Start();
        }


        /// <summary>
        /// Clicking the Stop button
        /// </summary>
        private void Stop_Click(object sender, EventArgs e)
        {
            // stop the timer
            textBoxMusicProgram.Enabled = true;
            textBoxDelay.Enabled = true;
            TheTimer.Stop();
        }


        /// <summary>
        /// Display some info in the txtBox about the current music program entered
        /// </summary>
        private void DisplayMusicProgramInfo(int musPrgId, string musPrgName)
        {
            txtBoxInfo.Text = "";

            // if music program is found
            if (musPrgId != -1)
            {
                txtBoxInfo.Text = "Music program: " + musPrgName;
                txtBoxInfo.Text += Environment.NewLine;
                txtBoxInfo.Text += "Process id: " + musPrgId.ToString();
                txtBoxInfo.Text += Environment.NewLine;
            }
            else
            {
                txtBoxInfo.Text = "Music program not found!";
            }

            // unselect everything in the textBox
            txtBoxInfo.Select(0, 0);
        }


        /// <summary>
        /// The timer checks for advertisment from the music program
        /// </summary>
        private void TheTimer_Tick(object sender, EventArgs e)
        {
            string musicProgramName = textBoxMusicProgram.Text.Trim();
            string musicProgramWindowTitle = GetWindowTitleFromProcessByName(musicProgramName);
            int musicProgramId = GetIdFromProcessByName(musicProgramName);
            MusicProgramActivity activity = WhatIsMusicProgramDoing(musicProgramWindowTitle, musicProgramName);

            DisplayMusicProgramInfo(musicProgramId, musicProgramName);
            if (activity == MusicProgramActivity.NotPlaying) { txtBoxInfo.Text += "Music program is paused"; }
            if (activity == MusicProgramActivity.Playing) { txtBoxInfo.Text += "Now playing: " + musicProgramWindowTitle; }
            if (activity == MusicProgramActivity.Advertisement) { txtBoxInfo.Text += "Advertisement is playing"; }
            if (activity == MusicProgramActivity.Unknown) { txtBoxInfo.Text += "Unknown activity!"; }
        }


        /// <summary>
        /// Gets the window title for the specified process name
        /// </summary>
        /// <param name="processName">Name of the process as string</param>
        /// <returns>Window title as string</returns>
        private string GetWindowTitleFromProcessByName(string processName)
        {
            // search for the process by name
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                if (process.MainWindowTitle.Length > 0)
                {
                    return process.MainWindowTitle;
                }
            }

            return "";
        }


        /// <summary>
        /// Gets the process id from the specified process name
        /// </summary>
        /// <param name="processName">Name of the process as string</param>
        /// <returns>Process id as integer</returns>
        private int GetIdFromProcessByName(string processName)
        {
            // search for the process by name
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                if (process.MainWindowTitle.Length > 0)
                {
                    return process.Id;
                }
            }

            return -1;
        }


        /// <summary>
        /// Guesses what the music program is doing based on the window title
        /// </summary>
        /// <param name="windowTitle">Music program window title</param>
        /// <returns>MusicProgramActivity enum: NonPlaying, Playing, Advertisement, Unknown</returns>
        private MusicProgramActivity WhatIsMusicProgramDoing(string windowTitle, string musicProgramName)
        {
            if (windowTitle.ToLower().Contains(musicProgramName.ToLower())) { return MusicProgramActivity.NotPlaying; }
            if (windowTitle.ToLower().Contains(" - ")) { return MusicProgramActivity.Playing; }
            if (windowTitle.ToLower().Contains("advertisement")) { return MusicProgramActivity.Advertisement; }
            
            return MusicProgramActivity.Unknown;
        }


        /// <summary>
        /// Converts the string to an integer
        /// </summary>
        /// <param name="value">The string to convert</param>
        /// <returns>The integer value if success, otherwise zero</returns>
        private int ToInteger(string value)
        {
            try
            {
                return int.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }



    }
}
