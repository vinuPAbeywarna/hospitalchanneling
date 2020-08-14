using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chanalindsystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        //private void textBox6_TextChanged(object sender, EventArgs e)
        //{

       // }

        private void btnsign_Click(object sender, EventArgs e)
        {
            
            try{
                string stusertype, stid, stname, stpassword, sttele, stemail;

                stusertype = combotype.Text;
                stid = txtid.Text;
                stname = txtname.Text;
                stpassword = txtpw.Text;
                sttele = txttele.Text;
                stemail = txtemail.Text;

                int doccat = -9669;
                double docprice = -9669;

                if (combotype.SelectedIndex == 1)
                {
                    doccat = catcombo.SelectedIndex;
                    docprice = double.Parse(doccharge.Text);
                }
               

                MySqlConnection sqlCon = null;
                sqlCon = new MySqlConnection(Form1.public_connection);
                sqlCon.Open();

                MySqlCommand command;
                command = new MySqlCommand(@"INSERT INTO Users(ID,User_Name,Password,User_Type,Telephone,Email, Cat_ID, Price) value ('" + int.Parse(stid) + "','" + stname + "','" + stpassword + "','" + stusertype + "','" + sttele + "','" + stemail + "' , "+ doccat + " , " + docprice +");", sqlCon);
                command.ExecuteNonQuery();
                MessageBox.Show("Your Registration Was Successful!");
            }catch(Exception)
            {
                MessageBox.Show("Something went wrong.Please Try Again.");
                
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
            if (Form1.public_usertype != "Admin")
            {
                combotype.SelectedIndex = 3;
                combotype.Enabled = false;

            } else
            {
                combotype.SelectedIndex = 0;
            }
        }

        private void combotype_SelectedIndexChanged(object sender, EventArgs e)

        {
            
            if (combotype.SelectedIndex == 1)
            {
                docs.Visible = true;
                try {
                    MySqlConnection mySqlCon = new MySqlConnection(Form1.public_connection);
                    mySqlCon.Open();

                    MySqlCommand cmd = mySqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Categories;";
                    cmd.ExecuteNonQuery();

                    
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    DataTableReader reader = new DataTableReader(dt);
                    reader.Read();

                    catcombo.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                       // ids.Add((int)row["id"]);
                        catcombo.Items.Add(row["Name"]);
                    }
                } catch { }
            } else
            {
                docs.Visible = false;
            }
        }
    }
}
