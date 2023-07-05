using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cms
{
    public partial class recptionist_login : Form
    {
        public recptionist_login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Username or password incorrect Please Check your Fileds  Well username = '" + username.Text + "' ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from receptionist where username = '" + username.Text + "' AND pass = '" + password.Text + "'", con);
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        MessageBox.Show("Login Successfully ", "Welcome " + username.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        new appointment(username.Text).Show();
                        this.Hide();
                        rd.Close();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("username or password incorrect Please Check  Fileds Well !!\nusername = '" + username.Text + "' ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Connection Time out  = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked == true)
            {
                password.PasswordChar = '\0';

            }
            else
            {
                password.PasswordChar = '●';

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Close Program", guna2Button1);

        }

        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Minimize", guna2Button2);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new cms().Show();
            this.Hide();
        }
    }

}
