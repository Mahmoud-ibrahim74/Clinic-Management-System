using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class MS_Control : Form
    {
        private string username;
        private float Res = 0;
        public MS_Control()
        {
            InitializeComponent();


        }

        public MS_Control(string getusername)
        {
            InitializeComponent();
            username = getusername;
            user.Text = username;


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
            tm.Start();
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM medical_storage";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                TableA.DataSource = dt;
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
                slideMenu.Width = 200;
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



        private void header_Paint(object sender, PaintEventArgs e)
        {

        }


        private void show_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from MS_History";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                TableB.DataSource = dt;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void back_Click_2(object sender, EventArgs e)
        {
            new cms().Show();
            this.Hide();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }



        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

            (TableA.DataSource as DataTable).DefaultView.RowFilter = string.Format("Product_Name LIKE '%{0}%'", guna2TextBox1.Text);
        }

        private void guna2TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            int SelectRow = TableA.SelectedCells.Count;
            if (SelectRow < 1)
            {
                MessageBox.Show("Please Select Cell of Box From Storage !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int selectedST = TableA.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow1 = TableA.Rows[selectedST];
                string st = Convert.ToString(selectedRow1.Cells["Items"].Value); // get BOX value  from table
                float Value_Items = float.Parse(st);
                float Value_Amount = float.Parse(amount.Value.ToString());
                Res = Value_Items - Value_Amount;
                left_box.Text = " Left Box  =   " + Res.ToString() + "";

            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(p_name.Text))
            {
                epName.SetError(p_name, "please Fill out Product Name");
            }
            else if (string.IsNullOrEmpty(unit.Text))
            {
                epName.SetError(unit, "please Fill out Unit Name");
            }
            else if (Res == 0)
            {
                epName.SetError(left_box, "please Make Left Box By clicking on it !!");
            }
            else if (string.IsNullOrEmpty(doctor_name.Text))
            {
                epName.SetError(doctor_name, "please Fill out Doctor Name");
            }
            else
            {

                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into MS_History values(@pn,@u,@am,@lb,@wdate,@doc,@user)", con);
                cmd.Parameters.AddWithValue("@pn", p_name.Text);
                cmd.Parameters.AddWithValue("@u", unit.Text);
                cmd.Parameters.AddWithValue("@am", amount.Value);
                cmd.Parameters.AddWithValue("@lb", Res);
                cmd.Parameters.AddWithValue("@wdate", date.Value.ToLongDateString());
                cmd.Parameters.AddWithValue("@doc", doctor_name.Text);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data is Added Sucessfully ");
                con.Close();

            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int SelectRow = TableB.SelectedCells.Count;
            if (SelectRow < 1)
            {
                MessageBox.Show("Please Select Row from Medical Hsitory Table  !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int selectedST = TableB.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow1 = TableB.Rows[selectedST];
                string P_ID = Convert.ToString(selectedRow1.Cells["Product_ID"].Value); // get Product_ID value  from table
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from MS_History where Product_ID = " + P_ID + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data is Deleted Sucessfully ");
                con.Close();


            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            new update_MS().Show();
            this.Hide();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            if (tm.Interval == 5000)
            {
                loader.Visible = false;
                tm.Stop();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you Want To Restart Window !!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void left_box_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
