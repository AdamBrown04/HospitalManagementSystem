using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace HospitalManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string uName = txb_username.Text;
            string pwd = txb_password.Text;
            bool isCorrect = false;

            string dbUsername;
            string dbPassword;

            string sql = "SELECT username, password FROM staff";
            string connectionString = "server=localhost;uid=root;pwd=Dempsy66Proton;database=hospitalmanagementsystem";

            txb_username.Clear();
            txb_password.Clear();

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dbUsername = reader["username"].ToString();
                dbPassword = reader["password"].ToString();

                if(uName == dbUsername && pwd == dbPassword)
                {
                    isCorrect = true;
                    break;
                }
            }

            if (!isCorrect)
            {
                MessageBox.Show("INVALID LOGIN");
            }
            else
            {
                selectTable newForm = new selectTable(uName);
                newForm.Show();
                this.Hide();
            }
        }
    }
}
