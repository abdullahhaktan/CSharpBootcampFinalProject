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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        public string UserName1 { get; set; }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var user = db.Users.Where(u => u.Username == UserName1).FirstOrDefault();

            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtUserName.Text = UserName1;
            txtPassword.Text = user.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users value = db.Users.Where(u => u.Username == UserName1).FirstOrDefault();

            value.Username = txtUserName.Text;
            value.Password = txtPassword.Text;
            value.Surname = txtSurname.Text;
            value.Name = txtName.Text;

            db.SaveChanges();

            MessageBox.Show("Güncelleme Başarılı Şekilde Yapıldı", "Kullanıcı Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
    }
}
