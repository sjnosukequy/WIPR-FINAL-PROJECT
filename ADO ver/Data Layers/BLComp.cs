using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO_ver.Connection;
using System.Data;
using System.Windows.Forms;

namespace ADO_ver.Data_Layers
{
    public class BLComp
    {
        string err;
        public BLComp()
        {

        }
        public void Show(DataGridView DataGrid)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from CungCap", CommandType.Text);
            dtKhachHang = a.Tables[0];
            DataGrid.DataSource = dtKhachHang;
        }
    }
}
