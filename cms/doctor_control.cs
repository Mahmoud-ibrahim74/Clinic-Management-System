using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class doctor_control : Form
    {
        public doctor_control()
        {
            InitializeComponent();
            gender.SelectedIndex = 0;
            clock.SelectedIndex = 0;
            clock_end.SelectedIndex = 0;

        }
        private void reset()
        {
            id.Text = "";
            name.Text = "";
            age.Text = "";
            gender.SelectedIndex = 0;
            clock.SelectedIndex = 0;
            clock_end.SelectedIndex = 0;
            email.Text = "";
            days.Text = "";
            phone.Text = "";
            address.Text = "";
            username.Text = "";
            password.Text = "";
            salary.Text = "";


        }

        private void doctor_control_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void back_Click(object sender, EventArgs e)
        {
            new admin_control().Show();
            this.Hide();
        }

    
        private void button1_Click_2(object sender, EventArgs e)
        {
            reset();
        }

        private void doctor_control_Load(object sender, System.EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.tm.Enabled = true;
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            new admin_control().Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            if (slideMenu.Width == 85)
            {
                slideMenu.Visible = false;
                slideMenu.Width = 220;
                panelAnimator.ShowSync(slideMenu);
                logo.Visible = false;
                logoAnimator.ShowSync(logo2);

            }
            else
            {
                slideMenu.Visible = false;
                logo2.Visible = false;
                slideMenu.Width = 85;
                panelAnimator.ShowSync(slideMenu);
                logoAnimator.ShowSync(logo);
                logoAnimator.Hide(logo2);
            }
        }


        private void show_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.Trim()) && string.IsNullOrEmpty(id.Text.Trim()))
            {
                epName.SetError(username, "Please Fill out  \"Username\"   to Display Doctor  !!");
            }
            else
            {
                try
                {
                    String sqlStmt = "SELECT id, Full_Name, age, gender, phone, email, address, salary, days, start_time, end_time, username, pass FROM doctor WHERE username = '" + username.Text + "'";
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    con.Open();
                    SqlDataReader DR1 = cmd.ExecuteReader();
                    if (DR1.Read())
                    {

                        id.Text = DR1.GetValue(0).ToString();
                        name.Text = DR1.GetValue(1).ToString();
                        age.Text = DR1.GetValue(2).ToString();
                        gender.Text = DR1.GetValue(3).ToString();
                        phone.Text = DR1.GetValue(4).ToString();
                        email.Text = DR1.GetValue(5).ToString();
                        address.Text = DR1.GetValue(6).ToString();
                        salary.Text = DR1.GetValue(7).ToString();
                        days.Text = DR1.GetValue(8).ToString();
                        clock.Text = DR1.GetValue(9).ToString();
                        clock_end.Text = DR1.GetValue(10).ToString();
                        username.Text = DR1.GetValue(11).ToString();
                        password.Text = DR1.GetValue(12).ToString();

                    }
                    else
                    {
                        MessageBox.Show(" Your Doctor  '" + username.Text + "'  isn't found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show( ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.Trim()) || string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(age.Text.Trim()) || gender.SelectedIndex == 0 || string.IsNullOrEmpty(email.Text.Trim()) || string.IsNullOrEmpty(days.Text.Trim()) || string.IsNullOrEmpty(phone.Text.Trim()) || string.IsNullOrEmpty(address.Text.Trim()) || string.IsNullOrEmpty(salary.Text.Trim()) || clock.SelectedIndex == 0 || clock_end.SelectedIndex == 0 || string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Please Fill out all Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
                    String sqlStmt = "INSERT INTO doctor (id, Full_Name, age, gender, phone, email, address,salary,days, start_time,end_time, username, pass) VALUES (@i,@fn,@ag,@gen,@phon,@e_mail,@add,@sal,@da,@st,@et,@user,@pass)";
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    cmd.Parameters.AddWithValue("@i", id.Text);
                    cmd.Parameters.AddWithValue("@fn", name.Text);
                    cmd.Parameters.AddWithValue("@ag", age.Text);
                    cmd.Parameters.AddWithValue("@gen", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phon", phone.Text);
                    cmd.Parameters.AddWithValue("@e_mail", email.Text);
                    cmd.Parameters.AddWithValue("@add", address.Text);
                    cmd.Parameters.AddWithValue("@sal", salary.Text);
                    cmd.Parameters.AddWithValue("@da", days.Text);
                    cmd.Parameters.AddWithValue("@st", clock.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@et", clock_end.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@user", username.Text);
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Data is Added Sucessfully :) ");
                    reset();

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.Trim()) || string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(age.Text.Trim()) || gender.SelectedIndex == 0 || string.IsNullOrEmpty(email.Text.Trim()) || string.IsNullOrEmpty(days.Text.Trim()) || string.IsNullOrEmpty(phone.Text.Trim()) || string.IsNullOrEmpty(address.Text.Trim()) || string.IsNullOrEmpty(salary.Text.Trim()) || clock.SelectedIndex == 0 || clock_end.SelectedIndex == 0 || string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Please Fill out all Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                try
                {
                    String sqlStmt = "UPDATE doctor SET Full_Name=@fn,age=@ag,gender=@gen,phone=@phon,email=@e_mail,address=@add,salary=@sal,days=@da,start_time=@st,end_time=@et,username=@user,pass=@pass WHERE id = " + id.Text + " OR  username = '" + username.Text + "'";
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    cmd.Parameters.AddWithValue("@fn", name.Text);
                    cmd.Parameters.AddWithValue("@ag", age.Text);
                    cmd.Parameters.AddWithValue("@gen", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phon", phone.Text);
                    cmd.Parameters.AddWithValue("@e_mail", email.Text);
                    cmd.Parameters.AddWithValue("@add", address.Text);
                    cmd.Parameters.AddWithValue("@sal", salary.Text);
                    cmd.Parameters.AddWithValue("@da", days.Text);
                    cmd.Parameters.AddWithValue("@st", clock.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@et", clock_end.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@user", username.Text);
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Data is Updated Sucessfully :) ");
                    reset();

                }
                catch (SqlException)
                {
                    MessageBox.Show("Please Check your Connection !!", "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.Trim()) && string.IsNullOrEmpty(id.Text.Trim()))
            {
                epName.SetError(id, "Please Fill out  \"ID\"   to delete Doctor  !!");
                epName.SetError(username, "Please Fill out  \"Username\"   to delete Doctor  !!");

            }

            else
            {
                try
                {
                    String sqlStmt = "SELECT id, Full_Name, age, gender, phone, email, address, salary, days, start_time,end_time, username, pass FROM doctor WHERE username = '" + username.Text + "' OR  id = '" + id.Text + "'";
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    con.Open();
                    SqlDataReader DR1 = cmd.ExecuteReader();
                    if (DR1.Read())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to delete Dr : \" " + name.Text + "  ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            String sqlStmt2 = "DELETE FROM doctor WHERE username = '" + username.Text + "' or id = '" + id.Text + "'";
                            SqlConnection con2 = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                            SqlCommand cmd2 = new SqlCommand(sqlStmt2, con2);
                            con2.Open();
                            SqlDataReader DR2 = cmd2.ExecuteReader();
                            MessageBox.Show("Your Data is Deleted Sucessfully :)");
                            con2.Close();
                            reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Your Doctor  \"'" + username.Text + "'\"   isn't found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();



                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click_2(object sender, EventArgs e)
        {
            new admin_control().Show();
            this.Hide();
        }


        private void clear_Click(object sender, EventArgs e)
        {
            reset();
            toolTip1.Show("Rset Data ", clear);

        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void swap_CheckedChanged(object sender, EventArgs e)
        {

            if (swap.Checked == true)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }


    }
}
