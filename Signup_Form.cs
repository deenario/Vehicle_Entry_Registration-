using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Army_Vechical_Entry
{
    public partial class Signup_Form : Form
    {
        SqlConnection con;
        public Signup_Form()
        {
            InitializeComponent();
            con = new SqlConnection(SqlHelper.Global_Connection_String);
        }

        string password = "";
        bool _check()
        {
            if (txtbox_password.Text == txtbox_repassword.Text)
            {
                password = txtbox_password.Text;
                SqlCommand cmd = new SqlCommand("username_check",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username",SqlDbType.VarChar).Value = txtbox_username.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                SqlCommand cmd2 = new SqlCommand("pakno_check", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("@pakno", SqlDbType.VarChar).Value = txtbox_pakno.Text;
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username Already Exsists");
                    return false;
                }
                else if (dt2.Rows.Count > 0)
                {
                    MessageBox.Show("PakNo Account Already Created");
                    return false;
                }
                else
                {
                    return true;
                }

            }
            
            else
            {
                MessageBox.Show("Passwords Do Not Match");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_check())
                {
                    using (SqlCommand cmd = new SqlCommand("insert_user", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtbox_name.Text;
                        cmd.Parameters.Add("@rank", SqlDbType.VarChar).Value = txtbox_Rank.Text;
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtbox_username.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = comboBox1.Text;
                        cmd.Parameters.Add("@pakno", SqlDbType.VarChar).Value = txtbox_pakno.Text;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful");
                    }
                }
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
        

        private void Signup_Form_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Normal User");
        }

    }
}
