﻿using MySql.Data.MySqlClient;
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
    public partial class viewPatientRecord : Form
    {
        int recordIDnumber;
        int aLevel;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
        public viewPatientRecord(int recordID, string tableName, string username, int accessLevel)
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

        private void viewPatientRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewPatientRecord_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                cmb_patient.Enabled = false;
                recordIDnumber += 1;
                string sql = $"SELECT * FROM {tName} INNER JOIN patientDetails ON (patientDetails.patientDetailsID = patientRecords.patientDetailsID) WHERE patientRecordsID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmb_patient.Text = $"{reader["patientRecordsID"]}-{reader["firstName"]} {reader["lastName"]}";
                    txb_height.Text = $"{reader["heightCM"]}";
                    txb_weight.Text = $"{reader["weightKG"]}";
                    txb_bloodType.Text = $"{reader["bloodType"]}";
                }
                recordIDnumber -= 1;
            }
            else
            {
                isNewForm = true;

                List<string> allUsers = GetNames();

                foreach (string user in allUsers)
                {
                    cmb_patient.Items.Add(user);
                }
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            string sql = "";

            int height = Convert.ToInt32(txb_height.Text);
            int weight = Convert.ToInt32(txb_weight.Text);

            string[] patientString = cmb_patient.Text.Split("-");
            string patientID = patientString[0];

            recordIDnumber += 1;

            if (isNewForm)
            {
                sql = $"INSERT INTO patientRecords (patientRecordsID, patientDetailsID, heightCM, weightKG, bloodType) VALUES (NULL, {patientID},'{height}', '{weight}', '{txb_bloodType.Text}')";
            }
            else
            {
                sql = $"UPDATE patientRecords SET weightKG = '{weight}', heightCM = '{height}', bloodType = '{txb_bloodType.Text}' WHERE patientRecordsID = {recordIDnumber}";
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
    }
}
