using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_5_Calculator
{
    public partial class frmQuit : Form
    {
        public frmQuit()
        {
            InitializeComponent();
        }

        private void frmQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmQuit_Load(object sender, EventArgs e)
        {

        }
    }
}
