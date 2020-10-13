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
    public partial class laborUpdate : Form
    {
        public string UserName, Password;
        public laborUpdate(string UserName,string Password)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.Password = Password;
        }

        private void textContact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textContact.Text))
            {
                e.Cancel = true;
                textContact.Focus();
                errorProvider1.SetError(textContact, "Contact should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textContact, "");
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
       


        private void label5_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            textPassword.Visible = true;
         
        }

        private void back_Click(object sender, EventArgs e)
        {
            laborIn i = new laborIn(UserName, Password);
            i.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (textContact.Text.Length != 11)
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
                                string query = "";
                                query = "Update labor SET Contact = '" + textContact.Text + "',City='" + textCity.Text + "',Email='" + textEmail.Text + "',Password='" + textPassword.Text + "' WHERE UserName = '" + UserName + "' AND Password='" + Password + "'";

                                SqlCommand cmd = new SqlCommand(query, conn);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Successfully Updated!!!Please LogIn Again", "Message");
                                    Labor l = new Labor();
                                    this.Hide();
                                    l.Show();

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
                                query = "Update labor SET Contact = '" + textContact.Text + "',City='" + textCity.Text + "',Email='" + textEmail.Text + "',Password='" + textPassword.Text + "' WHERE UserName = '" + UserName + "' AND Password='" + Password + "'";

                                SqlCommand cmd = new SqlCommand(query, conn);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Successfully Updated!!!Please LogIn Again", "Message");
                                    Labor l = new Labor();
                                    this.Hide();
                                    l.Show();

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
