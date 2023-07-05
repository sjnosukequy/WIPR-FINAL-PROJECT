using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADO_ver.Connection;
using ADO_ver.UI_Layers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ADO_ver.Data_Layers
{
    public class BLCart
    {
        string err;
        public BLCart()
        {

        }
        public void Show(DataGridView DataGrid)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select B.MaSP, A.TenSP, B.SL, B.SumALL from SanPham A inner join GioHang B on A.MaSP = B.MaSP where B.UserName = '" + MainForm.User + "'", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
        public void ShowND(DataGridView DataGrid)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select A.UserName,A.MaSP,B.TenSP,A.SL,A.SumAll from GioHang A inner join SanPham B on A.MaSP = B.MaSP", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
        public void ShowND(DataGridView DataGrid, string name)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet($"select A.UserName,A.MaSP,B.TenSP,A.SL,A.SumAll from GioHang A inner join SanPham B on A.MaSP = B.MaSP where A.UserName like '%{name}%' ", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
        public bool ADD(string User, int IDSP)
        {
            DBMain db = new DBMain();
            string sql;
            if (Check(User, IDSP))
            {
                sql = "update GioHang set SL = SL + 1 where UserName = '" + User + "' and MaSP = " + IDSP;
            }
            else
            {
                sql = "insert into GioHang(UserName, MaSP, SL) values('" + User + "'," + IDSP +", 1)";
            }
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool Minus(string User, int IDSP)
        {
            DBMain db = new DBMain();
            string sql;
            sql = "update GioHang set SL = SL - 1 where UserName = '" + User + "' and MaSP = " + IDSP;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool Rem(string User, int IDSP)
        {
            DBMain db = new DBMain();
            string sql;
            sql = "Delete from GioHang where UserName = '" + User + "' and MaSP = " + IDSP;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool Check(string User, int IDSP)
        {

            if (string.IsNullOrEmpty(User))
                return false;
            string sql = "select * from GioHang where UserName = '" + User + "' and MaSP = '" + IDSP + "'";
            DBMain db = new DBMain();
            DataSet a = new DataSet();
            try
            {
                a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            }
            catch
            {
            }
            if (a.Tables.Count == 0)
                return false;
            if (a.Tables[0].Rows.Count != 1)
                return false;
            return true;
        }
        public string Sum()
        {
            DBMain db = new DBMain();
            string sql = "select sum(SumAll) from GioHang where UserName = '" + MainForm.User + "'";
            DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (string.IsNullOrEmpty(a.Tables[0].Rows[0][0].ToString()))
                return "0";
            return a.Tables[0].Rows[0][0].ToString();
        }
        public bool Del (string User)
        {

            DBMain db = new DBMain();
            string sql;
            sql = $"delete from GioHang where UserName = '{User}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}
