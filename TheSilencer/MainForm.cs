using System;
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
        }

    }
}
