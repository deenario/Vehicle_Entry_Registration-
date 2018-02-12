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
    public partial class Report_Trip_sheet_passenger : Form
    {
        string cnic = "";
        public Report_Trip_sheet_passenger(string _cnic)
        {
            InitializeComponent();
            cnic = _cnic;
        }

        private void Report_Trip_sheet_passenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Vehical_Entry_RecordDataSet3.search_passenger' table. You can move, or remove it, as needed.
            this.search_passengerTableAdapter.Connection = new SqlConnection(SqlHelper.Global_Connection_String);
            this.search_passengerTableAdapter.Fill(this.Vehical_Entry_RecordDataSet3.search_passenger,cnic);
            this.reportViewer1.RefreshReport();
        }
    }
}
