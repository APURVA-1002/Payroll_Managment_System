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
    public partial class ViewEmpDetails : Form
    {
        public ViewEmpDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");

        private void btnsearchemp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewemp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add @employeeid parameter
            SqlParameter parameter = new SqlParameter("@employeeid", SqlDbType.Int);
            parameter.Value = (string.IsNullOrEmpty(txtsearch.Text)) ? DBNull.Value : (object)int.Parse(txtsearch.Text);
            cmd.Parameters.Add(parameter);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdviewemp.DataSource = dt;
            con.Close();
        }

        private void ViewEmpDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdviewemp.DataSource = dt;
            con.Close();
        }
        public void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctrl = (Control)sender;

            if (ctrl.Tag != null && ctrl.Tag == "int")
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b'))
                    e.KeyChar = (char)0;
            }
        }
    }
}
