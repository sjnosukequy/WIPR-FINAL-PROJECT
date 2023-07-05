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
using ADO_ver.Data_Layers;
using ADO_ver.UI_Layers;

namespace ADO_ver
{
    public partial class MainForm : Form
    {

        //LOGIN
        public static bool ENALOG = false;
        public static bool IsLog = false;
        //SIGNIN
        public static bool ENASIG = false;
        //CART
        public static bool ENACART = false;
        //EDIT
        public static bool ENAEDIT = false;
        //HELP
        public static bool ENAHELP = false;
        //ABOUT
        public static bool ENAABOUT = false;
        //PRODUCT EDIT
        public static bool ENAEDITPRO = false;
        //INFO
        private static bool ENAINFO = false;
        private int INFOCOUNT = 0;

        //USER
        public static string UserName;
        public static string User;
        public static bool IsAdmin;
        public static string Addr;

        //DATA
        private BLSP Querry = new BLSP();
        private BLCart Cart = new BLCart();
        private BLHelp helps = new BLHelp();

        //MAIN
        public MainForm()
        {
            InitializeComponent();
            SETUP();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Querry.ShowALL(DataGrid);
            int b = DataGrid.Columns.Count;
            DataGrid.Columns.Insert(b, Buy);
            AutoSizeGRID();
            this.DataGrid.Columns["GiaTien"].DefaultCellStyle.Format = "0#,0 VND";
            this.DataGrid.Columns["GiamGia"].DefaultCellStyle.Format = "0.#'%'";
        }
        private void SETUP()
        {
            Addr = "";
            this.SIGNBUTT.Visible = false;
            this.CartBUTT.Visible = false;
            this.EDITBUTT.Visible = false;
            this.Edit2BUTT.Visible = false;
            this.ToolSIGNBUTT.Visible = true;
            this.ToolLOGINBUTT.Visible = true;
            this.HelpBUTT.Visible = false;
            this.LoginBUTT.Text = "Login";
            this.LoginBUTT.DisplayStyle = ToolStripItemDisplayStyle.Text;
            User = "";
            UserName = "";
            Addr = "";
            IsAdmin = false;
        }

        //DATAGRID
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGrid.Columns["Buy"].Index)
            {
                if (IsLog == false)
                    MessageBox.Show("Please Login First");
            }
        }
        private void DataGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == DataGrid.Columns["Buy"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 18;
                var h = 18;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.shopping_cart, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }
        private void AutoSizeGRID()
        {
                DataGrid.Columns[DataGrid.Columns["SLKho"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGrid.Columns[DataGrid.Columns["GiamGia"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGrid.Columns[DataGrid.Columns["GiaTien"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGrid.Columns[DataGrid.Columns["Loai"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGrid.Columns[DataGrid.Columns["NhaSX"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGrid.Columns[DataGrid.Columns["MaSP"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGrid.Columns[DataGrid.Columns["Buy"].Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        //USERMENU
        private void LOGIN_Click(object sender, EventArgs e)
        {
            ENALOG = true;
        }
        private void SIGNUP_Click(object sender, EventArgs e)
        {
            ENASIG = true;
        }
        private void SIGNOUT_Click(object sender, EventArgs e)
        {
            IsLog = false;
            SETUP();
        }
        private void CartBUTT_Click(object sender, EventArgs e)
        {
            ENACART = true;
        }
        private void EDITBUTT_Click(object sender, EventArgs e)
        {
            ENAEDIT = true;
        }
        private void AboutBUTT_Click(object sender, EventArgs e)
        {
            ENAABOUT = true;
        }
        private void HelpBUTT_Click(object sender, EventArgs e)
        {
            ENAHELP = true;
        }
        private void Edit2BUTT_Click(object sender, EventArgs e)
        {
            ENAEDITPRO = true;
        }

        //TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsLog)
            {
                this.CartBUTT.Visible = true;
                this.SIGNBUTT.Visible = true;
                this.EDITBUTT.Visible = true;
                this.ToolSIGNBUTT.Visible = false;
                this.ToolLOGINBUTT.Visible = false;
                this.HelpBUTT.Visible = true;
                this.LoginBUTT.Text = UserName;
                this.LoginBUTT.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            if (ENALOG)
            {
                ENALOG = false;
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
            if(ENASIG)
            {
                ENASIG = false;
                SignForm form = new SignForm();
                form.ShowDialog();
            }
            if(ENACART)
            {
                ENACART = false;
                if (!IsAdmin)
                {
                    CartForm form = new CartForm();
                    form.ShowDialog();
                }
                else
                {
                    CartForm2 form = new CartForm2();
                    form.ShowDialog();
                }
            }
            if(ENAEDIT)
            {
                ENAEDIT = false;
                UserForm form = new UserForm();
                form.ShowDialog();
            }
            if(ENAHELP)
            {
                ENAHELP = false;
                if (IsAdmin)
                {
                    Help2Form form = new Help2Form();
                    form.ShowDialog();
                }
                else
                {
                    HelpForm form = new HelpForm();
                    form.ShowDialog();
                }
            }
            if(ENAABOUT)
            {
                ENAABOUT = false;
                AboutFrom form = new AboutFrom();
                form.ShowDialog();
            }
            if(IsAdmin)
            {
                this.Edit2BUTT.Visible = true;
            }
            if(ENAEDITPRO)
            {
                ENAEDITPRO = false;
                EditProForm form = new EditProForm();
                form.ShowDialog();
                Querry.ShowALL(DataGrid);
            }
            if(ENAINFO)
            {
                this.Infolabel.Visible = true;
                INFOCOUNT += 100;
                if(INFOCOUNT == 2000)
                {
                    INFOCOUNT = 0;
                    ENAINFO = false;
                    this.Infolabel.Visible = false;
                }
            }
        }


        //BUY CLICK
        private void Buy_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (IsLog && !IsAdmin)
            {
                var grid = (DataGridView)sender;
                if (e.RowIndex < 0)
                {
                    //They clicked the header column, do nothing
                    return;
                }
                if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                {
                    int a = Int32.Parse(grid.Rows[e.RowIndex].Cells["MaSP"].Value.ToString());
                    if (Cart.ADD(MainForm.User, a))
                    {
                        ENAINFO = true;
                        INFOCOUNT = 0;
                    }
                    else
                        MessageBox.Show("OUT OF STOCK");
                }
            }
            else if (IsLog && IsAdmin)
                MessageBox.Show("ADMIN CANNOT BUY");
        }

        //MENUBUTTONS
        private void LapMenuItem_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(DataGrid, this.LaptopBUTT.Text);
        }

        private void MenuBUTT_Click(object sender, EventArgs e)
        {
            Querry.ShowALL(DataGrid);
        }

        private void RamBUTT_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(DataGrid, this.RamBUTT.Text);
        }

        private void MouseBUTT_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(DataGrid, this.MouseBUTT.Text);
        }

        private void phoneTabletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(DataGrid, "Phone' or Loai = 'Ipad");
        }

        private void speakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(DataGrid, "Speaker' or Loai = 'Headphone");
        }

        private void tiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(DataGrid, "Television");
        }

        private void mISCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(DataGrid, "USB' or Loai = 'Case' or Loai = 'Touchpen");
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.SearchBox.Text))
            {
                Querry.ShowALL(DataGrid);
            }
            else
            {
                Querry.FindSP(DataGrid,this.SearchBox.Text);
            }
        }
    }
}
