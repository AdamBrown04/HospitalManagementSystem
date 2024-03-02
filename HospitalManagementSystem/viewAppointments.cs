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
        int patientID;
        int hospitalID;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
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
                recordIDnumber += 1;
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
                    dt_date.Text = $"{reader["appointmentDate"]}";
                    dt_time.Text = $"{reader["appointmentTime"]}";
                    patientID = Convert.ToInt32(reader["patientDetailsID"]);
                    hospitalID = Convert.ToInt32(reader["hospitalID"]);
                }
                recordIDnumber -= 1;
            }
            else
            {
                isNewForm = true;
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            /*
            if (isNewForm)
            {

            }
            else
            {
                string date = dt_date.Text;
                string time = dt_time.Text;

                if (date != "" && time != "")
                {
                    string sql = $"INSERT INTO `appointment` (`appointmentID`, `hospitalID`, `patientDetailsID`, `appointmentDate`, `appointmentTime`) VALUES (NULL, '{patientID}', '{hospitalID}', '{date}', '{time}'); ";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connectionString;
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                }
                else
                {
                    MessageBox.Show("Make sure all text boxes are filled out");
                }
            }
        */
        }
    }
}

//UPDATE `appointment` SET `appointmentTime` = '15:00:00' WHERE `appointment`.`appointmentID` = 2;