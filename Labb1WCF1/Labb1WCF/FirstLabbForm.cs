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
    public partial class FirstLabbForm : Form
    {
        public FirstLabbForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Labb1Reference.myFirstServiceSoapClient client = new Labb1Reference.myFirstServiceSoapClient();
            label2.Text = client.GetTomorrowsWheater(textBox1.Text);
        }
    }
}
