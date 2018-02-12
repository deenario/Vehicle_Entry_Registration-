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

namespace Army_Vechical_Entry
{
    public partial class Alone__Person_Entry : Form
    {
        SqlConnection con;

        public Alone__Person_Entry()
        {
            InitializeComponent();
            con = new SqlConnection(SqlHelper.Global_Connection_String);
    
        }

        int person_id = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert_Person", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Per_NAME", SqlDbType.VarChar).Value = txt_PNAME.Text;
                cmd.Parameters.Add("Per_CNIC", SqlDbType.VarChar).Value = txt_PCNIC.Text;
                cmd.Parameters.Add("Per_DATE", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                cmd.Parameters.Add("location", SqlDbType.VarChar).Value = SqlHelper.Global_Location_String;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Stored. Generating Receipt");

                SqlCommand cmd1 = new SqlCommand("select max(person_id) from tbl_person", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
               {
                   person_id = int.Parse(dr[0].ToString());
               }

                Individual_report_form frm = new Individual_report_form(person_id);
                frm.Show();


            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void Alone__Person_Entry_Load(object sender, EventArgs e)
        {

        }
    }
}
