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
    public partial class UserForm : Form
    {
        BLUser Users = new BLUser();
        DataSet Data = new DataSet();
        public UserForm()
        {
            InitializeComponent();
            Data = Users.Show();
            SetUp();
            ENABUTT(false);
        }
        private void SetUp()
        {
            this.FNameBox.Text = Data.Tables[0].Rows[0]["Ho_Ten"].ToString();
            this.UNameBox.Text = Data.Tables[0].Rows[0]["User_Name"].ToString();
            this.PassBox.Text = Data.Tables[0].Rows[0]["Password"].ToString();
            this.AddrBox.Text = Data.Tables[0].Rows[0]["Dia_Chi"].ToString();
        }
        private void ENABUTT(bool flag)
        {
            this.FNameBox.Enabled = flag;
            this.UNameBox.Enabled = false;
            this.PassBox.Enabled = flag;
            this.AddrBox.Enabled = flag;
        }

        private void EditBUTT_Click(object sender, EventArgs e)
        {
            ENABUTT(true);
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void SaveBUTT_Click(object sender, EventArgs e)
        {
            if (this.FNameBox.Enabled)
            {
                if (string.IsNullOrEmpty(this.FNameBox.Text) || string.IsNullOrEmpty(this.PassBox.Text))
                {
                    MessageBox.Show("The Name or Password cannot be left empty!");
                }
                else
                {
                    if (Users.Check(this.UNameBox.Text, this.PassBox.Text, this.FNameBox.Text, this.AddrBox.Text))
                    {
                        Users.Update(ref MainForm.User, ref MainForm.UserName, ref MainForm.Addr, this.FNameBox.Text, this.PassBox.Text, this.AddrBox.Text);
                        MessageBox.Show("Update successfully");
                        ENABUTT(false);
                    }
                    else
                        MessageBox.Show("Nothing has been changed");
                }
            }
        }
    }
}
