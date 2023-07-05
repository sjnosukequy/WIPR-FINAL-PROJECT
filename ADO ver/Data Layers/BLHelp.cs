using ADO_ver.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_ver.Data_Layers
{
    public class BLHelp
    {
        string err;
        public BLHelp()
        {

        }
        public bool Summit(string LinhVuc, string Info)
        {
            DBMain db = new DBMain();
            string sql;
            sql = $"insert into Help(UserName,LinhVuc,INFO) values('{MainForm.User}', '{LinhVuc}',N'{Info}')";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public void Show(DataGridView DataGrid)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from Help", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
        public void ShowNV(DataGridView DataGrid)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
    }
}
