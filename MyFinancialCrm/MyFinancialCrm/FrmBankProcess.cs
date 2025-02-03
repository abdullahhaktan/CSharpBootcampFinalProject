using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        public void ListBankProcess()
        {
            var values = db.BankProcesses
                .Select(bp => new
                {
                    bp.BankProcessId,
                    bp.Description,
                    BankTitle = bp.Banks.BankTitle, // BankId yerine BankTitle geliyor
                    bp.ProcessType,
                    bp.Amount,
                    bp.ProcessDate
                }).ToList();

            dataGridView1.DataSource = values;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int bankProcessId = int.Parse(txtBankProcessId.Text);

            BankProcesses bankProcess = db.BankProcesses.Find(bankProcessId);

            db.BankProcesses.Remove(bankProcess);

            db.SaveChanges();

            MessageBox.Show("Banka İşlemi ekleme yapıldı", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            DateTime tarih = dateTimePicker1.Value;
            string islemTipi = txtProcessType.Text;
            string islemMiktari = txtAmount.Text;
            int bank = (int) cmbBank.SelectedValue;

            BankProcesses bankProcesses = new BankProcesses();

            bankProcesses.Description = description;
            bankProcesses.Amount = int.Parse(islemMiktari);
            bankProcesses.BankId = bank;
            bankProcesses.ProcessDate = tarih;
            bankProcesses.ProcessType = txtProcessType.Text;

            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();

            MessageBox.Show("İşlem Başarılı Bir Şekilde Sisteme Eklendi", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListBankProcess();
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            ListBankProcess();
        }

        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            ListBankProcess();

            var bankalar = db.Banks
                .Select(b => new { b.BankId, b.BankTitle }).ToList();

            cmbBank.DataSource = bankalar;
            cmbBank.DisplayMember = "BankTitle";
            cmbBank.ValueMember = "BankId";

        }

        private void btnUpdateProcess_Click(object sender, EventArgs e)
        {
            int processId = int.Parse(txtBankProcessId.Text);
            BankProcesses bankProcess = db.BankProcesses.Where(x => x.BankProcessId == processId).FirstOrDefault();

            bankProcess.Description = txtDescription.Text;
            bankProcess.ProcessDate = dateTimePicker1.Value;
            bankProcess.ProcessType = txtProcessType.Text;
            bankProcess.BankId = (int)cmbBank.SelectedValue;

            db.SaveChanges();

            MessageBox.Show("Gider Güncelleme işlemi yapıldı", "Gider İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListBankProcess();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();  
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
