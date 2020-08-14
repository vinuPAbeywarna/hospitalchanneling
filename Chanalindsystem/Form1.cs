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
    public partial class Form1 : Form
    {
        public static string public_username = "";
        public static string public_connection = "Server =127.0.0.1 ;Database= channeling_system ; user =root;";
        public static int public_id = 0;
        public static string public_usertype = "";


        MySqlConnection con = new MySqlConnection(public_connection);
        int i;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Users where user_name='" + txtname.Text + "' and password='" + txtpw.Text + "'";
            cmd.ExecuteNonQuery();
            
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            

            
            
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i == 0)
            {
                MessageBox.Show("You have enterd Invalid User Name or Password","Wrong UserName/Password!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                DataTableReader reader = new DataTableReader(dt);
                reader.Read();
                public_id = int.Parse(reader.GetValue(0).ToString());
                public_username = reader.GetString(1);
                public_usertype = reader.GetString(3);

                this.Hide();
                HomePage aa = new HomePage();
                aa.Show();
            }

            con.Close();


        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            Registration bb = new Registration();
            bb.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
