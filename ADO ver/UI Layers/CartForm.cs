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
using ADO_ver.Connection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.Reporting.WinForms;

namespace ADO_ver.UI_Layers
{
    public partial class CartForm : Form
    {
        //Adding Subtracting Deleting buttons
        DataGridViewButtonColumn Add = new DataGridViewButtonColumn();
        DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
        DataGridViewButtonColumn Minus = new DataGridViewButtonColumn();
        BLCart Cart = new BLCart();
        BLUser user = new BLUser();
        public CartForm()
        {
            BUTTONSETTINGS();
            InitializeComponent();
            Cart.Show(DataGrid);
            int b = DataGrid.Columns.Count;
            DataGrid.Columns.Insert(b, Delete);
            DataGrid.Columns.Insert(b, Minus);
            DataGrid.Columns.Insert(b, Add);
            AutoSizeGRID();
            this.DataGrid.Columns["SumALL"].DefaultCellStyle.Format = "0#,0 VND";
            this.DiaChiBox.Text = MainForm.Addr;
        }

        private void AutoSizeGRID()
        {
            DataGrid.Columns[DataGrid.Columns["MaSP"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGrid.Columns[DataGrid.Columns["SL"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGrid.Columns[DataGrid.Columns["SumALL"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGrid.Columns[DataGrid.Columns["Add"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGrid.Columns[DataGrid.Columns["Minus"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGrid.Columns[DataGrid.Columns["Delete"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            TotalSum();
        }

        //SETTINGS
        private void BUTTONSETTINGS()
        {
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Minus.Name = "Minus";
            Minus.Text = "Minus";
            Add.Name = "Add";
            Add.Text = "Add";
        }
        private void CartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        //CELL HANDLER
        private void DataGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //I supposed your button column is at index 0
            //ADD
            if (e.ColumnIndex == DataGrid.Columns["Add"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 18;
                var h = 18;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.plus, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            //MINUS
            if (e.ColumnIndex == DataGrid.Columns["Minus"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 18;
                var h = 18;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.minus, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            //DEL
            if (e.ColumnIndex == DataGrid.Columns["Delete"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 18;
                var h = 18;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.bin, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }
            if (e.ColumnIndex == DataGrid.Columns["Add"].Index)
            {
                int a = Int32.Parse(grid.Rows[e.RowIndex].Cells["MaSP"].Value.ToString());
                if (Cart.ADD(MainForm.User, a))
                    Cart.Show(DataGrid);
                else
                    MessageBox.Show("OUT OF STOCK");
            }
            if (e.ColumnIndex == DataGrid.Columns["Minus"].Index)
            {
                int a = Int32.Parse(grid.Rows[e.RowIndex].Cells["MaSP"].Value.ToString());
                int b = Int32.Parse(grid.Rows[e.RowIndex].Cells["SL"].Value.ToString());
                if (b == 1)
                {
                    Cart.Rem(MainForm.User, a);
                    Cart.Show(DataGrid);
                }
                else if (Cart.Minus(MainForm.User, a))
                    Cart.Show(DataGrid);
                else
                    MessageBox.Show("BROKEN");
            }
            if (e.ColumnIndex == DataGrid.Columns["Delete"].Index)
            {
                int a = Int32.Parse(grid.Rows[e.RowIndex].Cells["MaSP"].Value.ToString());
                if (Cart.Rem(MainForm.User, a))
                    Cart.Show(DataGrid);
                else
                    MessageBox.Show("BROKEN");
            }
        }

        //TOTAL SUM
        private void TotalSum()
        {
            this.NameLabel.Text = "Total: "+ string.Format("{0:#,0}", Convert.ToDecimal(Cart.Sum())) + " VND";
        }

        private void CheckOutBUTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.DiaChiBox.Text))
                MessageBox.Show("PLease enter an address in the text box");
            else 
            {
                user.Update(ref MainForm.User, ref MainForm.Addr, this.DiaChiBox.Text);
                ReciptForm recipt = new ReciptForm();
                recipt.ShowDialog();
                Cart.Show(DataGrid);
            }
        }
    }
}
