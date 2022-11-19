using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21Points
{
    public partial class FormatForm : Form
    {
        private bool isSet = false;

        public FormatForm()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SetBackCard(2);
        }

        private void FormatForm_Load(object sender, EventArgs e)
        {

            numericUpDown1.Value = Properties.Settings.Default.rivalSpeed;

            switch (Properties.Settings.Default.DeckCards)
            {
                case 0: radioButton1.Checked = true; break;
                case 1: radioButton2.Checked = true; break;
                case 2: radioButton3.Checked = true; break;
            }

            switch (Properties.Settings.Default.card_back_number)
            {
                case 0: pictureBox1.Image = Properties.Resources.s3; radioButton4.Checked = true; break;
                case 1: pictureBox1.Image = Properties.Resources.s4; radioButton6.Checked = true; break;
                case 2: pictureBox1.Image = Properties.Resources.s5; radioButton5.Checked = true; break;
                case 3: pictureBox1.Image = Properties.Resources.s1; radioButton11.Checked = true; break;
            }

            switch (Properties.Settings.Default.background_number)
            {
                case 0: pictureBox2.Image = Properties.Resources.fon1; radioButton7.Checked = true; break;
                case 1: pictureBox2.Image = Properties.Resources.fon2; radioButton8.Checked = true; break;
                case 2: pictureBox2.Image = Properties.Resources.fon3; radioButton9.Checked = true; break;
                case 3: pictureBox2.Image = Properties.Resources.fon4; radioButton10.Checked = true; break;
                case 4: pictureBox2.Image = Properties.Resources.fon5; radioButton11.Checked = true; break;
                case 5: pictureBox2.Image = Properties.Resources.fon6; radioButton12.Checked = true; break;
            }
        }

        private void SetDeckCards(int i)
        {
            Properties.Settings.Default.DeckCards = i;
            MainForm mainForm = Owner as MainForm;
            mainForm.InitGame();
            Properties.Settings.Default.Save();
        }

        private void SetFon(int i)
        {
            MainForm mainForm = Owner as MainForm;
            Properties.Settings.Default.background_number = i;
            switch (Properties.Settings.Default.background_number)
            {
                case 0: pictureBox2.Image = Properties.Resources.fon1; break;
                case 1: pictureBox2.Image = Properties.Resources.fon2; break;
                case 2: pictureBox2.Image = Properties.Resources.fon3; break;
                case 3: pictureBox2.Image = Properties.Resources.fon4; break;
                case 4: pictureBox2.Image = Properties.Resources.fon5; break;
                case 5: pictureBox2.Image = Properties.Resources.fon6; break;
            }
            Properties.Settings.Default.Save();
            mainForm.Draw_();
        }

        private void SetBackCard(int i)
        {
            MainForm mainForm = Owner as MainForm;
            Properties.Settings.Default.card_back_number = i;
            switch (i)
            {
                case 0: pictureBox1.Image = Properties.Resources.s3; break;
                case 1: pictureBox1.Image = Properties.Resources.s4; break;
                case 2: pictureBox1.Image = Properties.Resources.s5; break;
                case 3: pictureBox1.Image = Properties.Resources.s1; break;
            }
            Properties.Settings.Default.Save();
            mainForm.Draw_();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            isSet = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (isSet)
            {
                Properties.Settings.Default.rivalSpeed = (int)numericUpDown1.Value;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetDeckCards(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetDeckCards(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetDeckCards(2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SetBackCard(0);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SetBackCard(1);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SetFon(0);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            SetFon(1);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            SetFon(2);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            SetFon(3);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            SetFon(4);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            SetFon(5);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            SetBackCard(3);
        }
    }
}
