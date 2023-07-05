using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO_ver.Connection;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace ADO_ver.Data
{
    public class BLLogin
    {
        string err;
        public BLLogin()
        {

        }
        public bool Check(string User, string Pass,ref string UserName ,ref string Name, ref bool Admin, ref string Addr)
        {
            DIENTUEntities1 Data = new DIENTUEntities1();
            if (string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(User))
                return false;
            //string sql = $"select * from NguoiDung where User_Name = '{User}' and Password = '{Pass}'";
            var sql = (from x in Data.NguoiDungs where x.User_Name == User && x.Password == Pass select x).SingleOrDefault();
            if (sql == null)
                return false;
            Name = sql.Ho_Ten;
            UserName = sql.User_Name;
            Admin = sql.Admin;
            Addr = sql.Dia_Chi;
            return true;
        }
        public bool Check(string User)
        {
            DIENTUEntities1 Data = new DIENTUEntities1();
            if (string.IsNullOrEmpty(User))
                return false;
            var sql = (from x in Data.NguoiDungs where x.User_Name == User select x).SingleOrDefault();
            if (sql == null)
                return false;
            return true;
        }
        public bool ADD(string User, string Pass, string Name, string Addr)
        {
            DIENTUEntities1 Data = new DIENTUEntities1();
            if (string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Name))
                return false;
            if (string.IsNullOrEmpty(Addr))
                Addr = "";
            NguoiDung nd = new NguoiDung();
            nd.Ho_Ten = Name;
            nd.User_Name = User;
            nd.Password = Pass;
            nd.Dia_Chi = Addr;
            nd.Admin = false;
            try
            {
                Data.NguoiDungs.Add(nd);
                Data.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
