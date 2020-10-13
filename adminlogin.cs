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
    
    public partial class adminlogin : Form
    {
       
         public adminlogin()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
   


            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
            conn.Open();
            string query = "";
            query = "Select * FROM admin WHERE UserName='" + textUserName.Text + "' and Password='" + textPassword.Text + "' ";
            SqlDataAdapter ss = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            ss.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Successfully LoggedIn!!!", "Message");
                Admin a1 = new Admin();
                this.Hide();
                a1.Show();

            }
            else
            {
                MessageBox.Show("Error!!!", "Message");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
