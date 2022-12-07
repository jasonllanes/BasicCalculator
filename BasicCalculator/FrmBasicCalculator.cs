using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssemblyy;


namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if(cbSysmbols.Text == "+")
            {
               float total = BasicComputation.Addition((float)Convert.ToDouble(tbFirst.Text), (float)Convert.ToDouble(tbSecond.Text));
               lblTotal.Text = total.ToString();
            }else if(cbSysmbols.Text == "-")
            {
                float total = BasicComputation.Subtraction((float)Convert.ToDouble(tbFirst.Text), (float)Convert.ToDouble(tbSecond.Text));
                lblTotal.Text = total.ToString();
            }else if(cbSysmbols.Text == "*")
            {
                float total = BasicComputation.Multiplaction((float)Convert.ToDouble(tbFirst.Text), (float)Convert.ToDouble(tbSecond.Text));
                lblTotal.Text = total.ToString();
            }
            else if(cbSysmbols.Text == "/")
            {
                float total = BasicComputation.Division((float)Convert.ToDouble(tbFirst.Text), (float)Convert.ToDouble(tbSecond.Text));
                lblTotal.Text = total.ToString();
            }
        }
    }
}
