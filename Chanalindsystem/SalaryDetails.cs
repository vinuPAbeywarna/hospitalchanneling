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
    public partial class SalaryDetails : Form
    {
        public SalaryDetails()
        {
            InitializeComponent();
        }

        private void dtgridupdate()
        {
            if (Form1.public_usertype != "Admin")
            {
                label9.Visible = false;
                search.Visible = false;
                btnsearch.Visible = false;

                finderbtn.Visible = false;
                idfinder.Enabled = false;

                resetbtn.Visible = false;
                btnupdate.Visible = false;
                try
                {
                    MySqlConnection connect = new MySqlConnection(Form1.public_connection);
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    string query = "SELECT * FROM Salary Where id = " + Form1.public_id + ";";
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
                    cmd.CommandText = "SELECT * FROM Salary";
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

        private void filludate(int uid)
        {
            MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
            mySqlCon.Open();

            MySqlCommand cmd = mySqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Users WHERE id = " + uid.ToString() + " AND ( NOT User_Type = 'Patient' );";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataTableReader reader = new DataTableReader(dt);
            reader.Read();

            name.Text = reader.GetString(1);
            type.Text = reader.GetString(3);

        }

        private void SalaryDetails_Load(object sender, EventArgs e)
        {
            dtgridupdate();

            if (Form1.public_usertype != "Admin")
            {
                xuiButton1.Visible = false;
                xuiButton2.Visible = false;
            }
        }

        private void dtgrid_Click(object sender, EventArgs e)
        {
            try {
                idfinder.Text = dtgrid.CurrentRow.Cells[0].Value.ToString();
                basic.Text = dtgrid.CurrentRow.Cells[1].Value.ToString();
                ot.Text = dtgrid.CurrentRow.Cells[2].Value.ToString();
                bonus.Text = dtgrid.CurrentRow.Cells[3].Value.ToString();
                charges.Text = dtgrid.CurrentRow.Cells[4].Value.ToString();

                final.Text = (int.Parse(basic.Text) + int.Parse(ot.Text) + int.Parse(bonus.Text) - int.Parse(charges.Text)).ToString();
                filludate(int.Parse(dtgrid.CurrentRow.Cells[0].Value.ToString()));
            } catch { }

        }

        private void finderbtn_Click(object sender, EventArgs e)
        {
            try
            {
                filludate(int.Parse(idfinder.Text));
            }
            catch
            {
                MessageBox.Show("User Not Found!", "Warning!");
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Salary (id, basic, ot, bonus, charges ) VALUES (" + idfinder.Text + "," + basic.Text + "," + ot.Text + "," + bonus.Text + "," + charges.Text + ");";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added!", "Success!");
                dtgridupdate();

            }
            catch
            {
                MessageBox.Show("Something Went Wrong! Please Try Again!", "Error");
            }
        }


        private void resetbtn_Click(object sender, EventArgs e)
        {
            dtgridupdate();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(Form1.public_connection);
            connect.Open();
            try
            {
                MySqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "SELECT * FROM Users WHERE id=" + search.Text + " AND (NOT User_Type= 'Patient');";
                MySqlDataAdapter dausers = new MySqlDataAdapter(cmd);
                DataTable dtusers = new DataTable();
                dausers.Fill(dtusers);
                DataTableReader dtreader = new DataTableReader(dtusers);
                dtreader.Read();

                if (dtusers.Rows.Count > 0)
                {
                    cmd.CommandText = "SELECT * FROM Salary WHERE id=" + search.Text + ";";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgrid.DataSource = dt;
                }
                else {
                    MessageBox.Show("No Users Found!", "Warnning!");
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = null;
            sqlCon = new MySqlConnection(Form1.public_connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE Salary SET Basic = " + basic.Text + ", OT = " + ot.Text + " , Bonus= " + bonus.Text + ", Charges = " + charges.Text + " WHERE id = " + idfinder.Text + ";", sqlCon);
            command.ExecuteNonQuery();
            dtgridupdate();
            MessageBox.Show("Update Successful!");
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var delconfirm = MessageBox.Show("Are You Sure You Want To Delete This Record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (delconfirm == DialogResult.Yes)
            {
                MySqlConnection sqlCon = null;
                sqlCon = new MySqlConnection(Form1.public_connection);
                sqlCon.Open();

                MySqlCommand command;

                command = new MySqlCommand(@"DELETE FROM Salary WHERE id = " + idfinder.Text + ";", sqlCon);
                command.ExecuteNonQuery();
                dtgridupdate();
                MessageBox.Show("Delete Successful!");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       // private void groupBox1_Enter(object sender, EventArgs e)
       // {

        //}

        // private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // {

        //}

        // private void final_TextChanged(object sender, EventArgs e)
        //{

        // }
    }
}
