using System;
using System.Windows.Forms;

namespace TheSilencer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ange namn och version som titel
            this.Text = "The Silencer - v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += " (" + System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString("yyyy-MM-dd") + ")";
        }

    }
}
