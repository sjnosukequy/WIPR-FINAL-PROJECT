using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    public class BLUser
    {
        
        public BLUser()
        {

        }
        public DataSet Show()
        {
            DienTuDataContext Data = new DienTuDataContext();
            using (var cmd = Data.Connection.CreateCommand())
            {
                Data.Connection.Open();
                cmd.CommandText = $"select * from NguoiDung where User_Name = '{MainForm.User}'";
                var results = cmd.ExecuteReader();
                DataTable a = new DataTable();
                DataSet b = new DataSet();
                a.Load(results);
                b.Tables.Add(a);
                return b;
            }
        }
        public bool Check(string User, string pass, string Name, string DC)
        {
            DienTuDataContext Data = new DienTuDataContext();
            var querry = (from x in Data.NguoiDungs where x.User_Name == User && x.Password == pass && x.Ho_Ten == Name && x.Dia_Chi == DC select x).SingleOrDefault();
            if(querry == null)
                return true;
            else
                return false;
        }
        public void Update(ref string User1, ref string Name1, ref string DC1,string Name, string Pass, string DC)
        {
            DienTuDataContext Data = new DienTuDataContext();
            string na = User1;
            NguoiDung nd = Data.NguoiDungs.Single(ND => ND.User_Name == na);
            nd.Ho_Ten = Name;
            nd.Dia_Chi = DC;
            nd.Password = Pass;
            Data.SubmitChanges();
            Name1 = Name;
            DC1 = DC;
        }
        public void Update(ref string User1 , ref string DC, string DC1)
        {
            DienTuDataContext Data = new DienTuDataContext();
            string na = User1;
            NguoiDung nd = Data.NguoiDungs.Single(ND => ND.User_Name == na);
            nd.Dia_Chi = DC1;
            Data.SubmitChanges();
            DC = DC1;
        }
    }
}
