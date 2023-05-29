
namespace PizzaOrderReceipt
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExtraLargeBtn = new System.Windows.Forms.RadioButton();
            this.LargeBtn = new System.Windows.Forms.RadioButton();
            this.MediumBtn = new System.Windows.Forms.RadioButton();
            this.SmallBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.BillDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printbtn = new System.Windows.Forms.Button();
            this.GrdTotallbl = new System.Windows.Forms.Label();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 599);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sate Ordering System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExtraLargeBtn);
            this.panel2.Controls.Add(this.LargeBtn);
            this.panel2.Controls.Add(this.MediumBtn);
            this.panel2.Controls.Add(this.SmallBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(133, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 268);
            this.panel2.TabIndex = 7;
            // 
            // ExtraLargeBtn
            // 
            this.ExtraLargeBtn.AutoSize = true;
            this.ExtraLargeBtn.Location = new System.Drawing.Point(14, 181);
            this.ExtraLargeBtn.Name = "ExtraLargeBtn";
            this.ExtraLargeBtn.Size = new System.Drawing.Size(109, 26);
            this.ExtraLargeBtn.TabIndex = 4;
            this.ExtraLargeBtn.TabStop = true;
            this.ExtraLargeBtn.Text = "Extra Large";
            this.ExtraLargeBtn.UseVisualStyleBackColor = true;
            // 
            // LargeBtn
            // 
            this.LargeBtn.AutoSize = true;
            this.LargeBtn.Location = new System.Drawing.Point(14, 139);
            this.LargeBtn.Name = "LargeBtn";
            this.LargeBtn.Size = new System.Drawing.Size(67, 26);
            this.LargeBtn.TabIndex = 3;
            this.LargeBtn.TabStop = true;
            this.LargeBtn.Text = "Large";
            this.LargeBtn.UseVisualStyleBackColor = true;
            // 
            // MediumBtn
            // 
            this.MediumBtn.AutoSize = true;
            this.MediumBtn.Location = new System.Drawing.Point(14, 94);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(83, 26);
            this.MediumBtn.TabIndex = 2;
            this.MediumBtn.TabStop = true;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.UseVisualStyleBackColor = true;
            // 
            // SmallBtn
            // 
            this.SmallBtn.AutoSize = true;
            this.SmallBtn.Location = new System.Drawing.Point(14, 50);
            this.SmallBtn.Name = "SmallBtn";
            this.SmallBtn.Size = new System.Drawing.Size(63, 26);
            this.SmallBtn.TabIndex = 1;
            this.SmallBtn.TabStop = true;
            this.SmallBtn.Text = "small";
            this.SmallBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(23, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pilih Ukuran sate";
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderBtn.Location = new System.Drawing.Point(109, 439);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(232, 32);
            this.OrderBtn.TabIndex = 8;
            this.OrderBtn.Text = "tambahkan ke pesanan anda";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillDgv
            // 
            this.BillDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BillDgv.Location = new System.Drawing.Point(365, 102);
            this.BillDgv.Name = "BillDgv";
            this.BillDgv.Size = new System.Drawing.Size(526, 150);
            this.BillDgv.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(879, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(160, 407);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(100, 26);
            this.QtyTb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.printbtn.Location = new System.Drawing.Point(806, 439);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(119, 32);
            this.printbtn.TabIndex = 13;
            this.printbtn.Text = "cetak";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // GrdTotallbl
            // 
            this.GrdTotallbl.AutoSize = true;
            this.GrdTotallbl.Location = new System.Drawing.Point(789, 407);
            this.GrdTotallbl.Name = "GrdTotallbl";
            this.GrdTotallbl.Size = new System.Drawing.Size(91, 22);
            this.GrdTotallbl.TabIndex = 14;
            this.GrdTotallbl.Text = "GrdTotalLbl";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsBtn.Location = new System.Drawing.Point(109, 555);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(171, 32);
            this.SettingsBtn.TabIndex = 15;
            this.SettingsBtn.Text = "atur harga";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(465, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.GrdTotallbl);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BillDgv);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Billing";
            this.Text = "Billing";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ExtraLargeBtn;
        private System.Windows.Forms.RadioButton LargeBtn;
        private System.Windows.Forms.RadioButton MediumBtn;
        private System.Windows.Forms.RadioButton SmallBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.DataGridView BillDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Label GrdTotallbl;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}