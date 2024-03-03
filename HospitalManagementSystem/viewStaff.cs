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
                    txb_job.Text = $"{reader["jobName"]}";
                    txb_department.Text = $"{reader["departmentName"]}";
                    dt_dob.Text = $"{reader["dob"]}";
                    txb_phoneNumber.Text = $"{reader["phoneNumber"]}";
                    txb_address1.Text = $"{reader["addressLine1"]}";
                    txb_address2.Text = $"{reader["addressLine2"]}";
                    txb_address3.Text = $"{reader["addressLine3"]}";
                    txb_email.Text = $"{reader["email"]}";
                    txb_accessLevel.Text = $"{reader["accessLevel"]}";
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
