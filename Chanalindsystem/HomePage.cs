using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chanalindsystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            UserDetails aa = new UserDetails();
            aa.Show();
        }

        private void btnchannel_Click(object sender, EventArgs e)
        {
            
            ConsaltAndTreatments aa = new ConsaltAndTreatments();
            aa.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

            SalaryDetails aa = new SalaryDetails();
            aa.Show();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            
            PaymentsDetails aa = new PaymentsDetails();
            aa.Show();
        }

        private void btnpatientrepo_Click(object sender, EventArgs e)
        {
            
            PatientReportDetails aa = new PatientReportDetails();
            aa.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (Form1.public_usertype == "Patient")
            {
               // pictureBox3.Visible = false;
                //btnpatientrepo.Visible = false;
                pictureBox6.Visible = false;
                btnSalary.Visible = false;
            }

            if (Form1.public_usertype == "Doctor")
            {
                btnchannel.Visible = false;
                pictureBox5.Visible = false;
            }

            if (Form1.public_usertype == "Nurse")
            {
                btnchannel.Visible = false;
                pictureBox5.Visible = false;
            }
        }
    }
}
