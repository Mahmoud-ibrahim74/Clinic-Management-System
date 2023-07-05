using System;
using System.Drawing;
using System.Windows.Forms;

namespace cms
{
    public partial class admin_control : Form
    {
        public admin_control()
        {
            InitializeComponent();
        }
  
        private void admin_control_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void lower_staff_Click(object sender, EventArgs e)
        {
            new lower_staff().Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

 
        private void button2_Click(object sender, EventArgs e)
        {
            new administrator_appointment().Show();
            this.Hide();
        }
    
        private void ms_Click(object sender, EventArgs e)
        {
            new MS_history().Show();
            this.Hide();
        }

   
        private void button2_Click_1(object sender, EventArgs e)
        {
            new update_MS().Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            new doctor_control().Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            new reception_control().Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            new administrator_appointment().Show();
            this.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            new MS_history().Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

            new update_MS().Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            new lower_staff().Show();
            this.Hide();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            new cms().Show();
            this.Hide();
            
        }

    
        

    }
}
