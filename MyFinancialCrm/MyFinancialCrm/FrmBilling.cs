using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        public List<Bills> ListFunc()
        {
            var values = db.Bills.ToList();

            return values;
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListFunc();
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = ListFunc();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();

            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi","Ödeme & Faturalar",MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = ListFunc();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int billId=int.Parse(txtBillid.Text);

            var bill = db.Bills.Find(billId);

            db.Bills.Remove(bill);
            db.SaveChanges();

            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = ListFunc();

            db.SaveChanges();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            int billId = int.Parse(txtBillid.Text);


            Bills bill = db.Bills.Find(billId);

            bill.BillPeriod = period;
            bill.BillAmount = amount;
            bill.BillTitle = title;

            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);


            db.SaveChanges();
            dataGridView1.DataSource = ListFunc();

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
