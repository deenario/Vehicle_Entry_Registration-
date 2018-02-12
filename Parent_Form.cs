using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Army_Vechical_Entry
{
    public partial class Parent_Form : Form
    {
        SqlConnection con;
        public Parent_Form()
        {
            InitializeComponent();
        }

        private void Parent_Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(@"..\loc.txt"))
                {
                    File.Create(@"..\loc.txt");
                    SqlHelper.Global_Location_String = File.ReadAllText(@"..\loc.txt");
                }
                else if (File.Exists(@"..\loc.txt"))
                {
                    SqlHelper.Global_Location_String = File.ReadAllText(@"..\loc.txt");
                }
              
                if (!File.Exists(@"..\constr.txt"))
                {
                    File.Create(@"..\constr.txt");
                    SqlHelper.Global_Connection_String = File.ReadAllText(@"..\constr.txt");
                }
                else if (File.Exists(@"..\constr.txt"))
                {
                    SqlHelper.Global_Connection_String = File.ReadAllText(@"..\constr.txt");
                }
                
                
                if (SqlHelper.Global_Connection_String == "")
                {
                    Connection__String_from frm = new Connection__String_from();
                    frm.MdiParent = this;
                    frm.Show();
                    groupBox1.Hide();
                }
                
                
                if (SqlHelper.Global_Location_String == "")
                {
                    Location_setting_Form frm = new Location_setting_Form();
                    frm.MdiParent = this;
                    frm.Show();
                    groupBox1.Hide();
                }

                entryToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                adminControlsToolStripMenuItem.Visible = false;

                if (SqlHelper.Global_Connection_String != "")
                {
                    try
                    {
                        SqlHelper helper = new SqlHelper(SqlHelper.Global_Connection_String);
                        
                        if (helper.IsConnect)
                        {
                            con = new SqlConnection(SqlHelper.Global_Connection_String);
                            AppSettings setting = new AppSettings();
                            setting.saveConnectionString("ConnectionString", SqlHelper.Global_Connection_String);
                            var DS1 = new Vehical_Entry_RecordDataSetTableAdapters.Report_QueryTableAdapter();
                            DS1.Connection.ConnectionString = SqlHelper.Global_Connection_String;

                            SqlCommand cmd = new SqlCommand("Count_Vehical",con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dty = new DataTable();
                            da.Fill(dty);
                            label6.Text = dty.Rows.Count.ToString();
                        }

                        else
                        {
                            Connection__String_from frm = new Connection__String_from();
                            frm.MdiParent = this;
                            frm.Show();
                            groupBox1.Hide();
                        }

                    }
                    catch (Exception ex)
                    {
                        groupBox1.Hide();
                        MessageBox.Show("Connection Error");

                        MessageBox.Show(ex.Message);

 
                    }
                }
            }
            catch(Exception)
            {
                groupBox1.Hide();
                MessageBox.Show("Software Updated Its Environment On New PC. Please Restart Again");
            }
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Vehical_Entry frm = new Vehical_Entry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vehicalEntryOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Vehical_Entry_Only frm = new Vehical_Entry_Only();
            frm.MdiParent = this;
            frm.Show();
        }

        private void passengerEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Passenger_Entry_Only frm = new Passenger_Entry_Only();
            frm.MdiParent = this;
            frm.Show();
        }

        private void personEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Alone__Person_Entry frm = new Alone__Person_Entry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void personSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Alone_Person_search frm = new Alone_Person_search();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tripSheetPassengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Trip_sheet_passenger frm = new Trip_sheet_passenger();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tripSheetVehicalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            trip_sheet_Vehical frm = new trip_sheet_Vehical();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tripSheetVehicalsSpecificDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            TripSheet_Voc_datetime frm = new TripSheet_Voc_datetime();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tripSheetVouchersGeneratedByOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            TripSheet_Vou_OP frm = new TripSheet_Vou_OP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vouchersGeneratedOnThisLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Total_vouchers_on_LOC frm = new Total_vouchers_on_LOC();
            frm.MdiParent = this;
            frm.Show();
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void createNewAccountsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }
            Signup_Form frm = new Signup_Form();
            frm.MdiParent = this;
            frm.Show();
        }

        string type = "";
        string User_Name = "";
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("User_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtbox_username.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtbox_password.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    global_user_id.GlobalVar = int.Parse(dr[0].ToString());
                    type = dr[5].ToString();
                    User_Name = dr[1].ToString();
                }

                if (dt.Rows.Count > 0)
                {
                    if (type == "Admin")
                    {
                        entryToolStripMenuItem.Visible = true;
                        reportsToolStripMenuItem.Visible = true;
                        adminControlsToolStripMenuItem.Visible = true;
                        groupBox1.Hide();
                        label5.Text = User_Name;
                    }
                    else if (type == "Normal User")
                    {
                        entryToolStripMenuItem.Visible = true;
                        reportsToolStripMenuItem.Visible = false;
                        adminControlsToolStripMenuItem.Visible = false;
                        groupBox1.Hide();
                        label5.Text = User_Name;
                    }
                    else
                    {
                        MessageBox.Show("Your User Type is not defined \n Kindly Contact Administrator");
                    }
                }

                else
                {
                    MessageBox.Show("Username Or Password is incorrect");
                }

            }

            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }

            finally
            {
                txtbox_username.ResetText();
                txtbox_password.ResetText();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }

            groupBox1.Show();
            label5.Text = "";
            global_user_id.GlobalVar = 0;
            User_Name = "";

        }

        private void databaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection__String_from frm = new Connection__String_from();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vehicalTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Vehical_Types frm = new Add_Vehical_Types();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tripSheetCompanionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            int count = Application.OpenForms.Count;
            for (int i = 0; i < count; i++)
            {
                Form f = Application.OpenForms[i];
                if (f.GetType().Assembly == currentAssembly && f.Name != "Parent_Form") //Here 'frmMDI' is the name of mdiform.
                {
                    f.Close();
                }
            }

            Trip_Shee__Of_Companion frm = new Trip_Shee__Of_Companion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Location_setting_Form frm = new Location_setting_Form();
            frm.MdiParent = this;
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
