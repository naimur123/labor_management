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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (textContact.Text.Length != 11)
                {

                    MessageBox.Show("Contact formation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    int x = 0;
                    string s = textAge.Text;
                    x = Convert.ToInt32(s);
                    if (x < 18)
                    {

                        MessageBox.Show("Age must be 18+", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=labormgt;Integrated Security=true");
                        conn.Open();
                        string query = "";
                        query = "INSERT INTO labor (Name,UserName,Contact,Age,Password) VALUES('" + textName.Text + "','" + textUserName.Text + "', '" + textContact.Text + "', '" + textAge.Text + "','" + textPassword.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Successfully Signed,Please LogIn", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Labor l = new Labor();
                            this.Hide();
                            l.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error!!!", "Message");
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

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, "");
            }
        }

        private void textUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textUserName.Text))
            {
                e.Cancel = true;
                textUserName.Focus();
                errorProvider.SetError(textUserName, "UserName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textUserName, "");
            }

        }
        private void textContact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textContact.Text))
            {
                e.Cancel = true;
                textContact.Focus();
                errorProvider.SetError(textContact, "Contact should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textContact, "");
            }
        }
        private void textAge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textAge.Text))
            {
                e.Cancel = true;
                textAge.Focus();
                errorProvider.SetError(textAge, "Age should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textAge, "");



            }

        }
        private void textPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                e.Cancel = true;
                textPassword.Focus();
                errorProvider.SetError(textPassword, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textPassword, "");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Labor l = new Labor();
            this.Hide();
            l.Show();
        }
    }
}
