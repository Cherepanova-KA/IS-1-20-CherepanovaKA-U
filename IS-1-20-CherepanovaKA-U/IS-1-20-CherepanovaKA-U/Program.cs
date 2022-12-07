using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_CherepanovaKA_U
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu());
        }

        class ConnectionSql
        {
            string server = "chuc.caseum.ru";
            string port = "33333";
            string user = "st_1_20_30";
            string database = "is_1_20_st30_KURS";
            string password = "14759434";
            public string connStr;
            public string Connectreturn()
            {
                return connStr = $"host={server};port={port};user={user};database={database};password={password}";
            }
        }
    }
}
