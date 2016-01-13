using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labb1WCF.Labb1_5ServiceGetDateByName;

namespace Labb1WCF
{
    public partial class Labb1_5WinForm : Form
    {
        public Labb1_5WinForm()
        {
            InitializeComponent();
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {
            Labb1_5ServiceGetDateByName.Labb1_5ServiceSoapClient client = new Labb1_5ServiceSoapClient();
            var result = client.GetDateOfNamesDay(txtNameSearch.Text);
            txtDate.Text = result;
            //Labb1_5Reff_2_service.Labb1_5ServiceSoapClient client2 = new Labb1_5Reff_2_service.Labb1_5ServiceSoapClient();
            //txtDate.Text = "";

            //var result = client2.GetDatesOfNamesDay(txtNameSearch.Text);
            //txtDate.Text = string.Join(Environment.NewLine, result);



        }
    }
}
