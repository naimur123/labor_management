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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
            conn.Open();
            string query = "";
            query = "Select * FROM manager WHERE UserName='" + textUserName.Text + "' and Password='" + textPassword.Text + "' ";
            SqlDataAdapter ss = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            ss.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Successfully LogedIn!!!", "Message");
                ManagerIn i = new ManagerIn();
                this.Hide();
                i.Show();
            }
            else
            {
                MessageBox.Show("Error!!!", "Message");
            }
            conn.Close();

        }
    }
}
