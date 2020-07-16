using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class MyWindow : Form
    {
        public MyWindow()
        {
            InitializeComponent();
        }

        private void etsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
