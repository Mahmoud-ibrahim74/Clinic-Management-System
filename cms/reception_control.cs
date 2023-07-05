using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class reception_control : Form
    {
        public reception_control()
        {
            InitializeComponent();
           gender.SelectedIndex = 0;
            clock.SelectedIndex = 0;
            clock_end.SelectedIndex = 0;
            Qualifications.SelectedIndex = 0;


        }
        private void reset()
        {
           id.Text = "";
            name.Text = "";
            age.Text = "";
            gender.SelectedIndex = 0;
            clock.SelectedIndex = 0;
            clock_end.SelectedIndex = 0;
            Qualifications.SelectedIndex = 0;
            days.Text = "";
            phone.Text = "";
            address.Text = "";
            salary.Text = "";
            password.Text = "";



        }
        private void button1_Click(object sender, EventArgs e)
        {

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

        private void slide_MouseClick(object sender, MouseEventArgs e)
        {
         

        }
   
      

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            if(slideMenu.Width == 85)
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

        private void slideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.Trim()))
            {
                epName.SetError(username, "Please Fill out  \"Username\"   to Display Receptionist  !!");
            }
            else
            {
                try
                {
                    String sqlStmt = "SELECT * FROM receptionist WHERE username = '"+username.Text+"'";
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    con.Open();
                    SqlDataReader DR1 = cmd.ExecuteReader();
                    if (DR1.Read())
                    {

                        id.Text = DR1.GetValue(0).ToString();
                        name.Text = DR1.GetValue(1).ToString();
                        address.Text = DR1.GetValue(2).ToString();
                        days.Text = DR1.GetValue(3).ToString();
                        age.Text = DR1.GetValue(4).ToString();
                        gender.Text = DR1.GetValue(5).ToString();
                        phone.Text = DR1.GetValue(6).ToString();
                        Qualifications.Text = DR1.GetValue(7).ToString();
                        salary.Text = DR1.GetValue(8).ToString();
                        clock.Text = DR1.GetValue(9).ToString();
                        clock_end.Text = DR1.GetValue(10).ToString();
                        username.Text = DR1.GetValue(11).ToString();
                        password.Text = DR1.GetValue(12).ToString();

                    }
                    else
                    {
                        MessageBox.Show(" username :   \"'" + username.Text + "'\"   isn't found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.Trim()) || string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(age.Text.Trim()) || gender.SelectedIndex == 0 || Qualifications.SelectedIndex == 0 || string.IsNullOrEmpty(days.Text.Trim()) || string.IsNullOrEmpty(phone.Text.Trim()) || string.IsNullOrEmpty(address.Text.Trim()) || string.IsNullOrEmpty(salary.Text.Trim()) || clock.SelectedIndex == 0 || clock_end.SelectedIndex == 0 || string.IsNullOrEmpty(password.Text.Trim()))
            {

                MessageBox.Show("Please Fill out all Fileds !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    String sqlStmt = "INSERT INTO receptionist (id, Full_Name, address, days,age, gender, phone, Qualifications,salary,start_time,end_time, username, pass)  VALUES (@i,@fn,@add,@days,@age,@gen,@phon,@quali,@sal,@st,@et,@user,@pass)";
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    cmd.Parameters.AddWithValue("@i", id.Text);
                    cmd.Parameters.AddWithValue("@fn", name.Text);
                    cmd.Parameters.AddWithValue("@age", age.Text);
                    cmd.Parameters.AddWithValue("@gen", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phon", phone.Text);
                    cmd.Parameters.AddWithValue("@add", address.Text);
                    cmd.Parameters.AddWithValue("@sal", salary.Text);
                    cmd.Parameters.AddWithValue("@days", days.Text);
                    cmd.Parameters.AddWithValue("@st", clock.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@quali", Qualifications.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@et", clock_end.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@user", username.Text);
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Data is Added Sucessfully :) ");
                    reset();

                }
                catch (SqlException exc)
                {

                    MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(age.Text.Trim()) || gender.SelectedIndex == 0 || Qualifications.SelectedIndex == 0 || string.IsNullOrEmpty(days.Text.Trim()) || string.IsNullOrEmpty(phone.Text.Trim()) || string.IsNullOrEmpty(address.Text.Trim()) || string.IsNullOrEmpty(salary.Text.Trim()) || clock.SelectedIndex == 0 || clock_end.SelectedIndex == 0 || string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Please Fill out username and display receptionist to make update  !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("Please Fill out username  to make update  !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
               try
                {
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    String sqlStmt = "UPDATE receptionist SET Full_Name=@fn,address=@add,days=@days,age=@age,gender=@gen,phone=@phon,Qualifications=@quali,salary=@sal,start_time=@st,end_time=@et,pass=@pass WHERE username = '" + username.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    cmd.Parameters.AddWithValue("@fn", name.Text);
                    cmd.Parameters.AddWithValue("@age", age.Text);
                    cmd.Parameters.AddWithValue("@gen", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phon", phone.Text);
                    cmd.Parameters.AddWithValue("@add", address.Text);
                    cmd.Parameters.AddWithValue("@sal", salary.Text);
                    cmd.Parameters.AddWithValue("@days", days.Text);
                    cmd.Parameters.AddWithValue("@st", clock.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@quali", Qualifications.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@et", clock_end.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Data is Updated Sucessfully :) ");
                    reset();

                }
                catch (SqlException exc)
                {

                    MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {

              if (string.IsNullOrEmpty(username.Text.Trim()))
              {
                  epName.SetError(username, "Please Fill out  \"Username\"   to delete Receptionist  !!");

              }
              
              else
              {
                  DialogResult dr = MessageBox.Show("Do you want to delete Rec : \" " + username.Text + " \"  ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  if (dr == DialogResult.Yes)
                  {
                      try
                      {
                          SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                          String sqlStmt = "DELETE FROM receptionist WHERE username = '" + username.Text + "' ";
                          SqlCommand cmd = new SqlCommand(sqlStmt, con);
                          con.Open();
                          cmd.ExecuteReader();
                          MessageBox.Show("Your Data is Deleted Sucessfully :)");
                          reset();
                          con.Close();

                      }
                      catch (SqlException ex)
                      {
                          MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                      }

                     
                  }

                  else
                  {

                  }
              }
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

        private void swap_OnValueChange(object sender, EventArgs e)
        {
        
        
            if (swap.Value == true)
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
