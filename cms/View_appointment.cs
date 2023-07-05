using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cms
{
    public partial class View_appointment : Form
    {
        private String username;
        public View_appointment()
        {
            InitializeComponent();
         

        }
        public View_appointment(String user)
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
            appointment app = new appointment(username);
            app.Show();
            app.loader.Visible = false;
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
                cmd.CommandText = "Select Patient_ID as 'Patient ID' ,Patient_Name ,Patient_Phone as 'Patient Phone',Device_Type as  'Device Type',Body_Devices as 'Session Type',Timing as 'Time' ,Curr_Date as 'Date' ,payment_method as 'Payment Method',total_paid as 'Total Paid',left_paid as 'Left Paid',DOC_Name as 'Doctor Name' ,Branch,source as 'Lead Source',confirm,username  from appointment";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                TableA.DataSource = dt;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            (TableA.DataSource as DataTable).DefaultView.RowFilter = string.Format("Patient_Name LIKE '%{0}%'", guna2TextBox1.Text);

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
                int selectedrowindex = TableA.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = TableA.Rows[selectedrowindex];
                string conf = Convert.ToString(selectedRow.Cells["confirm"].Value); // get value from table
                string p_phon = Convert.ToString(selectedRow.Cells["Patient Phone"].Value); // get value from table
                SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update appointment set confirm = '"+conf+"' where Patient_Phone = "+p_phon+"";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Confirmation is added  successfully   (^__^)");
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            if (TableA.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select Row To make Update !!", "ERROR",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

                DialogResult dr = MessageBox.Show("New Data is \n Patient Name : "+get_name+" . \n Patient Phone : "+p_phon+" . \n Device Type  : "+get_type+" . \n Session Type : "+get_Sess+" .  \n Date : "+get_Date+" . \n Doctor Name : "+get_Doc+" . \n Branch : "+get_Bran+" . \n Lead Source : "+get_Lead+" . \n\n Do you Want To Make Update for this Data ?? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update appointment set  Patient_Name = '" + get_name + "',Patient_Phone = '" + p_phon + "',Device_Type = '" + get_type + "', Body_Devices = '" + get_Sess + "',Curr_Date = '" + get_Date + "', DOC_Name = '" + get_Doc + "', Branch  = '" + get_Bran + "',source = '" + get_Lead + "' where Patient_ID = " + get_ID + "", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated  successfully   (^__^)");
                }


            }
        }

     

 


    }
}
