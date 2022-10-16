using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Modbus_RTU_With_ASP.Net_MVC_Sample.Models.DatabaseProvider;

namespace Modbus_RTU_With_ASP.Net_MVC_Sample.Models.DatabaseProvider
{
    public class DBIO
    {
            MyDB mydb = new MyDB();

        //public void AddData(double Nang_luong)
        //{

        //    mydb.Database.ExecuteSqlCommand("insert into Table_3(Date,Nang_luong) values(GETDATE(),@NL)", new SqlParameter("@NL", Nang_luong));
        //}
        public void AddObject<T>(T obj) {
            mydb.Set(obj.GetType()).Add(obj); 
            mydb.SaveChanges();
        }
       

    }
}