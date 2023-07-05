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
            if (string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(User))
                return false;
            string sql = $"select * from NguoiDung where User_Name = '{User}' and Password = '{Pass}'";
            DBMain db = new DBMain();
            DataSet a = new DataSet();
            try
            { 
                a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            }
            catch
            {
            }
            if (a.Tables.Count == 0)
                return false;
            if(a.Tables[0].Rows.Count != 1)
                return false;
            Name = a.Tables[0].Rows[0][0].ToString();
            UserName = a.Tables[0].Rows[0][1].ToString();
            Admin = Convert.ToBoolean(a.Tables[0].Rows[0][4].ToString());
            Addr = a.Tables[0].Rows[0][3].ToString();
            return true;
        }
        public bool Check(string User)
        {
            if (string.IsNullOrEmpty(User))
                return false;
            string sql = $"select * from NguoiDung where User_Name = '{User}'";
            DBMain db = new DBMain();
            DataSet a = new DataSet();
            try
            {
                a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            }
            catch
            {
            }
            if (a.Tables.Count == 0)
                return false;
            if (a.Tables[0].Rows.Count != 1)
                return false;
            return true;
        }
        public bool ADD(string User, string Pass, string Name, string Addr)
        {
            DBMain db = new DBMain();
            if (string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Name))
                return false;
            if (string.IsNullOrEmpty(Addr))
                Addr = "";
            string sql = $"INSERT INTO NguoiDung (Ho_Ten,User_Name,Password,Dia_Chi,Admin) Values ('{Name}','{User}','{Pass}','{Addr}','False')";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}
