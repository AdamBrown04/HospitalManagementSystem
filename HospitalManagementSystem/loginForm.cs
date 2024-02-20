using MySql.Data.MySqlClient;

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

            string sql = "select username, password from staff";
            DbConn conn = new DbConn();
            conn.QueryDatabase(sql);

            
        }
    }
}
