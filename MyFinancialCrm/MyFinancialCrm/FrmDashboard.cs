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
using MyFinancialCrm.Models;
using System.Threading;

namespace MyFinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblZiraatBankBalance_Click(object sender, EventArgs e)
        {

        }
        public string UserName { get; set; }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance1.Text = totalBalance.ToString();
            
            var lastBankProcessAmount = db.BankProcesses.
            OrderByDescending(x=>x.BankProcessId).Select(y=>y.Amount).FirstOrDefault();

            lblBankLastProcessAmount.Text = lastBankProcessAmount.ToString();

            //Chart 1 Kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach(var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }
        
            //Chart 2 Kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            chart2.Series.Clear();
            
            var series2 = chart2.Series.Add("Faturalar");

            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach(var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if(count %4 == 1)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası")
                .Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text=elektrikFaturasi.ToString() + "₺";
            }

            if (count % 4 == 2)
            {
                var dogalgazFaturasi = db.Bills.Where(x=>x.BillTitle=="Doğalgaz Faturası")
                .Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = dogalgazFaturasi.ToString() + "₺";
            }

            if (count % 4 == 3)
            {
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası")
                .Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = suFaturasi.ToString() + "₺";
            }

            if (count % 4 == 0)
            {
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası")
                .Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = suFaturasi.ToString() + "₺";
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.UserName1 = UserName;
            frm.Show();
            this.Dispose();
        }
    }
}
