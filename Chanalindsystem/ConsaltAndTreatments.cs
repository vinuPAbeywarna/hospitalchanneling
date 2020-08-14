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
    public partial class ConsaltAndTreatments : Form
    {
        public ConsaltAndTreatments()
        {
            InitializeComponent();
        }

        private void btnChannl_Click(object sender, EventArgs e)
        {
            
        }

        private void btntreatment_Click(object sender, EventArgs e)
        {
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage aa = new HomePage();
            aa.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //drop down
        DataTable cats = new DataTable();
        DataTable docs = new DataTable();

        private void start()//catogory clear
        {
            cats.Clear();
            editcatsname.Text = "";
            editcatscharge.Text = "";
            //editcats.SelectedItem = "";

            editcats.Items.Clear();
            datex.MinDate = DateTime.Today;

            if (Form1.public_usertype == "Admin")
            {
                groupBox1.Enabled = false; ;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }

            try
            {
                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Categories;";
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(cats);

                category.Items.Clear();
                foreach (DataRow row in cats.Rows)
                {
                    category.Items.Add(row["Name"]);
                    editcats.Items.Add(row["Name"]);
                }
            }
            catch { }
        }
        private void ConsaltAndTreatments_Load(object sender, EventArgs e)
        {
            if(Form1.public_usertype != " Patient")
            {
                btnconfirm.Visible = false;
            }
            start();
        }



        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            dcomb.Items.Clear();
            dcomb.Text = "";
            try
            {
                DataRow selectedrow = cats.Rows[category.SelectedIndex];
                if (int.Parse(selectedrow["Has_Docs"].ToString()) == 0)
                {
                    dcomb.Items.Clear();
                    dcomb.Text = "";
                    dcomb.Enabled = false;

                    dcharge.Text = "0";
                    DataRow selectedrowcat = cats.Rows[category.SelectedIndex];
                    ccharge.Text = selectedrowcat["Price"].ToString();

                    total.Text = (double.Parse(dcharge.Text) + double.Parse(ccharge.Text)).ToString();

                }
                else {
                    dcomb.Enabled = true;
                    MySqlConnection mySqlCon2 = new MySqlConnection(Form1.public_connection);
                    mySqlCon2.Open();

                    MySqlCommand cmd2 = mySqlCon2.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "SELECT * FROM Users WHERE Cat_ID=" + category.SelectedIndex + ";";
                    cmd2.ExecuteNonQuery();

                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                    docs.Clear();
                    da2.Fill(docs);

                    dcomb.Items.Clear();
                    dcomb.Text = "";

                    foreach (DataRow row2 in docs.Rows)
                    {
                        dcomb.Items.Add(row2["User_Name"]);
                    }


                }


            }
            catch { }
        }

        private void dcomb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedrowcat = cats.Rows[category.SelectedIndex];
            DataRow selectedrowdoc = docs.Rows[dcomb.SelectedIndex];

            dcharge.Text = selectedrowdoc["Price"].ToString();
            ccharge.Text = selectedrowcat["Price"].ToString();

            total.Text = (double.Parse(dcharge.Text) + double.Parse(ccharge.Text)).ToString();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            var conf = MessageBox.Show("Press Yes to Confirm", "Confirm", MessageBoxButtons.YesNo);

            if (conf == DialogResult.Yes)
            {
                try
                {
                    string docname = "No Doctor Required!";
                    if (dcomb.Enabled == true)
                    {
                        docname = dcomb.SelectedItem.ToString();
                    }
                    MySqlConnection mySqlCon2 = new MySqlConnection(Form1.public_connection);
                    mySqlCon2.Open();

                    MySqlCommand cmd2 = mySqlCon2.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "INSERT INTO channelings (P_ID, Doc_Name, Cat_Name, Doc_Charge, Cat_Charge, Details, Date, Paid) VALUES (" + Form1.public_id + ", '" + docname + "', '" + category.SelectedItem.ToString() + "', " + double.Parse(dcharge.Text) + " , " + double.Parse(ccharge.Text) + " , '" + detailsx.Text + "', '" + datex.Value.ToString() + "', 'NO');";
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Channeling Confirmed!", "Confirmed");

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            try {
                int newcatt = 1;
               
                if (newcatistreatment.Checked)
                {
                    newcatt = 0;
                }

                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO categories(Name, Price, Has_Docs) VALUES ('" + newcatname.Text + "' ," + newcatcharge.Text + "," + newcatt + ");";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                start();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void editcats_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                DataRow selectedrowcat = cats.Rows[editcats.SelectedIndex];

                editcatsname.Text = selectedrowcat["Name"].ToString();
                editcatscharge.Text = selectedrowcat["Price"].ToString();

                if (selectedrowcat["Has_Docs"].ToString() == "0")
                {
                    editcatstreatment.Checked = true;
                }
                else
                {
                    editcatstreatment.Checked = false;
                }
            } catch {

                MessageBox.Show("Something Went Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int newcatt = 1;
                DataRow selectedrow = cats.Rows[editcats.SelectedIndex];
                string selectedCatID = selectedrow["Cat_ID"].ToString();
                if (editcatstreatment.Checked)
                {
                    newcatt = 0;
                }

                MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                mySqlCon.Open();

                MySqlCommand cmd = mySqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Categories SET Name = '" + editcatsname.Text + "' , Price = " + editcatscharge.Text + ", Has_Docs = " + newcatt + " WHERE Cat_ID="+selectedCatID+";";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Updated!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
            }
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            DataRow selectedrowcat = cats.Rows[editcats.SelectedIndex];
            int idcat = int.Parse(selectedrowcat["Cat_ID"].ToString());

            var confirm = MessageBox.Show("Are You Sure You Want to Delete this Category?", "Confiem!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                    mySqlCon.Open();

                    MySqlCommand cmd = mySqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Categories WHERE Cat_ID = " + idcat + ";";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Something Went Wrong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
