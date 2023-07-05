using System;
using System.Windows.Forms;

namespace cms
{
    public partial class cms : Form
    {
        public cms()
        {

            InitializeComponent();
            labelMain.Visible = false;
            panelAnimation.BackColor = System.Drawing.Color.Silver;

        }

        public void StartForm()
        {
            Application.Run(new splach());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void cms_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void admin_Click(object sender, EventArgs e)
        {


        }

        private void doctor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void cms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void reception_Click(object sender, EventArgs e)
        {

        }

        private void medical_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            new admin_login().Show();
            this.Hide();

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            new doc_login().Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            new recptionist_login().Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            new mS_Login().Show();
            this.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            new report().Show();

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            new cc_control().Show();
            this.Hide();


        }

        private void tm_Tick(object sender, EventArgs e)
        {

        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            if (panelAnimation.Width == 40)
            {
                panelAnimation.Visible = false;
                panelAnimation.Width = 220;
                panelAnimator.ShowSync(panelAnimation);
                panelAnimation.BackColor = System.Drawing.Color.White;
                labelMain.Visible = true;
                
            }
            else
            {
                panelAnimation.Visible = false;
                panelAnimation.Width = 40;
                panelAnimator.ShowSync(panelAnimation);
                labelMain.Visible = false;
                panelAnimation.BackColor = System.Drawing.Color.Silver;

            }
        }

 

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            
        }



    }
}
