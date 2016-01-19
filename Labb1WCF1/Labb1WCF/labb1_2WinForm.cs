using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb1WCF
{
    public partial class labb1_2WinForm : Form
    {
        public labb1_2WinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int numberOne;
            Int32.TryParse(textBox1.Text, out numberOne);
            int numberTwo;
            Int32.TryParse(textBox2.Text, out numberTwo);
            ServiceReference1.Labb1_ServiceSoapClient client = new ServiceReference1.Labb1_ServiceSoapClient();
            var result = client.AddTwoNumbers(numberOne, numberTwo);
            label2.Text = result.ToString();
        }
    }
}
