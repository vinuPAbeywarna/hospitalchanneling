using MySql.Data.MySqlClient;
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
    public partial class PaymentsDetails : Form
    {
        public PaymentsDetails()
        {
            InitializeComponent();
        }

        private void start()
        {
            if (Form1.public_usertype == "Patient")
            {
                try
                {
                    
                    MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                    mySqlCon.Open();

                    MySqlCommand cmd = mySqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Channelings WHERE P_ID = " + Form1.public_id + ";";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    dg1.DataSource = dt;
                    dg1.ReadOnly = true;

                }
                catch (Exception ex) { }
            }
            else
            {
                try
                {
                    MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                    mySqlCon.Open();

                    MySqlCommand cmd = mySqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Channelings;";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    dg1.DataSource = dt;
                    dg1.ReadOnly = true;

                }
                catch (Exception ex) { }
            }
        }

        private void dgiller()
        {
            try
            {
                cid.Text = dg1.CurrentRow.Cells[3].Value.ToString();

                int pid = int.Parse(dg1.CurrentRow.Cells[1].Value.ToString());

                MySqlConnection mySqlConx = new MySqlConnection(Form1.public_connection);
                mySqlConx.Open();

                MySqlCommand cmdx = mySqlConx.CreateCommand();
                cmdx.CommandType = CommandType.Text;
                cmdx.CommandText = "SELECT * FROM Users WHERE ID = " + pid + ";";
                cmdx.ExecuteNonQuery();

                DataTable dtx = new DataTable();
                MySqlDataAdapter dax = new MySqlDataAdapter(cmdx);
                dax.Fill(dtx);

                DataRow dataRow = dtx.Rows[0];

                pname.Text = dataRow["User_Name"].ToString();
                ptel.Text = dataRow["Telephone"].ToString();

                docifany.Text = dg1.CurrentRow.Cells[2].Value.ToString();

                total.Text = (double.Parse(dg1.CurrentRow.Cells[4].Value.ToString()) + double.Parse(dg1.CurrentRow.Cells[5].Value.ToString())).ToString() + "LKR";
                date.Text = dg1.CurrentRow.Cells[7].Value.ToString().Split(null)[0].ToString();

                string paided = dg1.CurrentRow.Cells[8].Value.ToString();
                paidx.Text = paided;
                if (paided == "NO")
                {
                    paidx.ForeColor = Color.Red;
                    marker.Enabled = true;
                }
                else
                {
                    paidx.ForeColor = Color.Green;

                    marker.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Something Went Wrong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            try
            {


                var msgconf = MessageBox.Show("Are You Sure?", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (msgconf == DialogResult.Yes)
                {
                    MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                    mySqlCon.Open();

                    MySqlCommand cmd = mySqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Channelings SET Paid = 'YES' WHERE C_ID ='" + dg1.CurrentRow.Cells[0].Value.ToString() + "';";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    start();
                    dgiller();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show(ex.Message);
            }
        }

        private void PaymentsDetails_Load(object sender, EventArgs e)
        {
            if (Form1.public_usertype == "Patient")
            {
                marker.Visible = false;
            }
            start();
        }

        private void dg1_Click(object sender, EventArgs e)
        {

            dgiller();
            

        }

        private void clearer_Click(object sender, EventArgs e)
        {
            start();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Channelings WHERE C_ID = " + serachbox.Text + ";";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                dg1.DataSource = dt;
                dg1.ReadOnly = true;

            }
            catch (Exception ex) { MessageBox.Show("Something Went Wrong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

       // private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       // {

        //}

        // private void docifany_TextChanged(object sender, EventArgs e)
        // {

        //}
    }
}
