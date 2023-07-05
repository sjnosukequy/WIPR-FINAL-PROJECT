using ADO_ver.Data_Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_ver.UI_Layers
{
    public partial class Help2Form : Form
    {
        private BLHelp helps = new BLHelp();
        public Help2Form()
        {
            InitializeComponent();
            helps.Show(this.dataGridView1);
        }

        private void Help2Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
