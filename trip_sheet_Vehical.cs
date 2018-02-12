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
    public partial class trip_sheet_Vehical : Form
    {
        SqlConnection con;
        public trip_sheet_Vehical()
        {
            InitializeComponent();
            con = new SqlConnection(SqlHelper.Global_Connection_String);
        }

        private void txt_veh_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("search_vehical", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("veh_Reg", SqlDbType.VarChar).Value = txt_veh_search.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        int vehical_id_temp=0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            vehical_id_temp = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            SqlCommand cmd = new SqlCommand("select name,CNIC from tbl_passengers where vehical_id = "+vehical_id_temp+"",con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;

        }

        private void trip_sheet_Vehical_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recipet_form frm = new recipet_form(vehical_id_temp);
            frm.Show();

        }
    }
}