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
    public partial class ManagerAdd : Form
    {
        public ManagerAdd()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
            conn.Open();
            string query = "";
            query = "INSERT INTO manager (UserName,Password) VALUES('" + textUserName.Text + "','" + textPassword.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }
            else
            {
                MessageBox.Show("Error!!!", "Message");
            }
            conn.Close();
        }
    }
}
