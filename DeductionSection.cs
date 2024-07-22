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
    public partial class DeductionSection : BaseForm
    {
        bool recfnd = false;
        public DeductionSection()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");

        private void btnadddeduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("pr_deduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtempid.Text;
                        cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = txtempname.Text;
                        cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = cmbdepartment.Text;
                        cmd.Parameters.Add("@incometax", SqlDbType.NVarChar).Value = txtitax.Text;
                        cmd.Parameters.Add("@socialsecurity", SqlDbType.NVarChar).Value = txtsosecurity.Text;
                        cmd.Parameters.Add("@healthinsurance", SqlDbType.NVarChar).Value = txthealth.Text;
                        cmd.Parameters.Add("@retirementcontri", SqlDbType.NVarChar).Value = txtretirement.Text;
                        cmd.Parameters.Add("@totaldeduct", SqlDbType.NVarChar).Value = txttotaldeduct.Text;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deduction added successfully!!");
                    }
                }

                txtempid.Text = "";
                txtempname.Text = "";
                cmbdepartment.SelectedIndex = 0;
                txtitax.Text = "";
                txtsosecurity.Text = "";
                txthealth.Text = "";
                txtretirement.Text = "";
                txttotaldeduct.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsearchemp_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True"))
            {
                con.Open();

                // First query
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

                // Second query
                using (SqlCommand cmd2 = new SqlCommand("viewdeduct", con))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr2 = cmd2.ExecuteReader())
                    {
                        if (rdr2.Read())
                        {
                            txtitax.Text = rdr2[3].ToString();
                            txtsosecurity.Text = rdr2[4].ToString();
                            txthealth.Text = rdr2[5].ToString();
                            txtretirement.Text = rdr2[6].ToString();
                            txttotaldeduct.Text = rdr2[7].ToString();
                        }
                    }
                }
            }
        }

        private void txtretirement_Validating(object sender, CancelEventArgs e)
        {
            txttotaldeduct.Text = (common.cDouble(txtitax.Text) + common.cDouble(txtsosecurity.Text) + common.cDouble(txthealth.Text) + common.cDouble(txtretirement.Text)).ToString();
        }

        private void txtempid_Validating(object sender, CancelEventArgs e)
        {
            bool recfnd = false;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_deductvalidation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = "select";
                cmd.Parameters.Add("@employeeid", SqlDbType.Int).Value = Convert.ToInt32(txtempid.Text);
                cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@incometax", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@socialsecurity", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@healthinsurance", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@retirementcontri", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@totaldeduct", SqlDbType.NVarChar).Value = "";

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    recfnd = true;
                    rdr.Read();
                    txtempname.Text = rdr["employeename"].ToString();
                    cmbdepartment.Text = rdr["department"].ToString();
                    txtitax.Text = rdr["incometax"].ToString();
                    txtsosecurity.Text = rdr["socialsecurity"].ToString();
                    txthealth.Text = rdr["healthinsurance"].ToString();
                    txtretirement.Text = rdr["retirementcontri"].ToString();
                    txttotaldeduct.Text = rdr["totaldeduct"].ToString();
                }
                else
                {
                    recfnd = false;
                    txtempname.Text = "";
                    cmbdepartment.SelectedIndex = 0;
                    txtitax.Text = "";
                    txtsosecurity.Text = "";
                    txthealth.Text = "";
                    txtretirement.Text = "";
                    txttotaldeduct.Text = "";
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
                cmd.CommandText = "delete from deduction where employeeid=" + txtempid.Text;
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
