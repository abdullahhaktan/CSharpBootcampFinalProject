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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            var user = db.Users.FirstOrDefault(u => u.Username == userName && u.Password==password);

            
            if (user!=null)
            {
                FrmDashboard frm = new FrmDashboard();
                frm.UserName = userName;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
