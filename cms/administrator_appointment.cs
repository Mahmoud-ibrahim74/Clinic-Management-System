using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class administrator_appointment : Form
    {
        public administrator_appointment()
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


        private void tm_Tick(object sender, EventArgs e)
        {
            if (tm.Interval == 5000)
            {

                loader.Visible = false;
                tm.Stop();

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            tm.Start();
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
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int s = TableA.SelectedCells.Count;
            if (s < 1)
            {
                epName.SetError(TableA, "Please Select Cell  from table of appointment  to make action !!");


            }
            else
            {
                int selectedrowindex = TableA.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = TableA.Rows[selectedrowindex];
                string pn = Convert.ToString(selectedRow.Cells["Patient ID"].Value); // get value from table
                SqlConnection con = new SqlConnection(" Server =.\\SQLEXPRESS; Database=cms; Integrated Security=true;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM appointment WHERE Patient_ID = '" + pn + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient :" + pn + " was deleted successfully   (^__^)");
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Patient_ID as 'Patient ID' ,Patient_Name ,Patient_Phone as 'Patient Phone',Device_Type as  'Device Type',Body_Devices as 'Session Type',Timing as 'Time' ,Curr_Date as 'Date' ,payment_method as 'Payment Method',total_paid as 'Total Paid',left_paid as 'Left Paid',DOC_Name as 'Doctor Name'  ,Branch,source as 'Lead Source' ,username from appointment";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                TableA.DataSource = dt;
                cmd.Dispose();
                SqlCommand cmd2 = new SqlCommand("select Sum (total_paid)   from appointment ", con);
                SqlDataReader rd = cmd2.ExecuteReader();
                if (rd.Read())
                {
                    name.Text = rd[0].ToString();
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            (TableA.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date LIKE '%{0}%'", guna2TextBox1.Text);

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            int s = TableA.SelectedRows.Count;
            if (s < 1)
            {
                epName.SetError(TableA, "Please Select Row  from table of appointment  to make Confirmation !!");


            }
            else
            {
                try
                {
                    int selectedrowindex = TableA.SelectedCells[1].RowIndex;
                    DataGridViewRow selectedRow = TableA.Rows[selectedrowindex];
                    string pn = Convert.ToString(selectedRow.Cells["Patient ID"].Value); // get value from table
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM appointment WHERE Patient_ID = '" + pn + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient :" + pn + " was deleted successfully   (^__^)");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            if (TableA.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select Row To make Update !!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                int selectedrowindex = TableA.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = TableA.Rows[selectedrowindex];
                string p_phon = Convert.ToString(selectedRow.Cells["Patient Phone"].Value); // get value from table
                string get_ID = selectedRow.Cells["Patient ID"].Value.ToString();
                string get_name = selectedRow.Cells["Patient_Name"].Value.ToString();
                string get_type = selectedRow.Cells["Device Type"].Value.ToString();
                string get_Sess = selectedRow.Cells["Session Type"].Value.ToString();
                string get_Date = selectedRow.Cells["Date"].Value.ToString();
                string get_Doc = selectedRow.Cells["Doctor Name"].Value.ToString();
                string get_Bran = selectedRow.Cells["Branch"].Value.ToString();
                string get_Lead = selectedRow.Cells["Lead Source"].Value.ToString();

                DialogResult dr = MessageBox.Show("New Data is \n Patient Name : " + get_name + " . \n Patient Phone : " + p_phon + " . \n Device Type  : " + get_type + " . \n Session Type : " + get_Sess + " .  \n Date : " + get_Date + " . \n Doctor Name : " + get_Doc + " . \n Branch : " + get_Bran + " . \n Lead Source : " + get_Lead + " . \n\n Do you Want To Make Update for this Data ?? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(" Server =.\\SQLEXPRESS; Database=cms; Integrated Security=true;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update appointment set  Patient_Name = '" + get_name + "',Patient_Phone = '" + p_phon + "',Device_Type = '" + get_type + "', Body_Devices = '" + get_Sess + "',Curr_Date = '" + get_Date + "', DOC_Name = '" + get_Doc + "', Branch  = '" + get_Bran + "',source = '" + get_Lead + "' where Patient_ID = " + get_ID + "", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated  successfully   (^__^)");
                }


            }
        }

   












    }
}
