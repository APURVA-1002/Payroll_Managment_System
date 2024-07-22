using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMngmentSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");

        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("pr_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtpass.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Register successfully");
            con.Close();
            txtusername.Text = "";
            txtpass.Text = "";
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
    }
}
