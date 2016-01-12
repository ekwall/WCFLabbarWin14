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
    public partial class Labb1_3WinForm : Form
    {
        public Labb1_3WinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Labb1_3Service.Labb1_3ServiceSoapClient client = new Labb1_3Service.Labb1_3ServiceSoapClient();
            label1.Text =  client.AddThreeNumbers(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)).ToString();

        }
    }
}
