using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class doctor_appointment : Form
    {
        private String username;
        private String P_n;
        private String getDoc;


        public doctor_appointment()
        {
            InitializeComponent();

        }
        public doctor_appointment(String user)
        {

            InitializeComponent();
            username = user;
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void slideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Full_Name  FROM doctor WHERE username = '" + username + "'";
                cmd.ExecuteNonQuery();
                string get_DB_Name = cmd.ExecuteScalar().ToString();
                getDoc = get_DB_Name;
                String sqlStmt2 = "SELECT Patient_ID,Patient_Name,  Device_Type, Body_Devices, Timing, DOC_Name FROM appointment  WHERE DOC_Name = '" + get_DB_Name + "'";
                SqlCommand cmd2 = new SqlCommand(sqlStmt2, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(dt);
                dg.DataSource = dt;
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            int SelectedRow = dg.SelectedRows.Count;
            if (SelectedRow < 1)
            {
                MessageBox.Show("Please Select Row from Table to Add Diagnose !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(diagon.Text))
            {
                MessageBox.Show("Please Fill out Diagnose or Fill out  as  [No Diagnose] !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int selectedST = dg.SelectedCells[1].RowIndex;
                    DataGridViewRow selectedRow1 = dg.Rows[selectedST];
                    string get_T = Convert.ToString(selectedRow1.Cells["Device_Type"].Value);
                    string get_ID = Convert.ToString(selectedRow1.Cells["Patient_ID"].Value);
                    P_n = Convert.ToString(selectedRow1.Cells["Patient_Name"].Value);

                    string get_B = Convert.ToString(selectedRow1.Cells["Body_Devices"].Value);
                    string get_D = Convert.ToString(selectedRow1.Cells["DOC_Name"].Value);
                    string getMedeicine = medicine.Text;


                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    con.Open();
                    String sqlStmt2 = "INSERT INTO diagnose(Pati_ID , Patient_Name, Device_Type, Body_Devices, DOC_Name, medicine, diagnose) VALUES (" + get_ID + ",'" + P_n + "','" + get_T + "','" + get_B + "','" + get_D + "','" + getMedeicine + "','" + diagon.Text + "')";
                    SqlCommand cmd2 = new SqlCommand(sqlStmt2, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Your Diagnose is Added Sueccfully (^__^)");
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
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                String sqlStmt2 = "SELECT Patient_Name, Device_Type, Body_Devices, DOC_Name, medicine, diagnose FROM diagnose WHERE Patient_Name LIKE '%" + P_n + "%' AND DOC_Name != '" + getDoc + "'";
                SqlCommand cmd2 = new SqlCommand(sqlStmt2, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(dt);
                view.DataSource = dt;
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click_2(object sender, EventArgs e)
        {
            new doc_login().Show();
            this.Hide();
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void dg_SelectionChanged_1(object sender, EventArgs e)
        {
            int SelectedRow = dg.SelectedRows.Count;
            if (SelectedRow < 1)
            {

            }
            else
            {
                int selectedST = dg.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow1 = dg.Rows[selectedST];
                string st = Convert.ToString(selectedRow1.Cells["Patient_Name"].Value); // get Patient_Name from table
                P_n = st;
            }
        }

        private void dg_SelectionChanged_2(object sender, EventArgs e)
        {
            int SelectRow = dg.SelectedRows.Count;
            if (SelectRow < 1)
            {

            }
            else
            {
                int selectedST = dg.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow1 = dg.Rows[selectedST];
                P_n = Convert.ToString(selectedRow1.Cells["Patient_Name"].Value);
            }


        }


    }
}
