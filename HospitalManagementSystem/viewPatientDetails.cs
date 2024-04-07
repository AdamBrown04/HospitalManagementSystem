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
    public partial class viewPatientDetails : Form
    {
        int recordIDnumber;
        int aLevel;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
        public viewPatientDetails(int recordID, string tableName, string username, int accessLevel)
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

        private void viewPatientDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewPatientDetails_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                recordIDnumber += 1;
                string sql = $"SELECT * FROM {tName} WHERE patientDetailsID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txb_name.Text = $"{reader["firstName"]} {reader["lastName"]}";
                    dtb_dob.Text = $"{reader["dob"]}";
                    txb_email.Text = $"{reader["email"]}";
                    txb_phoneNumber.Text = $"{reader["phoneNumber"]}";
                    txb_gender.Text = $"{reader["gender"]}";
                    txb_address1.Text = $"{reader["addressLine1"]}";
                    txb_address2.Text = $"{reader["addressLine2"]}";
                    txb_address3.Text = $"{reader["addressLine3"]}";
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
            string dob = $"{dtb_dob.Value.Year}-{dtb_dob.Value.Month}-{dtb_dob.Value.Day}";

            string[] names = txb_name.Text.Split(null);
            string fName = names[0];
            string lName = names[1];

            recordIDnumber += 1;

            if (isNewForm)
            {
                sql = $"INSERT INTO patientdetails (patientDetailsID, firstName, lastName, DoB, email, phoneNumber, gender, addressLine1, addressLine2, addressLine3) VALUES (NULL, '{fName}', '{lName}', '{dob}', '{txb_email.Text}', '{txb_phoneNumber.Text}', '{txb_gender.Text}', '{txb_address1.Text}', '{txb_address2.Text}', '{txb_address3.Text}')";
            }
            else
            {
                sql = $"UPDATE patientdetails SET firstName = '{fName}', lastName = '{lName}', DoB = '{dob}', email = '{txb_email.Text}', phoneNumber = '{txb_phoneNumber.Text}', gender = '{txb_gender.Text}', addressLine1 = '{txb_address1.Text}', addressLine2 = '{txb_address2.Text}', addressLine3 = '{txb_address3.Text}'  WHERE patientDetailsID = {recordIDnumber}";
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
