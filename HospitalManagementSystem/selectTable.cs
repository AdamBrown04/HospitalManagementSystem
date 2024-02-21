using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManagementSystem
{
    public partial class selectTable : Form
    {
        string username;
        public selectTable(string currentUsername)
        {
            InitializeComponent();

            username = currentUsername;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }

        private void selectTable_Load(object sender, EventArgs e)
        {
            List<string> tableNames = new List<string>();

            string sql = "SHOW TABLES";
            string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tableNames.Add(reader["Tables_in_hospitalmanagementsystem"].ToString());
            }

            allowedTables(tableNames);

            foreach(string tableName in tableNames)
            {
                lsb_selectTable.Items.Add(tableName);
            }
        }

        private List<string> allowedTables(List<string> allTables)
        {
            
            return allTables;
        }
    }
}
