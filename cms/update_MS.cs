using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class update_MS : Form
    {
        private String username;
        public update_MS()
        {
            InitializeComponent();


        }
        public update_MS(String user)
        {
            InitializeComponent();
            username = user;


        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void doctor_control_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void add_MouseEnter(object sender, EventArgs e)
        {
            //add.BackColor = Color.BlueViolet;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            //add.BackColor = Color.Transparent;


        }

        private void update_MouseEnter(object sender, EventArgs e)
        {

        }

        private void update_MouseLeave(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            new admin_control().Show();
            this.Hide();
        }

        private void delete_MouseEnter(object sender, EventArgs e)
        {

        }

        private void delete_MouseLeave(object sender, EventArgs e)
        {

        }

        private void back_MouseEnter(object sender, EventArgs e)
        {

        }

        private void back_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void display_MouseEnter(object sender, EventArgs e)
        {

        }

        private void display_MouseLeave(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void add_Click(object sender, EventArgs e)
        {


        }

        private void update_Click(object sender, EventArgs e)
        {



        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void doctor_control_Load(object sender, System.EventArgs e)
        {
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tm_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void display_Click_1(object sender, EventArgs e)
        {

        }

        private void add_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

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

        }

        private void label10_Click(object sender, EventArgs e)
        {

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



        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {


        }
        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click_2(object sender, EventArgs e)
        {
            new admin_control().Show();
            this.Hide();
        }

        private void bunifuiOSSwitch1_OnValueChange_1(object sender, EventArgs e)
        {

        }

        private void clock_end_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void days_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void swap_OnValueChange(object sender, EventArgs e)
        {



        }

        private void bunifuiOSSwitch1_OnValueChange_2(object sender, EventArgs e)
        {

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int s = TableB.SelectedCells.Count;
            if (s < 1)
            {
                MessageBox.Show("Please Select Cell  from table of appointment  to make action !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                int selectedrowindex = TableB.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = TableB.Rows[selectedrowindex];
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

            if (branch.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Branch to Display", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *  from medical_storage where Branch = '" + branch.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);
                TableB.DataSource = dt;
              

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Contains("/"))
            {
                (TableB.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date LIKE '%{0}%'", guna2TextBox1.Text);

            }
            else
            {
                (TableB.DataSource as DataTable).DefaultView.RowFilter = string.Format("Product_Name LIKE '%{0}%'", guna2TextBox1.Text);
            }

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (TableB.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Display Table to Make Action !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int selectedrowP_ID = TableB.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow5 = TableB.Rows[selectedrowP_ID];
                string P_ID = Convert.ToString(selectedRow5.Cells["Product_ID"].Value);

                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete  from medical_storage where Product_ID = " + P_ID + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row is Deleted Successfully");
                con.Close();
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            if (TableB.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Display Table to Make Action !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedrowP_N = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow1 = TableB.Rows[selectedrowP_N];
            string P_N = Convert.ToString(selectedRow1.Cells["Product_Name"].Value);

            int selectedrowP_ID = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow5 = TableB.Rows[selectedrowP_ID];
            string P_ID = Convert.ToString(selectedRow5.Cells["Product_ID"].Value);

            int selectedrowU = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow2 = TableB.Rows[selectedrowU];
            string unt = Convert.ToString(selectedRow2.Cells["Unit"].Value);


            int selectedrowItm = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow3 = TableB.Rows[selectedrowItm];
            string itm = Convert.ToString(selectedRow3.Cells["Items"].Value);


            int selectedrowdt = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow4 = TableB.Rows[selectedrowdt];
            string dt = Convert.ToString(selectedRow4.Cells["Date"].Value);


            int selectedrowBr = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow7 = TableB.Rows[selectedrowBr];
            string Bran = Convert.ToString(selectedRow7.Cells["Branch"].Value); // get Product name from table
            if (Bran != branch.SelectedItem.ToString())
            {
                MessageBox.Show("Please Select Same Branch !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            con.Open();
            try
            {
                String sqlStmt = "Update  medical_storage Set Product_Name =@pn,Unit=@u,Items=@itm,Date=@dt where Product_ID = '" + P_ID + "'";
                SqlCommand cmd = new SqlCommand(sqlStmt, con);
                cmd.Parameters.AddWithValue("@pn", P_N);
                cmd.Parameters.AddWithValue("@u", unt);
                cmd.Parameters.AddWithValue("@itm", itm);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Data is Updated Successfully");
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (TableB.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Display Table to Make Action !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (branch.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Branch to Add Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedrowP_N = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow1 = TableB.Rows[selectedrowP_N];
            string P_N = Convert.ToString(selectedRow1.Cells["Product_Name"].Value); // get Product name from table


            int selectedrowU = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow2 = TableB.Rows[selectedrowU];
            string unt = Convert.ToString(selectedRow2.Cells["Unit"].Value); // get Product name from table


            int selectedrowItm = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow3 = TableB.Rows[selectedrowItm];
            string itm = Convert.ToString(selectedRow3.Cells["Items"].Value); // get Product name from table


            int selectedrowdt = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow4 = TableB.Rows[selectedrowdt];
            string dt = Convert.ToString(selectedRow4.Cells["Date"].Value); // get Product name from table


            int selectedrowBr = TableB.SelectedCells[1].RowIndex;
            DataGridViewRow selectedRow5 = TableB.Rows[selectedrowBr];
            string Bran = Convert.ToString(selectedRow5.Cells["Branch"].Value); // get Product name from table


            if (branch.SelectedItem.ToString().Contains(""+TableB.Rows[0].Cells[5].Value))
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                try
                {
                    String sqlStmt = "insert into medical_storage (Product_Name,Unit,Items,Date,Branch) VALUES (@pn,@u,@itm,@dt,@br)";
                    SqlCommand cmd = new SqlCommand(sqlStmt, con);
                    cmd.Parameters.AddWithValue("@pn", P_N);
                    cmd.Parameters.AddWithValue("@u", unt);
                    cmd.Parameters.AddWithValue("@itm", itm);
                    cmd.Parameters.AddWithValue("@dt", dt);
                    cmd.Parameters.AddWithValue("@br", branch.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Data is Added Successfully");
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Connection Time out = 20s", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Please Make sure Branch in Table Same Selected Branch", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void TableB_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void TableB_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (branch.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Branch to Display", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *  from medical_storage where Branch = '" + branch.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);
                TableB.DataSource = dt;


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TableB.DataSource = null;
        }

  



    }


}

