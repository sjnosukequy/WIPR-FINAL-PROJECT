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
    public partial class HelpForm : Form
    {
        private BLHelp helps = new BLHelp();
        public HelpForm()
        {
            InitializeComponent();
        }

        private void SummitButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProblemBox.Text) || string.IsNullOrEmpty(this.DeptBox.Text))
                MessageBox.Show("Please fill in the form fully");
            else
            {
                helps.Summit(this.DeptBox.SelectedItem.ToString(), this.ProblemBox.Text);
                MessageBox.Show("We'll review your problems as soon as possible","Thank you for reporting to us!!");
                this.Dispose();
            }
        }
    }
}
