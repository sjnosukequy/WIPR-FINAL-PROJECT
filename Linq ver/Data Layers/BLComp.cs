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
        public BLComp()
        {

        }
        public void Show(DataGridView DataGrid)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.CungCaps select new { x.NhaSX,x.QuanLy,x.SDT}).ToList();
            DataGrid.DataSource = querry;
        }
    }
}
