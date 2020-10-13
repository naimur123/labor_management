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
    public partial class Labor : Form
    {
        public Labor()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            SignIn s = new SignIn();
            this.Hide();
            s.Show();

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
            conn.Open();
            string query = "";
            query = "Select * FROM labor WHERE UserName='" + textUserName.Text + "' and Password='" + textPassword.Text + "' ";
            SqlDataAdapter ss = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            ss.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Successfully LogedIn!!!", "Message");
                string Username = textUserName.Text;
                string Password = textPassword.Text;
                laborIn i = new laborIn(Username,Password);
                this.Hide();
                i.Show();
            }
            else
            {
                MessageBox.Show("Error!!!", "Message");
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textPassword.UseSystemPasswordChar = false;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
