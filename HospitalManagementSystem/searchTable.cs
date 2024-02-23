using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class searchTable : Form
    {
        int currentIndex = -1;
        string tName;
        string uName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        public searchTable(string tableName, string username)
        {
            InitializeComponent();
            tName = tableName;
            uName = username;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            selectTable newForm = new selectTable(uName);
            newForm.Show();
            this.Hide();
        }

        private void searchTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void searchTable_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM {tName}";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lsb_Tablerecords.Items.Add(DisplayRecord(reader));
            }
        }

        private string DisplayRecord(MySqlDataReader reader) 
        {
            string itemName = itemName = $"id: {reader[$"{tName}id"]} ";

            switch (tName)
            {
                case "staff":
                    itemName = itemName + $"name: {reader["firstName"]} {reader["lastName"]}";
                    break;
                case "jobs":
                    itemName = itemName + $"job name: {reader["jobName"]}";
                    break;
                case "hospital":
                    itemName = itemName+ $"hospital name: {reader["hospitalName"]} ";
                    break;
                case "appoitment":
                    itemName = itemName + $": {reader[""]} ";
                    break;
                case "department":
                    itemName = itemName + $"department name: {reader["departmentName"]} ";
                    break;
                case "diagnosis":
                    itemName = itemName + $": {reader[""]} ";
                    break;
                case "patientdetials":
                    itemName = itemName + $"patient name: {reader["firstName"]} {reader["lastName"]}";
                    break;
                case "patientrecords":
                    itemName = itemName + $": {reader[""]} ";
                    break;
                case "test":
                    itemName = itemName + $": {reader[""]} ";
                    break;
            }


            return itemName;

        }

        private void lsb_Tablerecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = lsb_Tablerecords.SelectedIndex;
            if (currentIndex != -1)
            {
                btn_select.Enabled = true;
            }
        }
    }
}
