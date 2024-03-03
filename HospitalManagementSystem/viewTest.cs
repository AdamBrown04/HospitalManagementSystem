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
                    txb_sName.Text = $"{reader["sFirstName"]} {reader["sLastName"]}";
                    txb_pName.Text = $"{reader["firstName"]} {reader["lastName"]}";
                    txb_testName.Text = $"{reader["testName"]}";
                    txb_testResults.Text = $"{reader["testResults"]}";
                }
                recordIDnumber -= 1;
            }
            else
            {
                isNewForm = true;
            }
        }
    }
}
