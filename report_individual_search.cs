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
    public partial class report_individual_search : Form
    {
        string cnic = "";
        public report_individual_search(string _cnic)
        {
            InitializeComponent();
            cnic = _cnic;
        }

        private void report_individual_search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Vehical_Entry_RecordDataSet2.Search_Person_CNIC' table. You can move, or remove it, as needed.
            this.Search_Person_CNICTableAdapter.Connection = new SqlConnection(SqlHelper.Global_Connection_String);
            this.Search_Person_CNICTableAdapter.Fill(this.Vehical_Entry_RecordDataSet2.Search_Person_CNIC,cnic);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
