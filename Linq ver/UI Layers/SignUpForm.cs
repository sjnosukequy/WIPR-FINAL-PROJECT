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
    public partial class SignForm : Form
    {
        BLLogin Login = new BLLogin();
        string User;
        string Password;
        string Name;
        string Addr;
        public SignForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MainForm.ENALOG = true;
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
            Name = this.NameBox.Text;
            Addr = this.AddBox.Text;
            if (Login.Check(User) == true)
            {
                MessageBox.Show("The account already exist");
                return;
            }
            if (Login.ADD(User,Password,Name,Addr) == false)
                MessageBox.Show("Fill in the missing fields");
            else
            {
                MainForm.User = User;
                MainForm.UserName = Name;
                MainForm.Addr = Addr;
                MainForm.IsAdmin = false;
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

        private void NameBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Check();
        }

        private void AddBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Check();
        }
    }
}
