using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace cms
{
    public partial class cc_control : Form
    {
        private string pathDoc = Environment.CurrentDirectory + @"\Sheets"; // get  path for folder Sheets any machine
        private String username;
        public cc_control()
        {
            InitializeComponent();


        }
        public cc_control(String user)
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



        private void back_Click(object sender, EventArgs e)
        {
            new admin_control().Show();
            this.Hide();
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

 
        private void back_Click_2(object sender, EventArgs e)
        {
            new cms().Show();
            this.Hide();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void makeExcel_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathDoc))   // check if Folder Sheets found or not
            {
                Directory.CreateDirectory(pathDoc);  // create folder if isn't exist
            }

            saveExcel.InitialDirectory = pathDoc;
            saveExcel.Title = "Save As Excel File";
            saveExcel.FileName = "Sheet(1)";
            saveExcel.Filter = "Excel files (*.xlsx)|*.xlsx";
            try
            {
                Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;

                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Cells[1, 1] = "Bold";
                worksheet.Name = "Records";
                app.Columns.ColumnWidth = 30;
                app.StandardFont = "Segoe UI Emoji";
                app.StandardFontSize = 15;
                Excel.Range formatRange;
                formatRange = worksheet.get_Range("A1");
                formatRange.EntireRow.Font.Bold = true;
                formatRange.RowHeight = 35;
                formatRange.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;  // to make text align in center


                try
                {
                    for (int i = 0; i < TableB.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = TableB.Columns[i].HeaderText;
                        worksheet.Cells[1, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkMagenta); // background color of first row

                    }
                    for (int i = 0; i < TableB.Rows.Count; i++)
                    {
                        for (int j = 0; j < TableB.Columns.Count; j++)
                        {
                            if (TableB.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = TableB.Rows[i].Cells[j].Value.ToString();

                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    saveExcel.FilterIndex = 2;

                    if (saveExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveExcel.FileName);
                        MessageBox.Show("File Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            openExcel.InitialDirectory = pathDoc;
            openExcel.Filter = "Excel files (*.xlsx)|*.xlsx";
            openExcel.FilterIndex = 2;
            openExcel.Multiselect = false;
            openExcel.Title = "Open Excel File ";
            openExcel.FileName = "Sheet(1)";

            if (openExcel.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string pathconn = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", openExcel.FileName);
                    string FileName = Path.GetFileName(openExcel.FileName);
                    MessageBox.Show(Path.GetFileNameWithoutExtension(FileName));

                    OleDbConnection conn = new OleDbConnection(pathconn);
                    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select * From [" + Path.GetFileNameWithoutExtension(FileName) + "$]", conn);
                    DataTable dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    TableB.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't Open File !! \n\n" + ex.Message + " ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
