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
    /// <summary>
    /// Task 1.5 - 1.8 & IS 1.10
    /// This is a simple calculator program which can complete 
    /// simple mathematical problems. 
    /// Author: Shan Ahmed
    /// </summary>
    public partial class frmCalc : Form
    {
        double n1, n2, answer;

        private void btnSub_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SandyBrown;
            n1 = Convert.ToDouble(txtFirstNum.Text);
            n2 = Convert.ToDouble(txtSecNum.Text);
            answer = n1 - n2;
            lblResult.Text = answer.ToString();
            pbxMult.Hide();
            pbxPlus.Hide();
            pbxDivide.Hide();
            pbxMinus.Show();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleVioletRed;
            n1 = Convert.ToDouble(txtFirstNum.Text);
            n2 = Convert.ToDouble(txtSecNum.Text);
            answer = n1 * n2;
            lblResult.Text = answer.ToString();
            pbxPlus.Hide();
            pbxMinus.Hide();
            pbxDivide.Hide();
            pbxMult.Show();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
            n1 = Convert.ToDouble(txtFirstNum.Text);
            n2 = Convert.ToDouble(txtSecNum.Text);
            if(n1 == 0 || n2 == 0)
            {
                lblResult.Text = "You should NOT divide by ZERO!";
            }
            else
            {
                answer = n1 / n2;
                lblResult.Text = answer.ToString();
            }
            pbxDivide.Show();
            pbxPlus.Hide();
            pbxMinus.Hide();
            pbxPlus.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            frmSplash SScreen = new frmSplash();
            SScreen.ShowDialog();
        }

        private void frmCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmQuit QScreen = new frmQuit();
            QScreen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
            n1 = Convert.ToDouble(txtFirstNum.Text);
            n2 = Convert.ToDouble(txtSecNum.Text);
            answer = Math.Pow(n1, n2);
            lblResult.Text = answer.ToString();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LawnGreen;
            n1 = Convert.ToDouble(txtFirstNum.Text);
            n2 = Convert.ToDouble(txtSecNum.Text);
            answer = (n1 + n2)/2;
            lblResult.Text = answer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            txtFirstNum.Text = " ";
            txtSecNum.Text = " ";
            lblResult.Text = " ";
            pbxDivide.Show();
            pbxMult.Show();
            pbxPlus.Show();
            pbxMinus.Show();
        }

        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RoyalBlue;
            n1 = Convert.ToDouble(txtFirstNum.Text);
            n2 = Convert.ToDouble(txtSecNum.Text);
            answer = n1 + n2;
            lblResult.Text = answer.ToString();
            pbxMult.Hide();
            pbxMinus.Hide();
            pbxDivide.Hide();
            pbxPlus.Show();
        }
    }
}
