using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace cms
{
    public partial class appointment : Form
    {
        String username;
        public appointment()
        {
            InitializeComponent();
            kind.SelectedIndex = 0;
            body.SelectedIndex = 0;
            timing.SelectedIndex = 0;
            payment_method.SelectedIndex = 0;
            source.SelectedIndex = 0;
            branch.SelectedIndex = 0;
            date.Checked = false;


        }
        public appointment(String user)
        {
            InitializeComponent();
            kind.SelectedIndex = 0;
            body.SelectedIndex = 0;
            timing.SelectedIndex = 0;
            payment_method.SelectedIndex = 0;
            source.SelectedIndex = 0;
            branch.SelectedIndex = 0;
            date.Checked = false;
            username = user;




        }
        private void reset()
        {
            name.Text = "";
            kind.SelectedIndex = 0;
            body.SelectedIndex = 0;
            timing.SelectedIndex = 0;
            payment_method.SelectedIndex = 0;
            source.SelectedIndex = 0;
            branch.SelectedIndex = 0;
            phone.Text = "";
            total_paid.Text = "";
            left.Text = "";


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

            tm.Start();
            String getDate = date.Value.ToLongDateString();
            SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  Full_Name,days, start_time, end_time FROM doctor where username != 'Basem369'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                TableA.DataSource = dt;
                TableA.ReadOnly = true;
                TableA.ScrollBars = ScrollBars.Both;
                TableA.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tm_Tick(object sender, EventArgs e)
        {
            if (tm.Interval == 5000)
            {
                if (TableA.RowCount > 0)
                {
                    loader.Visible = false;
                }
                else
                {
                    MessageBox.Show("Couldn't load  Data of doctor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loader.Visible = false;
                    TableA.Visible = false;
                }
            }

            tm.Stop();
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
            if (slideMenu.Width == 75)
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
                slideMenu.Width = 75;
                panelAnimator.ShowSync(slideMenu);
                logoAnimator.ShowSync(logo);
                logoAnimator.Hide(logo2);


            }
        }



        private void show_Click(object sender, EventArgs e)
        {
            new View_appointment(username).Show();
            this.Hide();


        }


        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            int s = TableA.SelectedRows.Count;
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(phone.Text) || timing.SelectedIndex == 0 || branch.SelectedIndex == 0 || payment_method.SelectedIndex == 0 || string.IsNullOrEmpty(total_paid.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(left.Text) || source.SelectedIndex == 0 || date.Checked == true)
            {
                MessageBox.Show("Please Fill out Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (s < 1)
            {
                epName.SetError(TableA, "Please Select Row  from table to make appointment !!");


            }
            else
            {

                String sqlStmt = "INSERT INTO appointment(Patient_Name, Patient_Phone, Device_Type, Body_Devices, Timing, Curr_Date,payment_method,total_paid,left_paid, DOC_Name, username,Branch,source) VALUES (@pn,@pp,@dt,@bd,@time,@dat,@pm,@tp,@lp,@dn,@u,@bran,@src)";
                String sqlStmt2 = "SELECT Timing,Device_Type FROM appointment ";
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    SqlCommand cmd2 = new SqlCommand(sqlStmt2, con);
                    con.Open();
                    SqlDataReader rd = cmd2.ExecuteReader();

                    while (rd.Read())
                    {

                        if (timing.Text.Equals(rd["Timing"]) && kind.SelectedItem.ToString().Equals((rd["Device_Type"])))  // check for time of devices
                        {
                            MessageBox.Show("Your Device  \"" + kind.SelectedItem.ToString() + "\"  is reserved for Time \" " + timing.Text + " \" ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }


                    } rd.Close();


                    int selectedST = TableA.SelectedCells[1].RowIndex;
                    DataGridViewRow selectedRow1 = TableA.Rows[selectedST];
                    string st = Convert.ToString(selectedRow1.Cells["start_time"].Value); // get Start time from table

                    int selectedET = TableA.SelectedCells[1].RowIndex;
                    DataGridViewRow selectedRow2 = TableA.Rows[selectedET];
                    string et = Convert.ToString(selectedRow2.Cells["end_time"].Value); // get end time from table

                    int selectedrowindex = TableA.SelectedCells[1].RowIndex;
                    DataGridViewRow selectedRow = TableA.Rows[selectedrowindex];
                    string a = Convert.ToString(selectedRow.Cells["Full_Name"].Value); // get full name from table

                    String stCon = new String(st.Where(Char.IsDigit).ToArray());
                    String etCon = new String(et.Where(Char.IsDigit).ToArray());
                    String tCombo = new String(timing.Text.Where(Char.IsDigit).ToArray());


                    long ST_Val = Convert.ToInt64(stCon);
                    long ET_Val = Convert.ToInt64(etCon);
                    long timeCombo = Convert.ToInt64(tCombo);
                    MessageBox.Show(ST_Val.ToString());
                    if (timing.Text.Contains("PM") && st.Contains("PM") && et.Contains("PM"))  // if timeCombo (PM) and  (ST) is (PM) and (ET) is (PM)
                    {

                        if (timeCombo >= ST_Val && timeCombo < ET_Val)   // if timeCombo between ST and ET
                        {
                            cmd.Parameters.AddWithValue("@pn", name.Text);
                            cmd.Parameters.AddWithValue("@pp", phone.Text);
                            cmd.Parameters.AddWithValue("@dt", kind.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@bd", body.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@time", timing.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@dat", date.Value.ToLongDateString());
                            cmd.Parameters.AddWithValue("@pm", payment_method.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@tp", total_paid.Text);
                            cmd.Parameters.AddWithValue("@lp", left.Text);
                            cmd.Parameters.AddWithValue("@dn", a);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@bran", branch.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@src", source.SelectedItem.ToString());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Appointment is Added Sucessfully (^__^) ");
                            reset();

                        }
                        else
                        {
                            MessageBox.Show("Your Time is Wrong !! please choose correct time for period time of doctor !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    else if (timing.Text.Contains("AM") && st.Contains("AM") && et.Contains("AM"))  // if timeCombo (AM) and  (ST) is (AM) and (ET) is (AM)
                    {

                        if (timeCombo >= ST_Val && timeCombo < ET_Val)   // if timeCombo between ST and ET
                        {

                            cmd.Parameters.AddWithValue("@pn", name.Text);
                            cmd.Parameters.AddWithValue("@pp", phone.Text);
                            cmd.Parameters.AddWithValue("@dt", kind.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@bd", body.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@time", timing.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@dat", date.Value.ToLongDateString());
                            cmd.Parameters.AddWithValue("@pm", payment_method.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@tp", total_paid.Text);
                            cmd.Parameters.AddWithValue("@lp", left.Text);
                            cmd.Parameters.AddWithValue("@dn", a);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@bran", branch.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@src", source.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Appointment is Added Sucessfully   (^__^) ");
                            reset();



                        }
                        else
                        {
                            MessageBox.Show("Your Time is Wrong !! please choose correct time for period time of doctor !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    else if (timing.Text.Contains("AM") && st.Contains("AM") && et.Contains("PM"))  // if timeCombo (AM) and  (ST) is (AM) and (ET) is (PM)
                    {

                        if (timeCombo >= ST_Val && timeCombo <= 1100)   // if timeCombo between ST and 12:00 AM
                        {

                            cmd.Parameters.AddWithValue("@pn", name.Text);
                            cmd.Parameters.AddWithValue("@pp", phone.Text);
                            cmd.Parameters.AddWithValue("@dt", kind.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@bd", body.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@time", timing.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@dat", date.Value.ToLongDateString());
                            cmd.Parameters.AddWithValue("@pm", payment_method.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@tp", total_paid.Text);
                            cmd.Parameters.AddWithValue("@lp", left.Text);
                            cmd.Parameters.AddWithValue("@dn", a);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@bran", branch.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@src", source.SelectedItem.ToString());


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Appointment is Added Sucessfully   (^__^) ");
                            reset();


                        }

                        else
                        {
                            MessageBox.Show("Your Time is Wrong !! please choose correct time for period time of doctor !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    else if (timing.Text.Contains("PM") && st.Contains("AM") && et.Contains("PM"))  // if timeCombo (PM) and  (ST) is (AM) and (ET) is (PM)
                    {

                        if (timeCombo < ET_Val || timeCombo == 1200)   // if timeCombo less than ET and 12:00 PM
                        {

                            cmd.Parameters.AddWithValue("@pn", name.Text);
                            cmd.Parameters.AddWithValue("@pp", phone.Text);
                            cmd.Parameters.AddWithValue("@dt", kind.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@bd", body.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@time", timing.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@dat", date.Value.ToLongDateString());
                            cmd.Parameters.AddWithValue("@pm", payment_method.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@tp", total_paid.Text);
                            cmd.Parameters.AddWithValue("@lp", left.Text);
                            cmd.Parameters.AddWithValue("@dn", a);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@bran", branch.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@src", source.SelectedItem.ToString());


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Appointment is Added Sucessfully   (^__^) ");
                            reset();


                        }
                        else
                        {
                            MessageBox.Show("Your Time is Wrong !! please choose correct time for period time of doctor !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }


                    else if (timing.Text.Contains("PM") && st.Contains("PM") && et.Contains("AM"))  // if timeCombo (AM) and  (ST) is (AM) and (ET) is (PM)
                    {

                        if (timeCombo >= ST_Val || timeCombo <= 1100)   // if timeCombo between ST and 12:00 AM
                        {
                            cmd.Parameters.AddWithValue("@pn", name.Text);
                            cmd.Parameters.AddWithValue("@pp", phone.Text);
                            cmd.Parameters.AddWithValue("@dt", kind.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@bd", body.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@time", timing.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@dat", date.Value.ToLongDateString());
                            cmd.Parameters.AddWithValue("@pm", payment_method.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@tp", total_paid.Text);
                            cmd.Parameters.AddWithValue("@lp", left.Text);
                            cmd.Parameters.AddWithValue("@dn", a);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@bran", branch.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@src", source.SelectedItem.ToString());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Appointment is Added Sucessfully   (^__^) ");
                            reset();


                        }

                        else
                        {
                            MessageBox.Show("Your Time is Wrong !! please choose correct time for period time of doctor !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    else if (timing.Text.Contains("AM") && st.Contains("PM") && et.Contains("AM"))  // if timeCombo (AM) and  (ST) is (AM) and (ET) is (PM)
                    {

                        if (timeCombo < ET_Val || timeCombo == 1200)   // if timeCombo less than ET and 12:00 PM
                        {

                            cmd.Parameters.AddWithValue("@pn", name.Text);
                            cmd.Parameters.AddWithValue("@pp", phone.Text);
                            cmd.Parameters.AddWithValue("@dt", kind.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@bd", body.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@time", timing.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@dat", date.Value.ToLongDateString());
                            cmd.Parameters.AddWithValue("@pm", payment_method.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@tp", total_paid.Text);
                            cmd.Parameters.AddWithValue("@lp", left.Text);
                            cmd.Parameters.AddWithValue("@dn", a);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@bran", branch.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@src", source.SelectedItem.ToString());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Appointment is Added Sucessfully   (^__^) ");
                            reset();

                        }
                        else
                        {
                            MessageBox.Show("Your Time is Wrong !! please choose correct time for period time of doctor !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                    else
                    {
                        MessageBox.Show("Your Time is Wrong !! please choose correct time for period time of doctor !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            new View_appointment(username).Show();
            this.Hide();

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click_2(object sender, EventArgs e)
        {
            new cms().Show();
            this.Hide();
        }

        private void bunifuiOSSwitch1_OnValueChange_1(object sender, EventArgs e)
        {

        }

        private void body_end_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void body_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you Want to Restart Your Window !!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                Application.Restart();
            }

        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void calc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }


    }
}
