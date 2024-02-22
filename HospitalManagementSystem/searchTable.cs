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
    public partial class searchTable : Form
    {
        string tName;
        string uName;
        public searchTable(string tableName, string username)
        {
            InitializeComponent();
            tName = tableName;
            uName = username;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            selectTable newForm = new selectTable(uName);
            newForm.Show();
            this.Hide();
        }
    }
}
