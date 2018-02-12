using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeExcel = Microsoft.Office.Interop.Excel;

namespace Army_Vechical_Entry
{
    public partial class TripSheet_Voc_datetime : Form
    {
        SqlConnection con;
        public TripSheet_Voc_datetime()
        {
            InitializeComponent();
            con = new SqlConnection(SqlHelper.Global_Connection_String);
        }

        DataTable dt1 = new DataTable();
            
        private void button1_Click(object sender, EventArgs e)
        {
            from = dateTimePicker1.Value.Date;
            to =dateTimePicker2.Value.Date;
            
            dataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand("search_vou_date",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("FROM", SqlDbType.DateTime).Value = from.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("TO", SqlDbType.DateTime).Value = to.ToString("yyyy-MM-dd");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        DateTime from;
        DateTime to;

        DataTable dt;     
        int vehical_id_temp = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (dataGridView1.CurrentRow == null)
                return;
            vehical_id_temp = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("select name,CNIC from tbl_passengers where vehical_id = " + vehical_id_temp + "", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           // Report_TripSheet_Voc_datetime frm = new Report_TripSheet_Voc_datetime(to, from);
          //  frm.Show();
        }

               DataSet dsData = new DataSet();
         
        private void button2_Click(object sender, EventArgs e)
        {
               SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Excel Reports|*.xlsx|All Files (*.*)|*.*"; 
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dsData.Tables.Add(dt1);
                ExportDataSetToExcel(dsData, saveFileDialog1.FileName);  
            } 
         
        }


        
        private void ExportDataSetToExcel(DataSet ds, string strPath)
        {
            int inHeaderLength = 3, inColumn = 0, inRow = 0;
            System.Reflection.Missing Default = System.Reflection.Missing.Value;
            //Create Excel File
        //    strPath +=  DateTime.Now.ToString().Replace(':', '-') + ".xlsx";
            OfficeExcel.Application excelApp = new OfficeExcel.Application();
            OfficeExcel.Workbook excelWorkBook = excelApp.Workbooks.Add(1);
            foreach (DataTable dtbl in ds.Tables)
            {
                //Create Excel WorkSheet
                OfficeExcel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add(Default, excelWorkBook.Sheets[excelWorkBook.Sheets.Count], 1, Default);
                excelWorkSheet.Name = dtbl.TableName;//Name worksheet

                //Write Column Name
                for (int i = 0; i < dtbl.Columns.Count; i++)
                    excelWorkSheet.Cells[inHeaderLength + 1, i + 1] = dtbl.Columns[i].ColumnName.ToUpper();

                //Write Rows
                for (int m = 0; m < dtbl.Rows.Count; m++)
                {
                    for (int n = 0; n < dtbl.Columns.Count; n++)
                    {
                        inColumn = n + 1;
                        inRow = inHeaderLength + 2 + m;
                        excelWorkSheet.Cells[inRow, inColumn] = dtbl.Rows[m].ItemArray[n].ToString();
                        if (m % 2 == 0)
                            excelWorkSheet.get_Range("A" + inRow.ToString(), "G" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");
                    }
                }

                //Excel Header
                OfficeExcel.Range cellRang = excelWorkSheet.get_Range("A1", "I3");
                cellRang.Merge(false);
                cellRang.Interior.Color = System.Drawing.Color.White;
                cellRang.Font.Color = System.Drawing.Color.Gray;
                cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
                cellRang.VerticalAlignment = OfficeExcel.XlVAlign.xlVAlignCenter;
                cellRang.Font.Size = 26;
                excelWorkSheet.Cells[1, 1] = "Picquet Move Control System";

                //Style table column names
                cellRang = excelWorkSheet.get_Range("A4","I4");
                cellRang.Font.Bold = true;
                cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#ED7D31");
                excelWorkSheet.get_Range("F4").EntireColumn.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignRight;
                //Formate price column
                excelWorkSheet.get_Range("F5").EntireColumn.NumberFormat = "0.00";
                //Auto fit columns
                excelWorkSheet.Columns.AutoFit();
            }

            //Delete First Page
            excelApp.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Worksheet lastWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.Worksheets[1];
            lastWorkSheet.Delete();
            excelApp.DisplayAlerts = true;

            //Set Defualt Page
            (excelWorkBook.Sheets[1] as OfficeExcel._Worksheet).Activate();

            excelWorkBook.SaveAs(strPath, Default, Default, Default, false, Default, OfficeExcel.XlSaveAsAccessMode.xlNoChange, Default, Default, Default, Default, Default);
            excelWorkBook.Close();
            excelApp.Quit();

            MessageBox.Show("Excel generated successfully \n As "+strPath);
        }
        
    }
}