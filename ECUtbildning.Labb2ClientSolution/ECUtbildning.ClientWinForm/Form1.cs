using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECUtbildning.ClientWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            CalculateBMIClient client = new CalculateBMIClient();

            string height = txtHeight.Text;
            string weight = txtWeight.Text;

            double convertedHeight = double.Parse(height);
            double convertedWeight = double.Parse(weight);

            var result = client.CalcBMI(convertedWeight, convertedHeight);
            lblResult.Text = result.ToString();
            
        }
    }
}
