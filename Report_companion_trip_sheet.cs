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
    public partial class Report_companion_trip_sheet : Form
    {
        string a_CNIC;
        string b_CNIC;
        public Report_companion_trip_sheet(string A_CNIC,string B_CNIC)
        {
            InitializeComponent();
            a_CNIC = A_CNIC;
            b_CNIC = B_CNIC;
        }

        private void Report_companion_trip_sheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Vehical_Entry_RecordDataSet6.Search_companions' table. You can move, or remove it, as needed.
            this.Search_companionsTableAdapter.Connection = new SqlConnection(SqlHelper.Global_Connection_String);
            this.Search_companionsTableAdapter.Fill(this.Vehical_Entry_RecordDataSet6.Search_companions,a_CNIC,b_CNIC);

            this.reportViewer1.RefreshReport();
        }
    }
}
