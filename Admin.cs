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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            ManagerAdd a = new ManagerAdd();
            this.Hide();
            a.Show();
        }
    }
}
