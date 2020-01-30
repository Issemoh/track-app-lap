using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IblStatus : Form
    {
        public IblStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWhatsStatus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCredits.Text, out double credits))

            {
                if (credits >= 12)
                {
                    lblStatus.Text = "Full time";
                }
                else if (credits >= 6)
                {
                    lblStatus.Text = " Half time";
                }
                else if (credits >= 0)
                {
                    lblStatus.Text = "Less than half time";
                }
                else
                {
                MessageBox.Show("Enter a nunber", "Error");
                }
            }
            else
            {
              MessageBox.Show("Enter a nunber", "Error");
            }
           
        }

        private void IblStatus_Load(object sender, EventArgs e)
        {

        }

        private void trkCredits_Scroll(object sender, EventArgs e)
        {
            int credits = trkCredits.Value

            lblcredits.Text = trkCredits.Value.ToString();

            if (credits >= 12)
            {
                lblStatus.Text = "Half time";
            }
             else if (credits >= 6)
            {
                lblStatus.Text = " Half time";
            }
            else if (credits >= 0)
            {
                lblStatus.Text = "less than half time";
            }
        }
    }
}
