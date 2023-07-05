using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO_ver.Data_Layers;

namespace ADO_ver.UI_Layers
{
    public partial class CompanyForm : Form
    {
        public static bool open = false;
        private BLComp comps = new BLComp();
        public CompanyForm()
        {
            InitializeComponent();
            open = true;
            comps.Show(this.dataGridView1);
        }

        private void CompanyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            open = false;
            this.Dispose();
        }
    }
}
