using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chanalindsystem
{
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }
        
        private void dtgridsupdate()
        {
            try
            {
                MySqlConnection connect = new MySqlConnection(Form1.public_connection);
                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();
                string query = "SELECT * FROM Users;";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void UserDetails_Load(object sender, EventArgs e)
        {
            if (Form1.public_usertype != "Admin")
            {
                btnedit.Visible = false;
                txtidserch.Visible = false;
                btnclear.Visible = false;
                btnsearch.Visible = false;

                //btnedit.Visible = false;
                btndelete.Visible = false;
                label7.Visible = false;
                btnadd.Visible = false;

                
                try
                {
                    MySqlConnection connect = new MySqlConnection(Form1.public_connection);
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    string query = "SELECT * FROM Users Where id = " + Form1.public_id + ";";
                    cmd.CommandText = query;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgrid.DataSource = dt;
                    dtgrid.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                MySqlConnection connect = new MySqlConnection(Form1.public_connection);
                connect.Open();
                try
                {
                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Users";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgrid.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dtgrid_Click(object sender, EventArgs e)
        {
            combotype.SelectedItem = dtgrid.CurrentRow.Cells[3].Value;
            txtid.Text = dtgrid.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dtgrid.CurrentRow.Cells[1].Value.ToString();
            txtpw.Text = dtgrid.CurrentRow.Cells[2].Value.ToString();
            txttele.Text = dtgrid.CurrentRow.Cells[4].Value.ToString();
            txtemail.Text = dtgrid.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection(Form1.public_connection);
                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();
                string query = "SELECT * FROM Users Where id = " + int.Parse(txtidserch.Text) + ";";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dtgrid.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dtgridsupdate();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = null;
            sqlCon = new MySqlConnection(Form1.public_connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE Users SET ID = " + txtid.Text +", User_Name = '" + txtname.Text + "', Password = '"+ txtpw.Text + "' , User_Type= '" + combotype.SelectedItem + "', Telephone = "+txttele.Text +", Email = '"+ txtemail.Text+ "' WHERE id = " +txtid.Text + ";", sqlCon);
            command.ExecuteNonQuery();
            dtgridsupdate();
            MessageBox.Show("Update Successful!");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            

            var delconfirm = MessageBox.Show("Are You Sure You Want To Delete This User?", "Confirm Delete",MessageBoxButtons.YesNo);
            if (delconfirm == DialogResult.Yes)
            {
                MySqlConnection sqlCon = null;
                sqlCon = new MySqlConnection(Form1.public_connection);
                sqlCon.Open();

                MySqlCommand command;

                command = new MySqlCommand(@"DELETE FROM Users WHERE id = " + txtid.Text + ";", sqlCon);
                command.ExecuteNonQuery();
                dtgridsupdate();
                MessageBox.Show("Delete Successful!");
            }            
            
        }

        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrid_DataSourceChanged(object sender, EventArgs e)
        {
            dtgrid.Columns.Remove("Price");
            dtgrid.Columns.Remove("Cat_ID");
        }
    }
}
