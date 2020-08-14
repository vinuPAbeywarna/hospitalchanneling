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
        public static int test = 1;
        public static string utype = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string usertype;
            string username;
            string userpassword;


            username = txtname.Text;
            userpassword = txtpw.Text;
            MySqlConnection sqlCon = null;
            string connection;
            connection = "Server =127.0.0.1 ;Database = hospitalchanelingsystem; user =root;SSlmode=none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;


            
                command = new MySqlCommand(@"SELECT* FROM users WHERE name='" + username + "' AND password='"+ userpassword +"'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;
                    databaseUserName = reader.GetString(1);
                    databasePassword = reader.GetString(2);
                    //MessageBox.Show(reader.GetString(3));
                    

                    if (userpassword == databasePassword)
                    {

                        this.Hide();
                        utype = reader.GetString(3);
                        Form2 ss = new Form2();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Password");
                    }


                
            }
        }

        private void comtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
