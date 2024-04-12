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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagementSystem
{
    public partial class viewTest : Form
    {
        int recordIDnumber;
        int aLevel;
        string staffID;
        string patientID;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
        public viewTest(int recordID, string tableName, string username, int accessLevel)
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

        private void viewTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewTest_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                cmb_pName.Enabled = false;
                cmb_sName.Enabled = false;

                recordIDnumber += 1;
                string sql = $"SELECT * FROM {tName} INNER JOIN staff ON (staff.staffID = test.staffID) INNER JOIN patientRecords ON (patientRecords.patientRecordsID = test.patientRecordsID) INNER JOIN patientDetails ON (patientDetails.patientDetailsID = patientRecords.patientDetailsID) WHERE testID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txb_testID.Text = $"{reader["testID"]}";
                    cmb_sName.Text = $"{reader["sFirstName"]} {reader["sLastName"]}";
                    cmb_pName.Text = $"{reader["firstName"]} {reader["lastName"]}";
                    txb_testName.Text = $"{reader["testName"]}";
                    txb_testResults.Text = $"{reader["testResults"]}";
                    patientID = $"{reader["patientRecordsID"]}";
                    staffID = $"{reader["staffID"]}";
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


                List<string> staff = GetStaff();
                foreach (string staffMember in staff)
                {
                    cmb_sName.Items.Add(staffMember);
                }
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            

            string sql = "";

            recordIDnumber += 1;

            if (isNewForm)
            {
                staffID = cmb_sName.Text.Substring(0, 1);
                patientID = cmb_pName.Text.Substring(0, 1);

                sql = $"INSERT INTO test (testID, staffID, patientRecordsID, testResults, testName) VALUES (NULL, '{staffID}', '{patientID}', '{txb_testResults.Text}', '{txb_testName.Text}')";
            }
            else
            {
                sql = $"UPDATE test SET staffID = '{staffID}', patientRecordsID = '{patientID}', testResults = '{txb_testResults.Text}', testName = '{txb_testName.Text}' WHERE testID = {recordIDnumber}";
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

        private List<string> GetStaff()
        {
            List<string> doctors = new List<string>();
            string idDoctors;

            string sql = "SELECT staffID, sFirstName, sLastName FROM staff WHERE accessLevel = 8 OR accessLevel = 9";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
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
