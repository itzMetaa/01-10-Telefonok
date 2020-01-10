using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Telefonok
{
    static class Program
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;

        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "telefonok";
            sb.Port = 3307;
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
