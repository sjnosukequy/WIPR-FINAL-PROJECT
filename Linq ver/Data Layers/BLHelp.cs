using ADO_ver.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Xml.Linq;

namespace ADO_ver.Data_Layers
{
    public class BLHelp
    {
        public BLHelp()
        {

        }
        public bool Summit(string LinhVuc, string Info)
        {
            DienTuDataContext Data = new DienTuDataContext();
            Connection.Help hp = new Connection.Help();
            hp.UserName = MainForm.User;
            hp.LinhVuc = LinhVuc;
            hp.INFO = Info;
            try
            {
                Data.Helps.InsertOnSubmit(hp);
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Show(DataGridView DataGrid)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.Helps select new { x.UserName,x.LinhVuc,x.INFO }).ToList();
            DataGrid.DataSource = querry;
        }
        public void ShowNV(DataGridView DataGrid)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.NhanViens select new { x.MaNV, x.TenNV, x.SDT, x.Roles }).ToList();
            DataGrid.DataSource = querry;
        }
    }
}
