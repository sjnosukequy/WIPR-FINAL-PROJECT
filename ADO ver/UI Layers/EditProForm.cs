using ADO_ver.Data_Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ADO_ver.UI_Layers
{
    public partial class EditProForm : Form
    {
        private BLSP sps = new BLSP();
        private bool flag = false;
        private int RowLoco;
        public EditProForm()
        {
            InitializeComponent();
            this.ADDBUTT.Enabled = false;
            this.UpdateBUTT.Enabled = false;
            this.DelBUTT.Enabled = false;
            sps.ShowALL(dataGridView1);
            this.dataGridView1.Columns["GiaTien"].DefaultCellStyle.Format = "0#,0 VND";
            this.dataGridView1.Columns["GiamGia"].DefaultCellStyle.Format = "0.#'%'";
            dataGridView1.Columns[dataGridView1.Columns["MaSP"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns["Loai"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns["NhaSX"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns["SLKho"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns["GiaTien"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns["GiamGia"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ADDBUTT_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                CLEAR();
                flag = false;
                this.ADDBUTT.Text = "ADD";
                this.UpdateBUTT.Enabled = false;
                this.DelBUTT.Enabled = false;
                this.ADDBUTT.Enabled = false;
            }
            else
            {
                string name = this.TenBox.Text;
                string Loai = this.LoaiBox.Text;
                string spec = this.SpecBox.Text;
                string NhaSX = this.NhaSXBox.Text;
                int SL = Int32.Parse(this.SLBox.Text);
                int Gia = Int32.Parse(this.GiaBox.Text);
                int Giam = Int32.Parse(this.GiamBox.Text);
                if (sps.AddSP(name, Loai, spec, NhaSX, SL, Gia, Giam) && Giam < 70)
                {
                    MessageBox.Show("ADD SUCCESS");
                    sps.ShowALL(dataGridView1);
                }
                else
                    MessageBox.Show("FAIL");
            }
        }
        private void UpdateBUTT_Click(object sender, EventArgs e)
        {
            string name = this.TenBox.Text;
            string Loai = this.LoaiBox.Text;
            string spec = this.SpecBox.Text;
            string NhaSX = this.NhaSXBox.Text;
            int SL = Int32.Parse(this.SLBox.Text);
            int Gia = Int32.Parse(this.GiaBox.Text);
            int Giam = Int32.Parse(this.GiamBox.Text);
            int ID = Int32.Parse(this.dataGridView1[0, RowLoco].Value.ToString());
            if (sps.Update(ID, name, Loai, spec, NhaSX, SL, Gia, Giam) && Giam < 70)
            {
                MessageBox.Show("UPDATE SUCCESS");
                sps.ShowALL(dataGridView1);
            }
            else
                MessageBox.Show("FAIL");
        }
        private void DelBUTT_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(this.dataGridView1[0, RowLoco].Value.ToString());
            if (sps.Del(ID))
            {
                MessageBox.Show("DEL SUCCESS");
                sps.ShowALL(dataGridView1);
            }
            else
                MessageBox.Show("FAIL");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBox1.Text))
            {
                reset();
                RowLoco = -1;
                CLEAR();
                sps.ShowALL(dataGridView1);
            }
            else
            {
                CLEAR();
                reset();
                sps.FindSP(dataGridView1, this.textBox1.Text);
            }
        }
        private void reset()
        {
            this.ADDBUTT.Text = "ADD";
            this.ADDBUTT.Enabled = false;
            this.UpdateBUTT.Enabled = false;
            this.DelBUTT.Enabled = false;
            RowLoco = 0;
            flag = false;
        }
        private void SLBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Check())
                this.ADDBUTT.Enabled = true;
        }
        private bool Check()
        {
            if(string.IsNullOrEmpty(TenBox.Text) || string.IsNullOrEmpty(LoaiBox.Text) || string.IsNullOrEmpty(SpecBox.Text) || string.IsNullOrEmpty(NhaSXBox.Text) || string.IsNullOrEmpty(SLBox.Text) || string.IsNullOrEmpty(GiaBox.Text) || string.IsNullOrEmpty(GiamBox.Text))
                return false;
            return true;
        }
        private void ENABLE(bool flag)
        {
            this.TenBox.Enabled = flag;
            this.LoaiBox.Enabled = flag;
            this.SpecBox.Enabled = flag;
            this.NhaSXBox.Enabled = flag;
            this.SLBox.Enabled = flag;
            this.GiaBox.Enabled = flag;
            this.GiamBox.Enabled = flag;
        }
        private void GET()
        {
            this.TenBox.Text = this.dataGridView1[1, RowLoco].Value.ToString();
            this.LoaiBox.Text = this.dataGridView1[2, RowLoco].Value.ToString();
            this.SpecBox.Text = this.dataGridView1[3, RowLoco].Value.ToString();
            this.NhaSXBox.Text = this.dataGridView1[4, RowLoco].Value.ToString();
            this.SLBox.Text = this.dataGridView1[5, RowLoco].Value.ToString();
            this.GiaBox.Text = this.dataGridView1[6, RowLoco].Value.ToString();
            this.GiamBox.Text = this.dataGridView1[7, RowLoco].Value.ToString();
        }
        private void CLEAR()
        {
            this.TenBox.Clear();
            this.LoaiBox.SelectedIndex = -1;
            this.SpecBox.Clear();
            this.NhaSXBox.SelectedIndex = -1;
            this.SLBox.Clear();
            this.GiaBox.Clear();
            this.GiamBox.Clear();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            RowLoco = e.RowIndex;
            this.UpdateBUTT.Enabled = true;
            this.DelBUTT.Enabled = true;
            this.ADDBUTT.Text = "CANCEL";
            flag = true;
            GET();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RowLoco = e.RowIndex;
            this.UpdateBUTT.Enabled = true;
            this.DelBUTT.Enabled = true;
            this.ADDBUTT.Text = "CANCEL";
            flag = true;
            GET();
        }

        private void CompBUTT_Click(object sender, EventArgs e)
        {
            if (CompanyForm.open)
            {
                MessageBox.Show("Already open");
                return;
            }
            CompanyForm form = new CompanyForm();
            form.Show();
        }
    }
}
