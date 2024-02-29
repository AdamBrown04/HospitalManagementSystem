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
    public partial class viewAppointments : Form
    {
        int recordIDnumber;
        int aLevel;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        public viewAppointments(int recordID, string tableName, string username, int accessLevel)
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

        private void viewAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewAppointments_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                string sql = $"SELECT * FROM {tName} INNER JOIN patientDetails ON (patientDetails.patientDetailsID  = appointment.patientDetailsID) INNER JOIN hospital ON (hospital.hospitalID  = appointment.hospitalID) WHERE appointmentID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txb_pName.Text = $"{reader["firstName"]} {reader["lastName"]}";
                    txb_hName.Text = $"{reader["hospitalName"]}";
                    txb_date.Text = $"{reader["appointmentDate"]}";
                    txb_time.Text = $"{reader["appointmentTime"]}";
                }
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if ()
            {

            }
        }
    }
}
