using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADO_ver.Connection;
using ADO_ver.UI_Layers;

namespace ADO_ver.Data_Layers
{
    public class BLSP
    {
        string err;
        public BLSP()
        {

        }
        public void ShowALL(DataGridView DataGrid)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from SanPham", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
        public void ShowSP(DataGridView DataGrid, string SP)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet($"select * from SanPham where Loai = '{SP}'", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
        public bool AddSP(string name, string Loai, string Spec, string NhaSX, int SL, int GiaTien, int Giam)
        {
            DBMain db = new DBMain();
            string sql;
            sql = $"insert into SanPham(TenSP, Loai, Spec, NhaSX, SLKho, GiaTien, GiamGia) values(N'{name}','{Loai}',N'{Spec}','{NhaSX}',{SL},{GiaTien},{Giam})";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool Update(int ID,string name, string Loai, string Spec, string NhaSX, int SL, int GiaTien, int Giam)
        {
            DBMain db = new DBMain();
            string sql;
            sql = $"update SanPham set TenSP = N'{name}', Loai = '{Loai}', Spec = N'{Spec}', NhaSX = '{NhaSX}', SLKho = {SL}, GiaTien = {GiaTien}, GiamGia = {Giam} where MaSP = {ID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool Del(int ID)
        {
            DBMain db = new DBMain();
            string sql;
            sql = $"delete from SanPham where MaSP ={ID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public void FindSP(DataGridView DataGrid, string SP)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet($"SELECT * FROM SanPham WHERE TenSP Like '%{SP}%' or Loai Like '%{SP}%' or Spec Like '%{SP}%' or NhaSX Like '%{SP}%'", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
    }
}
