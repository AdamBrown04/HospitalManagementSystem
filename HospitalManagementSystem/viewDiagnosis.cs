using Microsoft.VisualBasic;
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
using static Mysqlx.Notice.Warning.Types;

namespace HospitalManagementSystem
{
    public partial class viewDiagnosis : Form
    {
        int recordIDnumber;
        int aLevel;
        int staffID;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
        public viewDiagnosis(int recordID, string tableName, string username, int accessLevel)
        {
            InitializeComponent();

            recordIDnumber = recordID;
            aLevel = accessLevel;
            uName = username;
            tName = tableName;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            searchTable newForm = new searchTable(tName, uName, aLevel);
            newForm.Show();
            this.Hide();
        }

        private void viewDiagnosis_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewDiagnosis_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                cmb_pName.Enabled = false;
                recordIDnumber += 1;
                string sql = $"SELECT * FROM {tName} INNER JOIN patientRecords ON (patientRecords.patientRecordsID  = diagnosis.patientRecordsID) INNER JOIN patientDetails ON (patientDetails.patientDetailsID  = patientRecords.patientDetailsID) INNER JOIN staff ON (staff.staffID  = diagnosis.staffID) WHERE diagnosisID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmb_pName.Text = $"{reader["firstName"]} {reader["lastName"]}";
                    cmb_dName.Text = $"{reader["sFirstName"]} {reader["sLastName"]}";
                    txb_diagnosis.Text = $"{reader["diagnosisInformation"]}";
                    staffID = Convert.ToInt32(reader["staffID"]);
                }
                recordIDnumber -= 1;

            }
            else
            {
                isNewForm = true;


                List<string> allUsers = GetNames();

                foreach (string user in allUsers)
                {
                    cmb_pName.Items.Add(user);
                }
            }

            List<string> doctors = GetDoctors();
            foreach (string doctor in doctors)
            {
                cmb_dName.Items.Add(doctor);
            }
        
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            string sql = "";

            recordIDnumber += 1;

            if (isNewForm)
            {
                string patientID = cmb_pName.Text.Substring(0, 1);
                staffID = Convert.ToInt32(cmb_dName.Text.Substring(0, 1));

                sql = $"INSERT INTO diagnosis (diagnosisID, staffID, patientRecordsID, diagnosisinformation) VALUES (NULL, '{staffID}', '{patientID}', '{txb_diagnosis.Text}')";
            }
            else
            {
                sql = $"UPDATE diagnosis SET staffID = '{staffID}', diagnosisinformation = '{txb_diagnosis.Text}' WHERE diagnosisID = {recordIDnumber}";
            }

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand(sql, con);



            if (isNewForm)
            {
                adapter.InsertCommand = cmd;
                int rows = adapter.InsertCommand.ExecuteNonQuery();

                if (rows != -1)
                {
                    btn_return_Click(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Data insert failed");
                }
            }
            else
            {
                adapter.UpdateCommand = cmd;
                int rows = adapter.UpdateCommand.ExecuteNonQuery();

                if (rows != -1)
                {
                    btn_return_Click(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }

            recordIDnumber -= 1;

        }

        private List<string> GetNames()
    {
        List<string> names = new List<string>();
        string idName;

        string sql = "SELECT patientDetailsID, firstName, lastName FROM patientDetails";

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectionString;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(sql, con);
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            idName = $"{reader["patientDetailsID"]}-{reader["firstName"]} {reader["lastName"]}";
            names.Add(idName);
        }

        return names;
    }

    private List<string> GetDoctors()
    {
        List<string> doctors = new List<string>();
        string idDoctors;

        string sql = "SELECT staffID, sFirstName, sLastName FROM staff WHERE accessLevel = 5";

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString =  connectionString;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(sql, con);
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            idDoctors = $"{reader["staffID"]}-{reader["sFirstName"]} {reader["sLastName"]}";
            doctors.Add(idDoctors);
        }

        return doctors;
    }
}
}
