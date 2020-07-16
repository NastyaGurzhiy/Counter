using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace Counter
{
    public partial class MyWindow : Form
    {
        static int count = 0;
        public MyWindow()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAboutProg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My program\nNastya G.\t16.07.20", "About program");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblOutput.Text = (++count).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblOutput.Text = (--count).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblOutput.Text = count.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fBrD1.ShowDialog();
            try
            {
                StreamWriter stream = File.AppendText(fBrD1.SelectedPath + @"\.txt");
                stream.WriteLine(count);
                stream.Close();
                MessageBox.Show("Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed");
            }
            fBrD1.SelectedPath = null;
        }
    }
}
