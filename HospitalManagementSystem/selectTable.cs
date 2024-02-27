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
        int accessLevel = -1;
        int currentIndex = -1;
        string username;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        List<string> tableNames = new List<string>();
        public selectTable(string currentUsername)
        {
            InitializeComponent();

            username = currentUsername;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            searchTable newForm = new searchTable(tableNames[currentIndex], username ,accessLevel);
            newForm.Show();
            this.Hide();
        }

        private void selectTable_Load(object sender, EventArgs e)
        {

            tableNames = allowedTables();

            foreach (string tableName in tableNames)
            {
                lsb_selectTable.Items.Add(tableName);
            }
        }

        private List<string> allowedTables()
        {
            List<string> tables = new List<string>();

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
                    tables.Add("jobs");
                    tables.Add("department");
                    tables.Add("hospital");
                    break;
                case 2: //dep head
                    tables.Add("patientdetails");
                    tables.Add("staff");
                    tables.Add("jobs");
                    break;
                case 3: //receptionist
                    tables.Add("patientdetails");
                    tables.Add("appointment");
                    break;
                case 4: //admin/other staff
                    tables.Add("patientdetails");
                    break;
                case 5: //doctor
                    tables.Add("patientrecords");
                    tables.Add("diagnosis");
                    tables.Add("test");
                    break;
                case 6: //paramedic
                    tables.Add("patientrecords");
                    tables.Add("diagnosis");
                    break;
                case 7: //nurse
                    tables.Add("patientrecords");
                    tables.Add("test");
                    tables.Add("diagnosis");
                    break;
                case 8: //lab tech
                    tables.Add("patientrecords");
                    tables.Add("test");
                    break;
                case 9: //med staff
                    tables.Add("patientrecords");
                    break;
            }

            return tables;
        }

        private void selectTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lsb_selectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = lsb_selectTable.SelectedIndex;
            if(currentIndex != -1)
            {
                btn_submit.Enabled = true;
            }
        }
    }
}
