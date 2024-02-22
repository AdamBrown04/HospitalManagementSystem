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
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
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

            List<string> tableNames = allowedTables();

            foreach (string tableName in tableNames)
            {
                lsb_selectTable.Items.Add(tableName);
            }
        }

        private List<string> allowedTables()
        {
            List<string> tables = new List<string>();

            int accessLevel = -1;
            string sql = $"SELECT accessLevel FROM staff WHERE username = '{username}'";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                accessLevel = Convert.ToInt32(reader["accessLevel"]);
            }

            switch (accessLevel)
            {
                case 1: //system admin
                    tables.Add("patientdetails");
                    tables.Add("staff");
                    break;
                case 2: //dep head
                    break;
                case 3: //receptionist
                    break;
                case 4: //admin/other staff
                    break;
                case 5: //doctor
                    break;
                case 6: //paramedic
                    break;
                case 7: //amb op
                    break;
                case 8: //lab tech
                    break;
                case 9: //med staff
                    break;
            }

            return tables;
        }

        private void selectTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
