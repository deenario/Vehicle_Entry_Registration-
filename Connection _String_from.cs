using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Army_Vechical_Entry
{
    public partial class Connection__String_from : Form
    {
        public Connection__String_from()
        {
            InitializeComponent();
        }

        string connectionString= "";
        string datasource = "";
        string databaseName = "";
        string username = "";
        string password = "";
        int i = 0;
        private void Connection__String_from_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                datasource = textBox1.Text;
                databaseName = textBox2.Text;
                username = textBox4.Text;
                password = textBox3.Text;
                connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", datasource, databaseName,username,password);
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnect)
                {
                    MessageBox.Show("Test Connection Success","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    i = 1;
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (connectionString != "")
                {
                    SqlHelper.Global_Connection_String = connectionString;
                    File.WriteAllText(@"..\constr.txt", SqlHelper.Global_Connection_String);
                    MessageBox.Show("Connection Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("You Must Restart The Software For the New Connection To Take Effect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Kindly Store A Succesful Connection");
            }
        }

    }
}