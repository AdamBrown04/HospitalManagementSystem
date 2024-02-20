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
    public partial class selectTable : Form
    {
        string username;
        public selectTable(string currentUsername)
        {
            InitializeComponent();

            username = currentUsername;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }
    }
}
