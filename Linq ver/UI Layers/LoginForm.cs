using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO_ver.Connection;
using ADO_ver.Data;

namespace ADO_ver.UI_Layers
{
    public partial class LoginForm : Form
    {
        BLLogin Login = new BLLogin();
        string User;
        string Password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MainForm.ENASIG = true;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();
        }
        private void Check()
        {
            User = this.UserBox.Text;
            Password = this.PassBox.Text;
            if (Login.Check(User, Password,ref MainForm.User,ref MainForm.UserName, ref MainForm.IsAdmin, ref MainForm.Addr) == false)
                MessageBox.Show("Wrong or Not Found");
            else
            {
                MainForm.IsLog = true;
                this.Dispose();
            }
        }
        private void UserBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Check();
        }

        private void PassBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Check();
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            this.PassBox.UseSystemPasswordChar = !this.checkBox.Checked;
        }
    }
}
