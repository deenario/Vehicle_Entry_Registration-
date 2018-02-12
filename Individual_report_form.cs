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
    public partial class Individual_report_form : Form
    {
        int id;
        public Individual_report_form(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void Individual_report_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Vehical_Entry_RecordDataSet5.Search_Person' table. You can move, or remove it, as needed.
            this.Search_PersonTableAdapter.Connection = new SqlConnection(SqlHelper.Global_Connection_String);
            this.Search_PersonTableAdapter.Fill(this.Vehical_Entry_RecordDataSet5.Search_Person,id);

            this.reportViewer1.RefreshReport();
        }
    }
}
