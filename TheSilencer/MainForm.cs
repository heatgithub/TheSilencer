using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TheSilencer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // display the name and version as the forms title
            this.Text = "The Silencer - v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += " (" + System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString("yyyy-MM-dd") + ")";

            // force a refresh
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";

            WriteAllProcesses();

            // unselect everything in the textBox
            txtBox.Select(0, 0);
        }

        private void WriteAllProcesses()
        {
            Process[] processlist = Process.GetProcesses();

            string txt = "";
            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    txt += "Process: " + process.ProcessName.ToString() + " (ID: " + process.Id.ToString() + ") Window title: " + process.MainWindowTitle + Environment.NewLine;
                }
            }
            txtBox.Text += txt;

        }

    }
}
