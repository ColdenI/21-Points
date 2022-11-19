using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace _21Points
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://akylinandrej.wixsite.com/colden-i");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://akylinandrej.wixsite.com/colden-i/21-points");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://akylinandrej.wixsite.com/colden-i/21-points");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://akylinandrej.wixsite.com/colden-i");
        }
    }
}
