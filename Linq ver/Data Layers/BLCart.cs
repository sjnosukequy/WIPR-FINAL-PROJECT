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
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Security.Policy;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

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
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from sp in Data.SanPhams join gh in Data.GioHangs on sp.MaSP equals gh.MaSP where gh.UserName == MainForm.User select new { gh.MaSP, sp.TenSP, gh.SL, gh.SumAll }).ToList();
            DataGrid.DataSource = querry;
        }
        public void ShowND(DataGridView DataGrid)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from sp in Data.SanPhams join gh in Data.GioHangs on sp.MaSP equals gh.MaSP select new { gh.UserName ,gh.MaSP, sp.TenSP, gh.SL, gh.SumAll }).ToList();
            DataGrid.DataSource = querry;
        }
        public void ShowND(DataGridView DataGrid, string name)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from sp in Data.SanPhams join gh in Data.GioHangs on sp.MaSP equals gh.MaSP where gh.UserName.Contains(name) select new { gh.UserName, gh.MaSP, sp.TenSP, gh.SL, gh.SumAll }).ToList();
            DataGrid.DataSource = querry;
        }
        public bool ADD(string User, int IDSP)
        {
            DienTuDataContext Data = new DienTuDataContext();
            if (Check(User, IDSP))
            {
                try
                {
                    GioHang gh = (from x in Data.GioHangs where x.UserName == User && x.MaSP == IDSP select x).SingleOrDefault();
                    gh.SL += 1;
                    Data.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    GioHang gh = new GioHang();
                    gh.UserName = User;
                    gh.MaSP = IDSP;
                    gh.SL = 1;
                    Data.GioHangs.InsertOnSubmit(gh);
                    Data.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool Minus(string User, int IDSP)
        {
            DienTuDataContext Data = new DienTuDataContext();
            try
            {
                GioHang gh = (from x in Data.GioHangs where x.UserName == User && x.MaSP == IDSP select x).SingleOrDefault();
                gh.SL -= 1;
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Rem(string User, int IDSP)
        {
            DienTuDataContext Data = new DienTuDataContext();
            try
            {
                GioHang gh = (from x in Data.GioHangs where x.UserName == User && x.MaSP == IDSP select x).SingleOrDefault();
                Data.GioHangs.DeleteOnSubmit(gh);
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Check(string User, int IDSP)
        {
            DienTuDataContext Data = new DienTuDataContext();
            if (string.IsNullOrEmpty(User))
                return false;
            var querry = (from x in Data.GioHangs where x.UserName == User && x.MaSP == IDSP select x).SingleOrDefault();
            if (querry == null)
                return false;
            else
                return true;
        }
        public string Sum()
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.GioHangs where x.UserName == MainForm.User select x.SumAll).ToList().Sum();
            if (string.IsNullOrEmpty(querry.ToString()))
                return "0";
            else
                return querry.ToString();

        }
        public bool Del (string User)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = from x in Data.GioHangs where x.UserName == User select x;
            foreach (var x in querry)
            {
                Data.GioHangs.DeleteOnSubmit(x);
            }
            try
            {
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
