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
using System.Windows.Forms.DataVisualization.Charting;

namespace MyFinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        public List<Categories> ListFunc()
        {
            var values = db.Categories.ToList();

            return values;
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void btnListCategory_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListFunc();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            Categories ctgr = new Categories();

            ctgr.CategoryName = categoryName;

            db.Categories.Add(ctgr);
            db.SaveChanges();

            dataGridView1.DataSource = ListFunc();

            MessageBox.Show("kategori ekleme işlemi yapıldı", "Kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListFunc();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryId.Text);

            var category = db.Categories.Where(x=>x.CategoryId==categoryId).FirstOrDefault();
            db.Categories.Remove(category);

            db.SaveChanges();

            MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemden Silindi", "kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = ListFunc();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string title = txtCategoryName.Text;

            int categoryId = int.Parse(txtCategoryId.Text);
            var categoryName = txtCategoryName.Text;

            var bill = db.Categories.Where(x=>x.CategoryId==categoryId).FirstOrDefault();

            bill.CategoryName=categoryName;

            db.SaveChanges();

            MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemde Güncellendi", "Kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = ListFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
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
