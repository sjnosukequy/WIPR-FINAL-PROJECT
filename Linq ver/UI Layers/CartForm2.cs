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
    public partial class CartForm2 : Form
    {
        private BLCart Cart = new BLCart();
        private int ROWIDX = 0;
        public CartForm2()
        {
            InitializeComponent();
            Cart.ShowND(this.dataGridView1);
            this.dataGridView1.Columns["SumAll"].DefaultCellStyle.Format = "0#,0 VND";
            this.dataGridView1.Columns[this.dataGridView1.Columns["UserName"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView1.Columns[this.dataGridView1.Columns["MaSP"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView1.Columns[this.dataGridView1.Columns["SL"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView1.Columns[this.dataGridView1.Columns["SumAll"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ADDBUT_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(this.dataGridView1.Rows[ROWIDX].Cells["MaSP"].Value.ToString());
            if (Cart.ADD(this.dataGridView1.Rows[ROWIDX].Cells["UserName"].Value.ToString(), a))
            {
                int RowBCK = ROWIDX;
                textBox1_TextChanged(sender, e);
                ROWIDX = RowBCK;
                this.dataGridView1.Rows[ROWIDX].Selected = true;
            }
            else
                MessageBox.Show("OUT OF STOCK");
        }

        private void MinusBUTT_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(this.dataGridView1.Rows[ROWIDX].Cells["MaSP"].Value.ToString());
            int b = Int32.Parse(this.dataGridView1.Rows[ROWIDX].Cells["SL"].Value.ToString());
            if (b == 1)
            {
                Cart.Rem(this.dataGridView1.Rows[ROWIDX].Cells["UserName"].Value.ToString(), a);
                int RowBCK = ROWIDX;
                textBox1_TextChanged(sender, e);
                ROWIDX= RowBCK;
                if (ROWIDX >= this.dataGridView1.Rows.Count)
                    ROWIDX -= 1;
                this.dataGridView1.Rows[ROWIDX].Selected = true;
            }
            else if (Cart.Minus(this.dataGridView1.Rows[ROWIDX].Cells["UserName"].Value.ToString(), a))
            {
                int RowBCK = ROWIDX;
                textBox1_TextChanged(sender, e);
                ROWIDX = RowBCK;
                this.dataGridView1.Rows[ROWIDX].Selected = true;
            }
            else
                MessageBox.Show("BROKEN");
        }

        private void DELBUTT_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(this.dataGridView1.Rows[ROWIDX].Cells["MaSP"].Value.ToString());
            if (Cart.Rem(this.dataGridView1.Rows[ROWIDX].Cells["UserName"].Value.ToString(), a))
            {
                int RowBCK = ROWIDX;
                textBox1_TextChanged(sender, e);
                ROWIDX = RowBCK;
                if (ROWIDX >= this.dataGridView1.Rows.Count)
                    ROWIDX -= 1;
                this.dataGridView1.Rows[ROWIDX].Selected = true;
            }
            else
                MessageBox.Show("BROKEN");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ROWIDX = e.RowIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                Cart.ShowND(this.dataGridView1);
                ROWIDX = 0;
            }
            else
            {
                Cart.ShowND(this.dataGridView1, textBox1.Text);
                ROWIDX = 0;
            }
        }
    }
}
