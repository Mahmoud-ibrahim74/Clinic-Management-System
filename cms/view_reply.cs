using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using Guna.UI2.WinForms;


namespace cms
{
    public partial class view_reply : Form
    {
        public view_reply()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void view_reply_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select message,fromEmail,username,dateReport from support ", con);
            SqlDataReader rd = cmd.ExecuteReader();
            TextBox  box2 = new TextBox();
            box2.MaxLength = 5000;
            
            while(rd.Read())
            {
                box2.Text = rd[0].ToString() + "\n" + rd[1].ToString() + "\n" + rd[2].ToString() + "\n" + rd[3].ToString();

            }

            Guna2TextBox bo = new Guna2TextBox();
            

            for(int i=0; i<box2.Lines.Length;i++)
            {

            }










        }

    }



}
