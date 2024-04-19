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
    public partial class viewJobs : Form
    {
        int recordIDnumber;
        int aLevel;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
        public viewJobs(int recordID, string tableName, string username, int accessLevel)
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

        private void viewJobs_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewJobs_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                if (recordIDnumber < 2)
                {
                    recordIDnumber += 1;
                }
                else
                {
                    recordIDnumber += 4;
                }

                List<string> allDepartments = GetDepartments();

                foreach (string department in allDepartments)
                {
                    cmb_departmentName.Items.Add(department);
                }
                string sql = $"SELECT * FROM {tName} INNER JOIN department ON (department.departmentID  = jobs.departmentID) WHERE jobsID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txb_jobName.Text = $"{reader["jobName"]}";
                    cmb_departmentName.Text = $"{reader["departmentName"]}";
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

            string[] departmentString = cmb_departmentName.Text.Split("-");
            string departmentID = departmentString[0];

            recordIDnumber += 1;

            if (isNewForm)
            {
                sql = $"INSERT INTO jobs (jobsID, departmentID, jobName) VALUES (NULL, {departmentID} ,'{txb_jobName.Text}')";
            }
            else
            {
                sql = $"UPDATE jobs SET departmentID = '{departmentID}', jobName = '{txb_jobName.Text}' WHERE jobsID = {recordIDnumber}";
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

        private List<string> GetDepartments()
        {
            List<string> departments = new List<string>();
            string idDepartments;

            string sql = "SELECT * FROM department";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                idDepartments = $"{reader["departmentID"]}-{reader["departmentName"]}";
                departments.Add(idDepartments);
            }

            return departments;
        }
    }
}
