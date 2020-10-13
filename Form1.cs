using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace laborMgt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(adminTxt.Checked)
            {
                MessageBox.Show("Admin Selected");
                Admin a1 = new Admin();
                this.Hide();
                a1.Show();


            }
            if(managerTxt.Checked)
            {
                MessageBox.Show("Manager Selected");
                Manager m1 = new Manager();
                m1.Show();
                this.Hide();
              
            }
            if (laborTxt.Checked)
            {
                MessageBox.Show("Labor Selected");
                Labor l1 = new Labor();
                l1.Show();
                this.Hide();
               
                
            }
        }
    }
}
