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
    public partial class NetPayCalculation : BaseForm
    {
        bool recfnd = false;
        public NetPayCalculation()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");
        private void btnsearchemp_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True"))
            {
                con.Open();

                // Retrieve employee data
                using (SqlCommand cmd = new SqlCommand("viewemp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            txtempid.Text = rdr[0].ToString();
                            txtempname.Text = rdr[1].ToString();
                            cmbdepartment.Text = rdr[2].ToString();
                        }
                    }
                }

                // Retrieve earning data
                using (SqlCommand cmd1 = new SqlCommand("viewearn", con))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr1 = cmd1.ExecuteReader())
                    {
                        if (rdr1.Read())
                        {
                            txttotalearn.Text = rdr1[7].ToString();
                        }
                    }
                }

                // Retrieve deduction data
                using (SqlCommand cmd2 = new SqlCommand("viewdeduct", con))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr2 = cmd2.ExecuteReader())
                    {
                        if (rdr2.Read())
                        {
                            txttotaldeduct.Text = rdr2[7].ToString();
                        }
                    }
                }

                // Retrieve salary data
                using (SqlCommand cmd3 = new SqlCommand("viewsal", con))
                {
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr3 = cmd3.ExecuteReader())
                    {
                        if (rdr3.Read())
                        {
                            txtnetsal.Text = rdr3[5].ToString();
                        }
                    }
                }
            }
        }

        private void txttotaldeduct_Validating(object sender, CancelEventArgs e)
        {
            txtnetsal.Text = (common.cDouble(txttotalearn.Text) - common.cDouble(txttotaldeduct.Text)).ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("pr_netsal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtempid.Text;
                        cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = txtempname.Text;
                        cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = cmbdepartment.Text;
                        cmd.Parameters.Add("@totalearn", SqlDbType.NVarChar).Value = txttotalearn.Text;
                        cmd.Parameters.Add("@totaldeduct", SqlDbType.NVarChar).Value = txttotaldeduct.Text;
                        cmd.Parameters.Add("@netsalary", SqlDbType.NVarChar).Value = txtnetsal.Text;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Salary details added successfully!!");
                    }
                }

                txtempid.Text = "";
                txtempname.Text = "";
                cmbdepartment.SelectedIndex = 0;
                txttotalearn.Text = "";
                txttotaldeduct.Text = "";
                txtnetsal.Text = "";
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
                SqlCommand cmd = new SqlCommand("pr_netpayvalidation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = "select";
                cmd.Parameters.Add("@employeeid", SqlDbType.Int).Value = Convert.ToInt32(txtempid.Text);
                cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@totalearn", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@totaldeduct", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@netsalary", SqlDbType.NVarChar).Value = "";

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    recfnd = true;
                    rdr.Read();
                    txtempname.Text = rdr["employeename"].ToString();
                    cmbdepartment.Text = rdr["department"].ToString();
                    txttotalearn.Text = rdr["totalearn"].ToString();
                    txttotaldeduct.Text = rdr["totaldeduct"].ToString();
                    txtnetsal.Text = rdr["netsalary"].ToString();
                }
                else
                {
                    recfnd = false;
                    txtempname.Text = "";
                    cmbdepartment.SelectedIndex = 0;
                    txttotalearn.Text = "";
                    txttotaldeduct.Text = "";
                    txtnetsal.Text = "";
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
                cmd.CommandText = "delete from netpay where employeeid=" + txtempid.Text;
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
