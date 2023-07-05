using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cms
{
    public partial class cms : Form
    {
        public cms()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void admin_MouseEnter(object sender, EventArgs e)
        {
            admin.BackColor = Color.FromArgb(128, 128, 255);
            admin.ForeColor = Color.White;

        }

        private void admin_MouseLeave(object sender, EventArgs e)
        {
            admin.BackColor = Color.White;
            admin.ForeColor = Color.FromArgb(128, 128, 255);


        }

        private void reception_MouseEnter(object sender, EventArgs e)
        {
            reception.BackColor = Color.FromArgb(128, 128, 255);
            reception.ForeColor = Color.White;
        }

        private void reception_MouseLeave(object sender, EventArgs e)
        {
            reception.BackColor = Color.White;
            reception.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void doctor_MouseEnter(object sender, EventArgs e)
        {
            doctor.BackColor = Color.FromArgb(128, 128, 255);
            doctor.ForeColor = Color.White;
        }

        private void doctor_MouseLeave(object sender, EventArgs e)
        {
            doctor.BackColor = Color.White;
            doctor.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void cms_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure to close Program  ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            medical.BackColor = Color.FromArgb(128, 128, 255);
            medical.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            medical.BackColor = Color.White;
            medical.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void admin_Click(object sender, EventArgs e)
        {
            new login_admin().Show();
            this.Hide();


        }



    }
}
