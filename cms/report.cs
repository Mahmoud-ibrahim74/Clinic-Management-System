using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;



namespace cms
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
            label3.Visible = false;
            date.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToShortTimeString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {


            if (getUsername.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select username First !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(message.Text))
            {
                MessageBox.Show("Please Fill out Your  Message", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string image = label3.Text;
                    Bitmap bmp = new Bitmap(image);
                    FileStream file = new FileStream(image, FileMode.Open, FileAccess.Read);
                    byte[] byteImage = new byte[file.Length];
                    file.Read(byteImage, 0, Convert.ToInt32(file.Length));
                    file.Close();

                    SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into support (message,fromEmail,username,dateReport,uploadImage) Values (N'" + message.Text + "',@e,@user,@date,@up)", con);
                    cmd.Parameters.AddWithValue("@e", from.Text);
                    cmd.Parameters.AddWithValue("@user", getUsername.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@date", date.Text);
                    cmd.Parameters.AddWithValue("@up", SqlDbType.Image).Value = byteImage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your report has been sent to Developer Please wait for  response ......  :) ");
                    reset();

                }
                catch (SmtpException ex)
                {
                    MessageBox.Show(ex.Message + "  Please Check your connection", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Open.ShowDialog();
            Open.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            label3.Text = Open.FileName;
            label3.Visible = true;
            if (Open.FileName != "openFileDialog1")
            {
                pictureBox.Image = new Bitmap(Open.FileName);
            }
        }

        private void report_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=tcp:mahmoud74.database.windows.net,1433;Initial Catalog=cms;Persist Security Info=False;User ID=mahmoud.ibrhim.net;Password=m01207443941I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select username from receptionist",con);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                getUsername.Items.Add(rd[0].ToString());
            }
        }
        private void reset()
        {
            getUsername.SelectedIndex = -1;
            label3.Text = "";
            message.Text = "";
            pictureBox.Image = null;



        }


    }

    

}
