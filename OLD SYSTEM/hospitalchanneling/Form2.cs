using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalchanneling
{
    
    public partial class Form2 : Form
    {

        int test2=1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int test = Form1.test;
            string utype = Form1.utype;
            if (utype == "doctor")
            {
                button2.Hide();
            } else if (utype == "nurse")
            {
                button1.Hide();
            }
        }
    }
}
