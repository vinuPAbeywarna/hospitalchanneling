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

namespace hospitalchanneling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string usertype;
            string username;
            string userpassword;

            usertype = comtype.SelectedItem.ToString();
            username = txtname.Text;
            userpassword = txtpw.Text;
            MySqlConnection sqlCon = null;
            string connection;
            connection = "Server =127.0.0.1 ;Database = hospitalchanelingsystem; user =root;SSlmode=none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;


            if (usertype == "Doctor")
            {
                command = new MySqlCommand(@"SELECT* FROM doctor WHERE Name='" + username + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;
                    databaseUserName = reader.GetString(2);
                    databasePassword = reader.GetString(1);

                    if (userpassword == databasePassword)
                    {

                        this.Hide();
                        Form2 ss = new Form2();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Password");
                    }


                }
            }
        }
    }
}
