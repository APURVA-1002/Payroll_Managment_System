using System.Data;
using System.Data.SqlClient;

namespace PayrollMngmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("pr_loginpage", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NChar).Value = txtusername.Text;
            cmd.Parameters.Add("@password", SqlDbType.NChar).Value = txtpass.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Login Successfull!!");
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!!");
            }
            con.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
        }
        public void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctrl = (Control)sender;

            //Navigating the form using enter and escape
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyChar == 27)
            {
                SendKeys.Send("+{TAB}");
            }

            string validUsernameChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_\b";
            string validPasswordChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=\b";

            if (ctrl.Tag != null && ctrl.Tag == "username")
            {
                // For username
                if (!validUsernameChars.Contains(e.KeyChar.ToString()))
                    e.KeyChar = (char)0;
                if (e.KeyChar == '@' || e.KeyChar == '.')
                    e.KeyChar = (char)0; // Avoid special characters that might cause issues
            }
            else if (ctrl.Tag != null && ctrl.Tag == "password")
            {
                // For password
                if (!validPasswordChars.Contains(e.KeyChar.ToString()))
                    e.KeyChar = (char)0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
