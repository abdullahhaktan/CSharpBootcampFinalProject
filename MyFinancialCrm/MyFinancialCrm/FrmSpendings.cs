using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        public void listSpendings()
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            listSpendings();

            var kategoriler = db.Categories
            .Select(k => new { k.CategoryId, k.CategoryName }) // Sadece gerekli alanları alıyoruz
            .ToList();


            cmbKategori.DataSource = kategoriler; // Verileri bağla
            cmbKategori.DisplayMember = "CategoryName"; // Kullanıcıya görünen kısım
            cmbKategori.ValueMember = "CategoryId"; // Seçildiğinde gelecek değer

            var harcamaSayisiList = db.Spendings
                .GroupBy(x => x.Categories.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    CategoryCount = g.Count()
                }).ToList();
            
            chart1.Series.Clear();

            var values = chart1.Series.Add("Gider Sayısı");

            foreach(var item in harcamaSayisiList)
            {
                values.Points.AddXY(item.CategoryName, item.CategoryCount);
            }

            var harcamaToplamList = db.Spendings
                .GroupBy(x => x.Categories.CategoryName)
                .Select(item => new
                {
                    CategoryName = item.Key,
                    CategorySum = item.Sum(x=>x.SpendingAmount)
                }).ToList();

            chart2.Series.Clear();

            var values1 = chart2.Series.Add("Gider Miktarı");

            foreach(var item in harcamaToplamList)
            {
                values1.Points.AddXY(item.CategoryName, item.CategorySum);
            }

        }

        private void btnAddSpending_Click(object sender, EventArgs e)
        {
            string spendingTitle = txtSpendingTitle.Text;
            string spendingAmount =  txtSpendingAmount.Text;
            DateTime dateTime = dateTimePicker1.Value;

            Spendings spending = new Spendings();

            spending.SpendingDate = dateTime;
            spending.SpendingTitle = spendingTitle;
            spending.SpendingAmount = int.Parse(spendingAmount);
            spending.CategoryId = (int)cmbKategori.SelectedValue;
            
            db.Spendings.Add(spending);
            db.SaveChanges();


            MessageBox.Show("Gider ekleme işlemi yapıldı", "Gider İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listSpendings();
        }

        private void btnListSpending_Click(object sender, EventArgs e)
        {
            listSpendings();
        }

        private void btnDeleteSpending_Click(object sender, EventArgs e)
        {
            int spendingId = int.Parse(txtSpendingId.Text);
            Spendings spending = db.Spendings.Where(x=>x.SpendingId==spendingId).FirstOrDefault();

            db.Spendings.Remove(spending);
            db.SaveChanges();

            MessageBox.Show("Gider silme işlemi yapıldı", "Gider İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listSpendings();
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int spendingId = int.Parse(txtSpendingId.Text);
            Spendings spending = db.Spendings.Where(x => x.SpendingId == spendingId).FirstOrDefault();

            spending.SpendingTitle = txtSpendingTitle.Text;
            spending.SpendingDate = dateTimePicker1.Value;
            spending.SpendingAmount = int.Parse(txtSpendingAmount.Text);
            spending.CategoryId = (int)cmbKategori.SelectedValue;

            db.SaveChanges();

            MessageBox.Show("Gider Güncelleme işlemi yapıldı", "Gider İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listSpendings();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpending = new FrmSpendings();
            frmSpending.Show();
            this.Hide();
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
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
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
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
