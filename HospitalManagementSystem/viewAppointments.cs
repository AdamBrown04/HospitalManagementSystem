using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
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
                cb_pName.Enabled = false;

                recordIDnumber += 1;
                string sql = $"SELECT * FROM {tName} INNER JOIN patientDetails ON (patientDetails.patientDetailsID  = appointment.patientDetailsID) INNER JOIN hospital ON (hospital.hospitalID  = appointment.hospitalID) WHERE appointmentID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cb_pName.Text = $"{reader["firstName"]} {reader["lastName"]}";
                    cb_hName.Text = $"{reader["hospitalName"]}";
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

                List<string> allUsers = GetNames();

                foreach (string user in allUsers)
                {
                    cb_pName.Items.Add(user);
                }
            }

            List<string> hospitals = GetHospitals();

            foreach (string hospital in hospitals)
            {
                cb_hName.Items.Add(hospital);
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {

            string sql = "";

            string date = $"{dt_date.Value.Year}-{dt_date.Value.Month}-{dt_date.Value.Day}";
            string time = $"{dt_time.Value.Hour}:{dt_time.Value.Minute}:{dt_time.Value.Second}";

            

            recordIDnumber += 1;

            if (isNewForm)
            {
                string patientID = cb_pName.Text.Substring(0, 1);
                string hospitalID = cb_hName.Text.Substring(0,1);

                sql = $"INSERT INTO appointment (appointmentID, hospitalID, patientDetailsID, appointmentDate, appointmentTime) VALUES (NULL, '{patientID}', '{hospitalID}', '{date}', '{time}')";
            }
            else
            {
                sql = $"UPDATE appointment SET hospitalID = '{hospitalID}', appointmentDate = '{date}', appointmentTime = '{time}' WHERE appointmentID = {recordIDnumber}";
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

        private List<string> GetHospitals()
        {
            List<string> hospitals = new List<string>();
            string idHospital;

            string sql = "SELECT hospitalID, hospitalName FROM hospital";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                idHospital = $"{reader["hospitalID"]}-{reader["hospitalName"]}";
                hospitals.Add(idHospital);
            }

            return hospitals;
        }
    }
}