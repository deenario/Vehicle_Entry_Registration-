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
    public partial class Passenger_Entry_Only : Form
    {
        SqlConnection con;
        public Passenger_Entry_Only()
        {
            InitializeComponent();
            con = new SqlConnection(SqlHelper.Global_Connection_String);
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

        int i = 0;
        int no__of_passengers;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (i != 0)
                {
                    con.Open();
                    for (int j = 0; j < i; j++)
                    {
                        SqlCommand cmd3 = new SqlCommand("Insert_Passengers", con);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.Add("@name", SqlDbType.VarChar).Value = listView1.Items[j].SubItems[0].Text;
                        cmd3.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = listView1.Items[j].SubItems[1].Text;
                        cmd3.Parameters.Add("@vehical_id", SqlDbType.Int).Value = vehical_id_temp;
                        cmd3.ExecuteNonQuery();
                    }
                        SqlCommand cmd = new SqlCommand("No_Of_Passengers",con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("Vehical_id", SqlDbType.Int).Value = vehical_id_temp;
                        SqlDataAdapter ds = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ds.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                           no__of_passengers  = int.Parse(dr[0].ToString());
                        }

                        no__of_passengers = no__of_passengers + i;

                        SqlCommand cmd1 = new SqlCommand("update_passengers",con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add("No_Of_passengers", SqlDbType.Int).Value = no__of_passengers;
                        cmd1.Parameters.Add("vehical_id",SqlDbType.Int).Value = vehical_id_temp;
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Record Saved");
                    con.Close();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(""+x);
            }
        }
        DataTable dt = new DataTable();
        
        int vehical_id_temp = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dt.Clone();
            if (dataGridView1.CurrentRow == null)
                return;
            var currentRow = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
            ((DataTable)dataGridView2.DataSource).ImportRow(currentRow);


            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                vehical_id_temp = int.Parse(r.Cells[0].Value.ToString());
                break;
            }

            SqlCommand cmd = new SqlCommand("No_Of_Passengers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Vehical_id", SqlDbType.Int).Value = vehical_id_temp;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            ds.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                no__of_passengers = int.Parse(dr[0].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            ListViewItem lv = new ListViewItem();
            lv.Text = txt_PNAME.Text;
            lv.SubItems.Add(txt_PCNIC.Text);
            listView1.Items.Add(lv);
            txt_PNAME.ResetText();
            txt_PCNIC.ResetText();
            txt_PNAME.Focus();
        }


        private void txt_veh_search_TextChanged_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("search_vehical", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("veh_Reg", SqlDbType.VarChar).Value = txt_veh_search.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt.Clone();

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
                txt_PNAME.ResetText();
                txt_PCNIC.ResetText();
                txt_PNAME.Focus();
            }
        }

        private void listView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    listViewItem.Remove();
                    i--;
                }
            }
        }


        private void Passenger_Entry_Only_Load(object sender, EventArgs e)
        {
            }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Current Passengers Added are " + no__of_passengers.ToString() + ".\n Are you sure these are all the Passengers Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                recipet_form frm = new recipet_form(Convert.ToInt32(vehical_id_temp));
                frm.Show();
            }
            else
            {

            }
        }

    }
}