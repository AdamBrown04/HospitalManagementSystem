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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagementSystem
{
    public partial class viewHospital : Form
    {
        int recordIDnumber;
        int aLevel;
        string uName;
        string tName;
        string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";
        bool isNewForm = false;
        public viewHospital(int recordID, string tableName, string username, int accessLevel)
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

        private void viewHospital_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewHospital_Load(object sender, EventArgs e)
        {
            if (recordIDnumber != -1)
            {
                recordIDnumber += 1;
                string sql = $"SELECT * FROM {tName} WHERE hospitalID = '{recordIDnumber}'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txb_postcode.Text = $"{reader["postcode"]}";
                    txb_hName.Text = $"{reader["hospitalName"]}";
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

            recordIDnumber += 1;

            if (isNewForm)
            { 
                sql = $"INSERT INTO hospital (hospitalID, hospitalName, addressLine1, addressLine2, addressLine3, postcode) VALUES (NULL, '{txb_hName.Text}', '{txb_address1.Text}', '{txb_address2.Text}', '{txb_address3.Text}', '{txb_postcode.Text}')";
            }
            else
            {
                sql = $"UPDATE hospital SET hospitalName = '{txb_hName.Text}', addressLine1 = '{txb_address1.Text}', addressLine2 = '{txb_address2.Text}', addressLine3 = '{txb_address3.Text}', postcode = '{txb_postcode.Text}' WHERE hospitalID = {recordIDnumber}";
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
