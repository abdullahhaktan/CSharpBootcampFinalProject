namespace MyFinancialCrm
{
    partial class FrmBilling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnNewBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 448);
            this.panel1.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Navy;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(8, 387);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(241, 36);
            this.button8.TabIndex = 7;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Navy;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(8, 333);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(241, 36);
            this.button7.TabIndex = 6;
            this.button7.Text = "Ayarlar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(8, 282);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(8, 225);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(8, 172);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(8, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Navy;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBanksForm.Location = new System.Drawing.Point(8, 65);
            this.btnBanksForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(241, 36);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(8, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnUpdateBill);
            this.panel2.Controls.Add(this.btnDeleteBill);
            this.panel2.Controls.Add(this.btnNewBill);
            this.panel2.Controls.Add(this.btnBillList);
            this.panel2.Controls.Add(this.txtBillPeriod);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBillid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(263, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 212);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateBill.Location = new System.Drawing.Point(492, 161);
            this.btnUpdateBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(146, 36);
            this.btnUpdateBill.TabIndex = 11;
            this.btnUpdateBill.Text = "Ödeme Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteBill.Location = new System.Drawing.Point(358, 161);
            this.btnDeleteBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(130, 36);
            this.btnDeleteBill.TabIndex = 10;
            this.btnDeleteBill.Text = "Ödeme Sil";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnNewBill
            // 
            this.btnNewBill.BackColor = System.Drawing.Color.Silver;
            this.btnNewBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewBill.Location = new System.Drawing.Point(224, 161);
            this.btnNewBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(130, 36);
            this.btnNewBill.TabIndex = 9;
            this.btnNewBill.Text = "Yeni Ödeme";
            this.btnNewBill.UseVisualStyleBackColor = false;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.Color.Silver;
            this.btnBillList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBillList.Location = new System.Drawing.Point(90, 161);
            this.btnBillList.Margin = new System.Windows.Forms.Padding(2);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(130, 36);
            this.btnBillList.TabIndex = 8;
            this.btnBillList.Text = "Ödeme Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBillPeriod.Location = new System.Drawing.Point(128, 118);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(541, 26);
            this.txtBillPeriod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periyot:";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBillAmount.Location = new System.Drawing.Point(128, 86);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(541, 26);
            this.txtBillAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBillTitle.Location = new System.Drawing.Point(128, 54);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(541, 26);
            this.txtBillTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık:";
            // 
            // txtBillid
            // 
            this.txtBillid.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBillid.Location = new System.Drawing.Point(128, 22);
            this.txtBillid.Name = "txtBillid";
            this.txtBillid.Size = new System.Drawing.Size(541, 26);
            this.txtBillid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme ID:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(263, 218);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(737, 230);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(734, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1002, 444);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme & Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}