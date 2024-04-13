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
    public partial class viewStaff : Form
    {
        int recordIDnumber;
        int aLevel;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
        public viewStaff(int recordID, string tableName, string username, int accessLevel)
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

        private void viewStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewStaff_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                recordIDnumber += 1;
                string sql = $"SELECT * FROM {tName} INNER JOIN jobs ON (jobs.jobsID = staff.jobID) INNER JOIN department ON (department.departmentID = jobs.departmentID) WHERE staffID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txb_name.Text = $"{reader["sFirstName"]} {reader["sLastName"]}";
                    cmb_job.Text = $"{reader["jobName"]}";
                    cmb_department.Text = $"{reader["departmentName"]}";
                    dt_dob.Text = $"{reader["dob"]}";
                    txb_phoneNumber.Text = $"{reader["phoneNumber"]}";
                    txb_address1.Text = $"{reader["addressLine1"]}";
                    txb_address2.Text = $"{reader["addressLine2"]}";
                    txb_address3.Text = $"{reader["addressLine3"]}";
                    txb_email.Text = $"{reader["email"]}";
                    nud_accessLevel.Text = $"{reader["accessLevel"]}";
                }
                recordIDnumber -= 1;
            }
            else
            {
                isNewForm = true;
            }

            List<string> departments = GetDepartments();
            foreach (string department in departments)
            {
                cmb_department.Items.Add(department);
            }

            List<string> jobs = GetJobs();
            foreach (string job in jobs)
            {
                cmb_job.Items.Add(job);
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            string sql = "";

            recordIDnumber += 1;

            string[] names = txb_name.Text.Split(null);
            string fName = names[0];
            string lName = names[1];

            if (isNewForm)
            {
                sql = $"INSERT INTO staff (staffID, jobID, hospitalID, sFirstName, sLastName, DoB, phoneNumber, addressLine1, addressLine2, addressLine3, ) VALUES (NULL, '{staffID}', '{patientID}', '{txb_diagnosis.Text}')";
            }
            else
            {
                sql = $"UPDATE staff SET staffID = '{staffID}', diagnosisinformation = '{txb_diagnosis.Text}' WHERE staffID = {recordIDnumber}";
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

        private List<string> GetJobs()
        {
            List<string> jobs = new List<string>();
            string job;

            string sql = "SELECT jobsID, jobName FROM jobs";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                job = $"{reader["jobsID"]}-{reader["jobName"]}";
                jobs.Add(job);
            }

            return jobs;
        }

        private List<string> GetDepartments()
        {
            List<string> departments = new List<string>();
            string department;

            string sql = "SELECT * FROM department";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                department = $"{reader["departmentID"]}-{reader["departmentName"]}";
                departments.Add(department);
            }

            return departments;
        }
    }
}
