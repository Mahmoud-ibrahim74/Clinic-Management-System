using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class lower_staff : Form
    {
        public lower_staff()
        {
            InitializeComponent();
           gender.SelectedIndex = 0;
            clock.SelectedIndex = 0;
            clock_end.SelectedIndex = 0;
            type.SelectedIndex = 0;


        }
        private void reset()
        {
           id.Text = "";
            name.Text = "";
            age.Text = "";
            gender.SelectedIndex = 0;
            type.SelectedIndex = 0;
            clock.SelectedIndex = 0;
            clock_end.SelectedIndex = 0;
            email.Text = "";
            days.Text = "";
            phone.Text = "";
            address.Text = "";
            salary.Text = "";


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

        private void tm_Tick(object sender, EventArgs e)
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

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo2_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                epName.SetError(name, "Please Fill out  \"Full Name\"   to Display Staff  !!");
            }
            else
            {
                try
                {
                    String sqlStmt = "select * from staff where Full_Name like '%"+name.Text+"%'";
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    con.Open();
                    SqlDataReader DR1 = cmd.ExecuteReader();
                    if (DR1.Read())
                    {

                        id.Text = DR1.GetValue(0).ToString();
                        name.Text = DR1.GetValue(1).ToString();
                        address.Text = DR1.GetValue(2).ToString();
                        age.Text = DR1.GetValue(3).ToString();
                        gender.Text = DR1.GetValue(4).ToString();
                        phone.Text = DR1.GetValue(5).ToString();
                        days.Text = DR1.GetValue(6).ToString();
                        type.Text = DR1.GetValue(7).ToString();
                        salary.Text = DR1.GetValue(8).ToString();
                        clock.Text = DR1.GetValue(9).ToString();
                        clock_end.Text = DR1.GetValue(10).ToString();
                        email.Text = DR1.GetValue(11).ToString();


                    }
                    else
                    {
                        MessageBox.Show(" Your Staff  \"'" + name.Text + "'\"  isn't found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text ) || string.IsNullOrEmpty(id.Text ) || string.IsNullOrEmpty(age.Text ) || gender.SelectedIndex == 0 || string.IsNullOrEmpty(email.Text ) || string.IsNullOrEmpty(days.Text ) || string.IsNullOrEmpty(phone.Text ) || string.IsNullOrEmpty(address.Text ) || string.IsNullOrEmpty(salary.Text ) || clock.SelectedIndex == 0 || clock_end.SelectedIndex == 0 || type.SelectedIndex == 0)
            {
                MessageBox.Show("Please Fill out all fields !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    String sqlStmt = "INSERT INTO staff(id, Full_Name, address, age, gender, phone, days,staff_type, salary, start_time, end_time, email) VALUES (@i,@fn,@add,@age,@gender,@phon,@days,@st,@sal,@start,@end,@e)";
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    cmd.Parameters.AddWithValue("@i", id.Text);
                    cmd.Parameters.AddWithValue("@fn", name.Text);
                    cmd.Parameters.AddWithValue("@add", address.Text);
                    cmd.Parameters.AddWithValue("@age", age.Text);
                    cmd.Parameters.AddWithValue("@gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phon", phone.Text);
                    cmd.Parameters.AddWithValue("@days", days.Text);
                    cmd.Parameters.AddWithValue("@st", type.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sal", salary.Text);
                    cmd.Parameters.AddWithValue("@start", clock.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@end", clock_end.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@e", email.Text);                   
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


            if (name.Text=="" || address.Text == ""||age.Text =="" || phone.Text =="" || gender.SelectedIndex == 0 || email.Text == "" || days.Text == "" || salary.Text == "" || clock.SelectedIndex == 0 || clock_end.SelectedIndex == 0 || type.SelectedIndex == 0)

            {
                MessageBox.Show("Please Fill out all fields !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                try
                {
                    String sqlStmt = "UPDATE staff SET id=@i,address=@add,age=@age,gender=@gender,phone=@phon,days=@days,staff_type=@st,salary=@sal,start_time=@start,end_time=@end, email =@e WHERE Full_Name =  '"+name.Text+"' ";
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    cmd.Parameters.AddWithValue("@i", id.Text);
                    cmd.Parameters.AddWithValue("@add", address.Text);
                    cmd.Parameters.AddWithValue("@age", age.Text);
                    cmd.Parameters.AddWithValue("@gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phon", phone.Text);
                    cmd.Parameters.AddWithValue("@days", days.Text);
                    cmd.Parameters.AddWithValue("@st", type.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sal", salary.Text);
                    cmd.Parameters.AddWithValue("@start", clock.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@end", clock_end.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@e", email.Text);
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
     
              if (string.IsNullOrEmpty(name.Text ) )
              {
                  epName.SetError(name, "Please Fill out  \"Name\"   to delete Doctor  !!");

              }
              
            
              else
              {
                  DialogResult dr = MessageBox.Show("Do you want to delete Staff : \" " + name.Text + " \" \n\n ID : "+id.Text+" ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  if (dr == DialogResult.Yes)
                  {
                      try
                      {
                          SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                          String sqlStmt = "delete  from staff where Full_Name like '%" + name.Text + "%'";
                          SqlCommand cmd = new SqlCommand(sqlStmt, con);
                          con.Open();
                          cmd.ExecuteNonQuery();
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
            toolTip1.Show("Reset Data", clear);

        }

       
      
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

      
    }
}
