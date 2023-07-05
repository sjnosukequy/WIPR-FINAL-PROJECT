using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADO_ver.Connection;
using ADO_ver.UI_Layers;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.EntityClient;

namespace ADO_ver.Data_Layers
{
    public class BLUser
    {
        
        public BLUser()
        {

        }
        public DataSet Show()
        {
            DIENTUEntities1 Data = new DIENTUEntities1();
            using (var cmd = Data.Database.Connection.CreateCommand())
            {
                if (Data.Database.Connection.State != ConnectionState.Open)
                    Data.Database.Connection.Open();
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
            DIENTUEntities1 Data = new DIENTUEntities1();
            var querry = (from x in Data.NguoiDungs where x.User_Name == User && x.Password == pass && x.Ho_Ten == Name && x.Dia_Chi == DC select x).SingleOrDefault();
            if(querry == null)
                return true;
            else
                return false;
        }
        public void Update(ref string User1, ref string Name1, ref string DC1,string Name, string Pass, string DC)
        {
            DIENTUEntities1 Data = new DIENTUEntities1();
            string na = User1;
            NguoiDung nd = Data.NguoiDungs.Single(ND => ND.User_Name == na);
            nd.Ho_Ten = Name;
            nd.Dia_Chi = DC;
            nd.Password = Pass;
            Data.SaveChanges();
            Name1 = Name;
            DC1 = DC;
        }
        public void Update(ref string User1 , ref string DC, string DC1)
        {
            DIENTUEntities1 Data = new DIENTUEntities1();
            string na = User1;
            NguoiDung nd = Data.NguoiDungs.Single(ND => ND.User_Name == na);
            nd.Dia_Chi = DC1;
            Data.SaveChanges();
            DC = DC1;
        }
    }
}
