using System;
using System.Reflection;
using System.Windows.Forms;

namespace cms
{
    public partial class splach : Form
    {
        private int getVal;
        public splach()
        {
            InitializeComponent();
            guna2CircleProgressBar1.Value = 0;
            timer1.Start();
            string exeAssemblyName = Assembly.GetEntryAssembly().GetName().Name;

        }
        public void StartForm()
        {
            Application.Run(new splach());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Increment(1);
            getVal = guna2CircleProgressBar1.Value;
            label1.Text = "Loading Banifu.dll Component : ["+getVal+"]";
           
            if (getVal == 300)
            {
                new cms().Show();
                this.Hide();
                timer1.Stop();
            }

        }

        private void go_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(getVal.ToString());
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
