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
    public partial class Vehical_Entry : Form
    {
        SqlConnection con;

        public Vehical_Entry()
        {
            InitializeComponent();
            con = new SqlConnection(SqlHelper.Global_Connection_String);
        }

        int i = 0;
        private void Vehical_Entry_Load(object sender, EventArgs e)
        {
            i = 0;
            listView1.View = View.Details;
            txt_No_of_P.Text = "0";


            SqlCommand cmd2 = new SqlCommand("select * from tbl_vehicaltype", con);
            cmd2.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr[1].ToString());
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            ListViewItem lv = new ListViewItem();
            lv.Text = txt_PNAME.Text;
            lv.SubItems.Add(txt_PCNIC.Text);
            listView1.Items.Add(lv);
            txt_No_of_P.Text = i.ToString();
            txt_PNAME.ResetText();
            txt_PCNIC.ResetText();
            txt_PNAME.Focus();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    listViewItem.Remove();
                    i--;
                    txt_No_of_P.Text = i.ToString();
                }
            }
        }


        int vehical_id_int = 0; 
        string datetime = "";
        string location = SqlHelper.Global_Location_String;
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
                cmd.Parameters.Add("@no_of_passengers", SqlDbType.Int).Value = txt_No_of_P.Text;
                cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = global_user_id.GlobalVar;
                con.Open();
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("Select max(vehical_id) from tbl_vehicals",con);
                cmd2.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                  vehical_id_int =  int.Parse(dr[0].ToString());
                }

                if (i != 0)
                {

                    for (int j = 0; j < i; j++)
                    {
                    SqlCommand cmd3 = new SqlCommand("Insert_Passengers", con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.Add("@name", SqlDbType.VarChar).Value = listView1.Items[j].SubItems[0].Text;
                    cmd3.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = listView1.Items[j].SubItems[1].Text;
                    cmd3.Parameters.Add("@vehical_id", SqlDbType.Int).Value = vehical_id_int;
                    cmd3.ExecuteNonQuery();
                    }

                }
               
                recipet_form rf = new recipet_form(Convert.ToInt32(vehical_id_int));
                rf.Show();
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


        private void txt_driver_CNIC_Leave(object sender, EventArgs e)
        {
            if (txt_driver_CNIC.Text.Length == 0)
            {

            }
            else if (txt_driver_CNIC.Text.Length != 13)
            {
                MessageBox.Show("Enter A Valid 14 Digit CNIC NUMBER");
                txt_driver_CNIC.Focus();
            }
        }

        private void txt_PCNIC_Leave(object sender, EventArgs e)
        {
            if (txt_PCNIC.Text.Length == 0)
            {
 
            }
            else if (txt_PCNIC.Text.Length != 13)
            {
                MessageBox.Show("Enter A Valid 12 Digit CNIC NUMBER");
                txt_PCNIC.Focus();
            }
        }

        private void txt_PCNIC_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                i++;
                ListViewItem lv = new ListViewItem();
                lv.Text = txt_PNAME.Text;
                lv.SubItems.Add(txt_PCNIC.Text);
                listView1.Items.Add(lv);
                txt_No_of_P.Text = i.ToString();
                txt_PNAME.ResetText();
                txt_PCNIC.ResetText();
                txt_PNAME.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    
        
    }
}
