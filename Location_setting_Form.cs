using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Army_Vechical_Entry
{
    public partial class Location_setting_Form : Form
    {
        public Location_setting_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"..\loc.txt", textBox1.Text);
            MessageBox.Show("Location Save To " + textBox1.Text);
            MessageBox.Show("Restart Software To Take Effect");
        }
    }
}
