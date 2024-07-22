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
    public partial class AddEmpDetails : BaseForm
    {
        bool recfnd = false;
        public AddEmpDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");

        private void btnaddemp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("pr_addemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value=txtempid.Text;
            cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = txtempname.Text;
            cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = cmbdepartment.Text;
            cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = cmbposition.Text;
            cmd.Parameters.Add("@worklocation", SqlDbType.NVarChar).Value = cmbwklocation.Text;
            cmd.Parameters.Add("@dateofbirth", SqlDbType.DateTime).Value = dtmdateofbirth.Value;
            cmd.Parameters.Add("@emailid", SqlDbType.NVarChar).Value = txtemail.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee details added successfully!!");
            con.Close();
            txtempid.Text = "";
            txtempname.Text = "";
            cmbdepartment.SelectedIndex = 0;
            cmbposition.SelectedIndex = 0;
            cmbwklocation.SelectedIndex = 0;
            dtmdateofbirth.Value = DateTime.Now;
            txtemail.Text = "";
        }

        private void txtempid_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = "select";
                cmd.Parameters.Add("@employeeid", SqlDbType.Int).Value = Convert.ToInt32(txtempid.Text);
                cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@worklocation", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@dateofbirth", SqlDbType.DateTime).Value = null;
                cmd.Parameters.Add("@emailid", SqlDbType.NVarChar).Value = "";

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    recfnd = true;
                    rdr.Read();
                    txtempname.Text = rdr["employeename"].ToString();
                    cmbdepartment.Text = rdr["department"].ToString();
                    cmbposition.Text = rdr["position"].ToString();
                    cmbwklocation.Text = rdr["worklocation"].ToString();

                    if (rdr["dateofbirth"] != DBNull.Value)
                    {
                        dtmdateofbirth.Value = Convert.ToDateTime(rdr["dateofbirth"]);
                    }

                    txtemail.Text = rdr["emailid"].ToString();
                }
                else
                {
                    recfnd = false;
                    txtempname.Text = "";
                    cmbdepartment.SelectedIndex = 0;
                    cmbposition.SelectedIndex = 0;
                    cmbposition.SelectedIndex = 0;
                    dtmdateofbirth.Value = DateTime.Now;
                    txtemail.Text = "";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ClearControls(txtempid, Controls);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (recfnd)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("pr_employee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = "delete";
                    cmd.Parameters.Add("@employeeid", SqlDbType.Int).Value = Convert.ToInt32(txtempid.Text);
                    cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = "";
                    cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = "";
                    cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = "";
                    cmd.Parameters.Add("@worklocation", SqlDbType.NVarChar).Value = "";
                    cmd.Parameters.Add("@dateofbirth", SqlDbType.DateTime).Value = null;
                    cmd.Parameters.Add("@emailid", SqlDbType.NVarChar).Value = "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee details deleted successfully!!");
                    ClearControls(txtempid, Controls);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
