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
    public partial class managerUpdate : Form
    {
        public string UserName, Password;
        public managerUpdate(string UserName, string Password)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.Password = Password;
        }

        private void textFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFirstName.Text))
            {
                e.Cancel = true;
                textFirstName.Focus();
                errorProvider1.SetError(textFirstName, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textFirstName, "");
            }
        }

        private void textLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textLastName.Text))
            {
                e.Cancel = true;
                textLastName.Focus();
                errorProvider1.SetError(textLastName, "Last Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textLastName, "");
            }
        }

        private void textContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textContactNo.Text))
            {
                e.Cancel = true;
                textContactNo.Focus();
                errorProvider1.SetError(textContactNo, "Contact should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textContactNo, "");
            }
        }

      
        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                e.Cancel = true;
                textEmail.Focus();
                errorProvider1.SetError(textEmail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textEmail, "");
            }
        }

        private void textCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCity.Text))
            {
                e.Cancel = true;
                textCity.Focus();
                errorProvider1.SetError(textCity, "City should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textCity, "");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            textPassword.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            ManagerIn i = new ManagerIn(UserName, Password);
            i.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (textContactNo.Text.Length != 11)
                {

                    MessageBox.Show("Contact formation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                    if (textEmail.Text.Length > 0)

                    {

                        if (!rEMail.IsMatch(textEmail.Text))

                        {

                            MessageBox.Show("E-Mail Formation Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(textPassword.Text))
                            {

                                textPassword.Text = Password;
                                SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
                                conn.Open();
                                string query = "Update manager SET FirstName = '" + textFirstName.Text + "', LastName = '" + textLastName.Text + "', ContactNo = '" + textContactNo.Text + "', DOB = '" + textDOB.Text + "', Email = '" + textEmail.Text + "', City = '" + textCity.Text + "',Password='"+textPassword.Text+"' WHERE UserName = '" + UserName + "' AND Password = '" + Password + "'";


                                SqlCommand cmd = new SqlCommand(query, conn);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Successfully Updated!!!Please LogIn Again", "Message");
                                    Manager m = new Manager();
                                    m.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("error!!!", "Message");
                                }
                                conn.Close();
                            }
                            else
                            {

                                SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
                                conn.Open();
                                string query = "";
                                query = "Update manager SET FirstName = '" + textFirstName.Text + "',LastName='" + textLastName.Text + "',ContactNo='" + textContactNo.Text + "',DOB='" + textDOB.Text + "',Email='" + textEmail.Text + "',City='" + textCity.Text + "',Password='"+textPassword.Text+"' WHERE UserName = '" + UserName + "' AND Password='" + Password + "'";

                                SqlCommand cmd = new SqlCommand(query, conn);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Successfully Updated!!!Please LogIn Again", "Message");
                                    Manager m = new Manager();
                                    m.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("error!!!", "Message");
                                }
                                conn.Close();
                            }

                        }

                    }


                    else
                    {
                        MessageBox.Show("Information Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
    

