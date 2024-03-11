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
                txb_pName.Enabled = false;

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

            string sql = "";

            recordIDnumber += 1;

            if (isNewForm)
            {
                sql = $"INSERT INTO appointment (appointmentID, hospitalID, patientDetailsID, appointmentDate, appointmentTime) VALUES (NULL, '{patientID}', '{hospitalID}', '{dt_date}', '{dt_time}')";
            }
            else
            {
                sql = $"UPDATE appointment SET hospitalID = '{hospitalID}', appointmentDate = '{dt_date}', appointmentTime = '{dt_time}' WHERE appointmentID = {recordIDnumber}";
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
    }
}