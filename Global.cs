using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace project_reboque
{
    internal class Global
    {
        public static string path = Environment.CurrentDirectory;
        public static string DB = "db.db";
        public static string pathDB = path + @"\DB\" + DB;
        public static string RealPathDB = @"D:\learning\bank_app\project_reboque\bin\Debug\net7.0-windows\project_reboque\DB\db.db";
    }
}
