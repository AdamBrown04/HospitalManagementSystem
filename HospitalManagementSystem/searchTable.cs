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
        int aLevel;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        public searchTable(string tableName, string username, int accessLevel)
        {
            InitializeComponent();
            tName = tableName;
            uName = username;
            aLevel = accessLevel;
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

            switch (tName)
            {
                case "patientrecords":
                    sql = sql + " INNER JOIN patientDetails ON (patientdetails.patientDetailsID)  = patientrecords.patientDetailsID";
                    break;
                case "diagnosis":
                    sql = sql + " INNER JOIN patientRecords ON (patientRecords.patientRecordsID = diagnosis.patientRecordsID) INNER JOIN patientDetails ON (patientdetails.patientDetailsID)  = patientrecords.patientDetailsID";
                    break;
                case "appointment":
                    sql = sql + " INNER JOIN patientDetails ON (patientDetails.patientDetailsID  = appointment.patientDetailsID) INNER JOIN hospital ON (hospital.hospitalID  = appointment.hospitalID)";
                    break;
                case "test":
                    sql = sql + " INNER JOIN staff ON (staff.staffID = test.staffID)";
                    break;
            }

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lsb_Tablerecords.Items.Add(DisplayRecord(reader));
            }

            switch (aLevel)
            {
                case 1: //sys admin
                    if (tName == "patientdetails" || tName == "jobs" || tName == "hospital" || tName == "department")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
                case 2://dep head
                    if (tName == "staff" || tName == "jobs")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
                case 3://receptionist
                    if (tName == "appointment" || tName == "patientdetails")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
                case 5://doctor
                    if (tName == "diagnosis" || tName == "patientrecords")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
                case 6://para
                    if (tName == "diagnosis" || tName == "patientrecords")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
                case 7://nurse
                    if (tName == "patientrecords")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
                case 8://lab tech
                    if (tName == "test" || tName == "patientrecords")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
                case 9: //med staff
                    if (tName == "patientrecords")
                    {
                        btn_addNewEntry.Enabled = true;
                    }
                    break;
            }
        }

        private string DisplayRecord(MySqlDataReader reader)
        {
            string itemName = $"id: {reader[$"{tName}id"]} ";

            switch (tName)
            {
                case "staff":
                    itemName = itemName + $"name: {reader["firstName"]} {reader["lastName"]}";
                    break;
                case "jobs":
                    itemName = itemName + $"job name: {reader["jobName"]}";
                    break;
                case "hospital":
                    itemName = itemName + $"hospital name: {reader["hospitalName"]} ";
                    break;
                case "appointment":
                    itemName = itemName + $"patient name: {reader["firstName"]} {reader["lastName"]} hospital name: {reader["hospitalName"]} date: {reader["appointmentDate"]}";
                    break;
                case "department":
                    itemName = itemName + $"department name: {reader["departmentName"]} ";
                    break;
                case "diagnosis":
                    itemName = itemName + $"patient name: {reader["firstName"]} {reader["lastName"]}";
                    break;
                case "patientdetails":
                    itemName = itemName + $"patient name: {reader["firstName"]} {reader["lastName"]}";
                    break;
                case "patientrecords":
                    itemName = itemName + $"patient name: {reader["firstName"]} {reader["lastName"]}";
                    break;
                case "test":
                    itemName = itemName + $"test name: {reader["testName"]} member of staff: {reader["firstName"]} {reader["lastName"]}";
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

        private void btn_addNewEntry_Click(object sender, EventArgs e)
        {
            switch (tName) 
            {
                case "staff":
                    break;
                case "jobs":
                    break;
                case "hospital":
                    break;
                case "appointment":
                    break;
                case "department":
                    break;
                case "diagnosis":
                    break;
                case "patientdetails":
                    break;
                case "patientrecords":
                    break;
                case "test":
                    break;
            }

        }
    }
}