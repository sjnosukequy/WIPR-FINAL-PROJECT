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
    public partial class AboutFrom : Form
    {
        private BLHelp helps = new BLHelp();
        public AboutFrom()
        {
            InitializeComponent();
            helps.ShowNV(this.dataGridView1);
            this.dataGridView1.Columns[dataGridView1.Columns["MaNV"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView1.Columns[dataGridView1.Columns["SDT"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView1.Columns[dataGridView1.Columns["Roles"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void AboutFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
