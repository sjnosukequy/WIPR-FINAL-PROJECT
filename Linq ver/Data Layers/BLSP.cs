using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.SanPhams select new { x.MaSP, x.TenSP, x.Loai, x.Spec, x.NhaSX, x.SLKho, x.GiaTien, x.GiamGia }).ToList();
            DataGrid.DataSource = querry;
        }
        public void ShowSP(DataGridView DataGrid, string SP)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.SanPhams  where x.Loai == SP select new { x.MaSP, x.TenSP, x.Loai, x.Spec, x.NhaSX, x.SLKho, x.GiaTien, x.GiamGia }).ToList();
            DataGrid.DataSource = querry;
        }
        public void ShowSP(DataGridView DataGrid, string SP, string SP2)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.SanPhams where x.Loai == SP || x.Loai == SP2 select new { x.MaSP, x.TenSP, x.Loai, x.Spec, x.NhaSX, x.SLKho, x.GiaTien, x.GiamGia }).ToList();
            DataGrid.DataSource = querry;
        }
        public void ShowSP(DataGridView DataGrid, string SP, string SP2, string SP3)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.SanPhams where x.Loai == SP || x.Loai == SP2 || x.Loai == SP3   select new { x.MaSP, x.TenSP, x.Loai, x.Spec, x.NhaSX, x.SLKho, x.GiaTien, x.GiamGia }).ToList();
            DataGrid.DataSource = querry;
        }
        public bool AddSP(string name, string Loai, string Spec, string NhaSX, int SL, int GiaTien, int Giam)
        {
            DienTuDataContext Data = new DienTuDataContext();
            SanPham sp = new SanPham();
            sp.TenSP = name;
            sp.Loai = Loai;
            sp.Spec = Spec;
            sp.NhaSX = NhaSX;
            sp.SLKho = SL;
            sp.GiaTien = GiaTien;
            sp.GiamGia = Giam;
            try
            {
                Data.SanPhams.InsertOnSubmit(sp);
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(int ID,string name, string Loai, string Spec, string NhaSX, int SL, int GiaTien, int Giam)
        {
            DienTuDataContext Data = new DienTuDataContext();
            try
            {
                SanPham sp = Data.SanPhams.Single(SP => SP.MaSP == ID);
                sp.TenSP = name;
                sp.Loai = Loai;
                sp.Spec = Spec;
                sp.NhaSX = NhaSX;
                sp.SLKho = SL;
                sp.GiaTien = GiaTien;
                sp.GiamGia = Giam;
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Del(int ID)
        {
            DienTuDataContext Data = new DienTuDataContext();
            try
            {
                SanPham sp = Data.SanPhams.Single(SP => SP.MaSP == ID);
                Data.SanPhams.DeleteOnSubmit(sp);
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void FindSP(DataGridView DataGrid, string SP)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.SanPhams where x.TenSP.Contains(SP) || x.Loai.Contains(SP) || x.Spec.Contains(SP) || x.NhaSX.Contains(SP) select new { x.MaSP, x.TenSP, x.Loai, x.Spec, x.NhaSX, x.SLKho, x.GiaTien, x.GiamGia }).ToList();
            DataGrid.DataSource = querry;
        }
    }
}
