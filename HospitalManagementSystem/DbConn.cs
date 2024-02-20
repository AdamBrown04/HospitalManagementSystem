using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HospitalManagementSystem
{
    internal class DbConn
    {
        private string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";

        public void QueryDatabase(string sql)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlDataReader reader = cmd.ExecuteReader();
        }
    }
}
