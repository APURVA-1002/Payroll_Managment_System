using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMngmentSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnaddemp_Click(object sender, EventArgs e)
        {
            AddEmpDetails f = new AddEmpDetails();
            f.Show();
        }

        private void btnviewemp_Click(object sender, EventArgs e)
        {
            ViewEmpDetails f = new ViewEmpDetails();
            f.Show();
        }

        private void btnearn_Click(object sender, EventArgs e)
        {
            EarningSection f = new EarningSection();
            f.Show();
        }

        private void btndeduct_Click(object sender, EventArgs e)
        {
            DeductionSection f = new DeductionSection();
            f.Show();
        }

        private void btnnetpay_Click(object sender, EventArgs e)
        {
            NetPayCalculation f = new NetPayCalculation();
            f.Show();
        }

        private void btnpaymethod_Click(object sender, EventArgs e)
        {
            PaymentMethod f = new PaymentMethod();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewEmpIncomeDetails f = new ViewEmpIncomeDetails();
            f.Show();
        }

        private void btnviewearn_Click(object sender, EventArgs e)
        {
            ViewEarningSection f = new ViewEarningSection();
            f.Show();
        }

        private void btnviewdeduct_Click(object sender, EventArgs e)
        {
            ViewDeductionSection f = new ViewDeductionSection();
            f.Show();
        }

        private void btnviewnetpay_Click(object sender, EventArgs e)
        {
            ViewNetPayCalculation f = new ViewNetPayCalculation();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
