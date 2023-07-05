using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class MS_history : Form
    {
        public MS_history()
        {
            InitializeComponent();


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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            if (slideMenu.Width == 75)
            {
                slideMenu.Visible = false;
                slideMenu.Width = 250;
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
                table2.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void back_Click_2(object sender, EventArgs e)
        {
            new admin_control().Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


    }
}
