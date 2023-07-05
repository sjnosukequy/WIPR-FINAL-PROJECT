using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            DBMain db = new DBMain();
            return db.ExecuteQueryDataSet($"select * from NguoiDung where User_Name = '{MainForm.User}'", CommandType.Text);
        }
        public bool Check(string User, string pass, string Name, string DC)
        {
            DataSet temp = new DataSet();
            temp.Clear();
            DBMain db = new DBMain();
            try
            {
                temp = db.ExecuteQueryDataSet($"select * from NguoiDung where User_Name = '{User}' and Password = '{pass}' and Ho_Ten = '{Name}' and Dia_Chi = '{DC}'", CommandType.Text);
            }
            catch
            {

            }
            if (temp.Tables[0].Rows.Count != 0)
                return false;
            return true;
        }
        public void Update(ref string User1, ref string Name1, ref string DC1,string Name, string Pass, string DC)
        {
            DBMain db = new DBMain();
            string sql = $"update NguoiDung set Ho_Ten = '{Name}', Password = '{Pass}', Dia_Chi = '{DC}'where User_Name = '{User1}'";
            db.ExecuteQueryDataSet(sql, CommandType.Text);
            Name1 = Name;
            DC1 = DC;
        }
        public void Update(ref string User1 , ref string DC, string DC1)
        {
            DBMain db = new DBMain();
            string sql = $"update NguoiDung set Dia_Chi = '{DC1}'where User_Name = '{User1}'";
            db.ExecuteQueryDataSet(sql, CommandType.Text);
            DC = DC1;
        }
    }
}
