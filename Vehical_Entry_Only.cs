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
    public partial class Vehical_Entry_Only : Form
    {
        SqlConnection con;
        public Vehical_Entry_Only()
        {
            InitializeComponent();
            con = new SqlConnection(SqlHelper.Global_Connection_String);
            SqlCommand cmd2 = new SqlCommand("select * from tbl_vehicaltype", con);
            cmd2.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add( dr[1].ToString());
            }
        }

        string datetime = "";
        string location = SqlHelper.Global_Location_String;
        int passengers = 0;
        int vehical_id_int = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datetime = System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                SqlCommand cmd = new SqlCommand("Insert_Vehical", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = location;
                cmd.Parameters.Add("@date_time", SqlDbType.VarChar).Value = datetime;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = comboBox1.Text;
                cmd.Parameters.Add("@registration_no", SqlDbType.VarChar).Value = txt_VNUMBER.Text;
                cmd.Parameters.Add("@driver_name", SqlDbType.VarChar).Value = txt_driver_name.Text;
                cmd.Parameters.Add("@driver_cnic", SqlDbType.VarChar).Value = txt_driver_CNIC.Text;
                cmd.Parameters.Add("@no_of_passengers", SqlDbType.Int).Value = passengers;
                cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = global_user_id.GlobalVar;
                con.Open();
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("Select max(vehical_id) from tbl_vehicals", con);
                cmd2.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    vehical_id_int = int.Parse(dr[0].ToString());
                }

                SqlCommand cmd3 = new SqlCommand("Insert_Passengers", con);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add("@name", SqlDbType.VarChar).Value = " ";
                cmd3.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = " ";
                cmd3.Parameters.Add("@vehical_id", SqlDbType.Int).Value = vehical_id_int;
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Record Saved");
            }
            
            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }
            
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recipet_form frm = new recipet_form(vehical_id_int);
            frm.Show();
        }

        private void Vehical_Entry_Only_Load(object sender, EventArgs e)
        {

        }
    }
}
