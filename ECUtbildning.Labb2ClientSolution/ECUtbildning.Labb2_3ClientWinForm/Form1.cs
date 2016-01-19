using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECUtbildning.Labb2_3ClientWinForm
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
            var birthdate = dateTimePicker1.Value;
            ThousandDaysOldClient client = new ThousandDaysOldClient();
            var result = client.GetNextDateForThousandYearBirthday(birthdate.ToString());
            lblResult.Text = result.Date.ToString();
        }
    }
}
