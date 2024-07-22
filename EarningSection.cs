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
    public partial class EarningSection : BaseForm
    {
        bool recfnd = false;
        public EarningSection()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True");

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_earning", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtempid.Text;
                cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = txtempname.Text;
                cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = cmbdepartment.Text;
                cmd.Parameters.Add("@basicsal", SqlDbType.NVarChar).Value = txtbasicsal.Text;
                cmd.Parameters.Add("@incentive", SqlDbType.NVarChar).Value = txtincentive.Text;
                cmd.Parameters.Add("@overtimehr", SqlDbType.NVarChar).Value = txtovertimeht.Text;
                cmd.Parameters.Add("@overtimepay", SqlDbType.NVarChar).Value = txtovertimepay.Text;
                cmd.Parameters.Add("@totalearn", SqlDbType.NVarChar).Value = txttotalearn.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Earnings added successfully!!");
                con.Close();
                txtempid.Text = "";
                txtempname.Text = "";
                cmbdepartment.SelectedIndex = 0;
                txtbasicsal.Text = "";
                txtincentive.Text = "";
                txtovertimeht.Text = "";
                txtovertimepay.Text = "";
                txttotalearn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearchemp_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand cmd = new SqlCommand("viewemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                txtempid.Text = rdr[0].ToString();
                txtempname.Text = rdr[1].ToString();
                cmbdepartment.Text = rdr[2].ToString();
            }
            rdr.Close();
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("viewearn", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.Read())
            {
                txtbasicsal.Text = rdr1[3].ToString();
                txtincentive.Text = rdr1[4].ToString();
                txtovertimeht.Text = rdr1[5].ToString();
                txtovertimepay.Text = rdr1[6].ToString();
                txttotalearn.Text = rdr1[7].ToString();
            }
            rdr1.Close();
            con.Close();*/

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9IHNQBT;Initial Catalog=payroll;Integrated Security=True"))
            {
                con.Open();

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

                using (SqlCommand cmd1 = new SqlCommand("viewearn", con))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = txtsearchemp.Text;

                    using (SqlDataReader rdr1 = cmd1.ExecuteReader())
                    {
                        if (rdr1.Read())
                        {
                            txtbasicsal.Text = rdr1[3].ToString();
                            txtincentive.Text = rdr1[4].ToString();
                            txtovertimeht.Text = rdr1[5].ToString();
                            txtovertimepay.Text = rdr1[6].ToString();
                            txttotalearn.Text = rdr1[7].ToString();
                        }
                    }
                }
            }
        }

        private void txtovertimeht_Validating(object sender, CancelEventArgs e)
        {
            txtovertimepay.Text = ((common.cDouble(txtovertimeht.Text) * 500)).ToString();
            txttotalearn.Text = (common.cDouble(txtbasicsal.Text) + common.cDouble(txtincentive.Text) + common.cDouble(txtovertimepay.Text)).ToString();
        }
        
        private void txtempid_Validating(object sender, CancelEventArgs e)
        {
            bool recfnd = false;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_earningvalidation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = "select";
                cmd.Parameters.Add("@employeeid", SqlDbType.Int).Value = Convert.ToInt32(txtempid.Text);
                cmd.Parameters.Add("@employeename", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@basicsal", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@incentive", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@overtimehr", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@overtimepay", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@totalearn", SqlDbType.NVarChar).Value = "";

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    recfnd = true;
                    rdr.Read();
                    txtempname.Text = rdr["employeename"].ToString();
                    cmbdepartment.Text = rdr["department"].ToString();
                    txtbasicsal.Text = rdr["basicsal"].ToString();
                    txtincentive.Text = rdr["incentive"].ToString();
                    txtovertimeht.Text = rdr["overtimehr"].ToString();
                    txtovertimepay.Text = rdr["overtimepay"].ToString();
                    txttotalearn.Text = rdr["totalearn"].ToString();
                }
                else
                {
                    recfnd = false;
                    txtempname.Text = "";
                    cmbdepartment.SelectedIndex = 0;
                    txtbasicsal.Text = "";
                    txtincentive.Text = "";
                    txtovertimeht.Text = "";
                    txtovertimepay.Text = "";
                    txttotalearn.Text = "";
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
                cmd.CommandText = "delete from earning where employeeid=" + txtempid.Text;
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
