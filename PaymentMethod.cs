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
    public partial class PaymentMethod : BaseForm
    {
        bool recfnd = false;
        public PaymentMethod()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");

        private void btnsearchemp_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True"))
            {
                con.Open();

                // Retrieve salary data
                using (SqlCommand cmd = new SqlCommand("viewsal", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            txtempid.Text = rdr[0].ToString();
                            txtempname.Text = rdr[1].ToString();
                            txtnetsal.Text = rdr[5].ToString();
                        }
                    }
                }

                // Retrieve pay method data
                using (SqlCommand cmd1 = new SqlCommand("viewpaymethod", con))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr1 = cmd1.ExecuteReader())
                    {
                        if (rdr1.Read())
                        {
                            cmbpaymethod.Text = rdr1[3].ToString();
                            cmbbankname.Text = rdr1[4].ToString();
                            txtaccno.Text = rdr1[5].ToString();
                            txtcity.Text = rdr1[6].ToString();
                        }
                    }
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("pr_pmethod", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtempid.Text;
                        cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = txtempname.Text;
                        cmd.Parameters.Add("@netsalary", SqlDbType.NVarChar).Value = txtnetsal.Text;
                        cmd.Parameters.Add("@pmethod", SqlDbType.NVarChar).Value = cmbpaymethod.Text;
                        cmd.Parameters.Add("@bankname", SqlDbType.NVarChar).Value = cmbbankname.Text;
                        cmd.Parameters.Add("@accno", SqlDbType.NVarChar).Value = txtaccno.Text;
                        cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtcity.Text;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment details added successfully!!");
                    }
                }

                // The connection is automatically closed when leaving the 'using' block
                txtempid.Text = "";
                txtempname.Text = "";
                txtnetsal.Text = "";
                cmbpaymethod.SelectedIndex = 0;
                cmbbankname.SelectedIndex = 0;
                txtaccno.Text = "";
                txtcity.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void txtempid_Validating(object sender, CancelEventArgs e)
        {
            bool recfnd = false;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_pmethodvalidation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = "select";
                cmd.Parameters.Add("@employeeid", SqlDbType.Int).Value = Convert.ToInt32(txtempid.Text);
                cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@netsalary", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@pmethod", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@bankname", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@accno", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = "";

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    recfnd = true;
                    rdr.Read();
                    txtempname.Text = rdr["employeename"].ToString();
                    txtnetsal.Text = rdr["netsalary"].ToString();
                    cmbpaymethod.Text = rdr["pmethod"].ToString();
                    cmbbankname.Text = rdr["bankname"].ToString();
                    txtaccno.Text = rdr["accno"].ToString();
                    txtcity.Text = rdr["city"].ToString();
                }
                else
                {
                    recfnd = false;
                    txtempname.Text = "";
                    txtnetsal.Text = "";
                    cmbpaymethod.SelectedIndex = 0;
                    cmbbankname.SelectedIndex = 0;
                    txtaccno.Text = "";
                    txtcity.Text = "";
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
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from paymethod where employeeid=" + txtempid.Text;
                cmd.Connection.Open();
                int res = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (res > 0)
                {
                    MessageBox.Show("Record deleted successfully!!");
                    ClearControls(txtempid, Controls);
                    txtempname.Focus();
                }
                else
                    MessageBox.Show("Record can't be deleted!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }
    }
}
