using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Army_Vechical_Entry
{
    public partial class recipet_form : Form
    {
        int Id;
        public recipet_form(int ID)
        {
            InitializeComponent();
            Id = ID;
        }

        private void recipet_form_Load(object sender, EventArgs e)
        {
            this.Report_QueryTableAdapter.Connection = new SqlConnection(SqlHelper.Global_Connection_String);
            this.Report_QueryTableAdapter.Fill(this.Vehical_Entry_RecordDataSet.Report_Query,Id);
            reportViewer1.RefreshReport();
        }
    }
}
