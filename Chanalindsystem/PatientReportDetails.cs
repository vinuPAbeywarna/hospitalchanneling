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
    public partial class PatientReportDetails : Form
    {
        public PatientReportDetails()
        {
            InitializeComponent();
        }

        private void start()
        {
            try
            {

                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Reports WHERE P_ID="+Form1.public_id+";";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                dg.DataSource = dt;
                dg.ReadOnly = true;
               
            }
            catch (Exception ex) { }
        }


        
        private void xuiButton4_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Reports WHERE P_ID= '"+searchbox.Text+"';";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                dg.DataSource = dt;
                dg.ReadOnly = true;

            }
            catch (Exception ex) { }
        }

        private void PatientReportDetails_Load(object sender, EventArgs e)
        {
            if (Form1.public_usertype == "Patient")
            {
                xuiButton2.Visible = false;
                xuiButton3.Visible = false;
                xuiButton1.Visible = false;
            }
            
            start();
        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            start();
        }

        private void dg_Click(object sender, EventArgs e)
        {
            
            try
            {
                int pidx = int.Parse(dg.CurrentRow.Cells[2].Value.ToString());
                rpid.Text = dg.CurrentRow.Cells[1].Value.ToString();

                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Users WHERE ID= '" + pidx + "';";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                DataRow drow = dt.Rows[0];

                pname.Text = drow["User_Name"].ToString();
                tel.Text = drow["Telephone"].ToString();
                pids.Text = dg.CurrentRow.Cells[2].Value.ToString();

                details.Text = dg.CurrentRow.Cells[3].Value.ToString();
                date.Value = DateTime.Parse(dg.CurrentRow.Cells[4].Value.ToString());

                dnames.Text = dg.CurrentRow.Cells[5].Value.ToString();


            }
            catch (Exception ex) { }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO reports(Rep_ID, P_ID, Details, Date, Doc_Name) VALUES ("+Form1.public_id+","+ pids.Text+",'"+details.Text+"','"+date.Value.ToString()+"','"+dnames.Text+"')";
                cmd.ExecuteNonQuery();
                start();

                MessageBox.Show("Record Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch  (Exception ex)
            { MessageBox.Show("Something Went Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
         }

        private void pids_TextChanged(object sender, EventArgs e)
        {
            try {
                int pidx = int.Parse(pids.Text);
                

                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Users WHERE ID= '" + pidx + "' AND (User_Type = 'Patient');";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                DataRow drow = dt.Rows[0];

                pname.Text = drow["User_Name"].ToString();
                tel.Text = drow["Telephone"].ToString();
                

            } catch { MessageBox.Show("Patient ID Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try {
                var delconfirm = MessageBox.Show("Are You Sure You Want To Delete This Record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (delconfirm == DialogResult.Yes)
                {
                    MySqlConnection sqlCon = null;
                    sqlCon = new MySqlConnection(Form1.public_connection);
                    sqlCon.Open();

                    MySqlCommand command;

                    command = new MySqlCommand(@"DELETE FROM Reports WHERE R_ID = " + dg.CurrentRow.Cells[0].Value.ToString() + ";", sqlCon);
                    command.ExecuteNonQuery();
                    start();
                    MessageBox.Show("Delete Successful!");
                }

            } catch {
                MessageBox.Show("Something Went Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection sqlCon = null;
                sqlCon = new MySqlConnection(Form1.public_connection);
                sqlCon.Open();

                MySqlCommand command;

                command = new MySqlCommand("UPDATE reports SET Details='"+ details.Text +"' WHERE R_ID = " + dg.CurrentRow.Cells[0].Value.ToString() + ";", sqlCon);
                command.ExecuteNonQuery();
                start();
                MessageBox.Show("Update Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch { MessageBox.Show("Something Went Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
