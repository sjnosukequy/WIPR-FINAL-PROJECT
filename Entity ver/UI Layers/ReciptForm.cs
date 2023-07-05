using ADO_ver.Data_Layers;
using Microsoft.Reporting.WinForms;
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
    public partial class ReciptForm : Form
    {
        BLCart carts = new BLCart();
        public ReciptForm()
        {
            InitializeComponent();
        }

        private void ReciptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dIENTUDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dIENTUDataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dIENTUDataSet1.GioHang' table. You can move, or remove it, as needed.
            this.gioHangTableAdapter.Fill(this.dIENTUDataSet1.GioHang);
            // TODO: This line of code loads data into the 'dIENTUDataSet.GioHang' table. You can move, or remove it, as needed.
            this.gioHangTableAdapter.Fill(this.dIENTUDataSet.GioHang);

            this.reportViewer1.RefreshReport();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("User", MainForm.User));
            reportParameters.Add(new ReportParameter("Name", MainForm.UserName));
            reportParameters.Add(new ReportParameter("Addr", MainForm.Addr));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

        private void TTButt_Click(object sender, EventArgs e)
        {
            if (carts.Del(MainForm.User))
            {
                MessageBox.Show("Purchase success!!");
                this.Dispose();
            }
            else
                MessageBox.Show("Cannot buy");
        }
    }
}
