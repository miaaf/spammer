using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace spammer
{
    public partial class Form1 : Form
    {

        bool isOpen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
                timer1.Start();
                bool isOpen = true;

            if (isOpen)
            {
                label1.Text = "Status : Started";
                label1.ForeColor = Color.Green;

            }
            else
            {
                label1.Text = "Status : Closed";
                label1.ForeColor = Color.Red;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            bool isOpen = false;

            if (isOpen)
            {
                label1.Text = "Status : Started";
                label1.ForeColor = Color.Green;

            }
            else
            {
                label1.Text = "Status : Closed";
                label1.ForeColor = Color.Red;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(richTextBox1.Text);
            SendKeys.Send("{ENTER}");
        }
    }
}
