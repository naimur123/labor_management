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
    public partial class laborIn : Form
    {
        public string UserName, Password;
        DateTime currentTime = DateTime.Now;
       
        
            
    public laborIn(string UserName,string Password)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.Password = Password;
           


        }

        private void stop_Click(object sender, EventArgs e)
        {
           
                DateTimePicker timePicker = new DateTimePicker();
                timePicker.Format = DateTimePickerFormat.Custom;
                timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
                timePicker.ShowUpDown = true;

                SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
                conn.Open();
                string query = "";
                query = "Update LaborWork SET StopWork = '" + currentTime + "' WHERE UserName = '" + UserName + "' AND Password='" + Password + "'";
               
                SqlCommand c = new SqlCommand(query, conn);
                int result = c.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("You Working Hour Has Been Stoped ", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string s = timePicker.Text;

                    
                    stop.Visible = false;

                }
                else
                {
                    MessageBox.Show("Error!!!", "Message");
                }
                conn.Close();
            


        }

       /* private void laborIn_Load(object sender, EventArgs e)
        {
            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
            timePicker.ShowUpDown = true;
            if (timePicker.Equals(12))
            {



                start.Visible = false;
                



            }

        }*/

        public void start_Click(object sender, EventArgs e)
        {
            
           
               

                SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
                conn.Open();
                string query = "";

                query = "INSERT INTO LaborWork (UserName,Password,StartWork) VALUES('" + UserName + "','" + Password + "','" + currentTime + "')";

                SqlCommand c = new SqlCommand(query, conn);
                int result = c.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("You have started your work", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                    start.Visible = false;
                stop.Visible = true;

                }
                else
                {
                    MessageBox.Show("Error!!!", "Message");
                }
                conn.Close();
            
            
            
        }
    }
}
