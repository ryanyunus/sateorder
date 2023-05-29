using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderReceipt
{
    public partial class Billing : Form
    {
        Functions Con;
        public Billing()
        {
            Con = new Functions();
            InitializeComponent();
        }
        int Key = 0;
        int Price = 0;
        private void GetPrice(int Key)
        {
            string Pizza = "";
            if (Key == 1) 
            {
                Pizza = "Small";
            }else if(Key == 2)
            {
                Pizza = "Medium";
            }
            else if (Key == 2)
            {
                Pizza = "Large";
            }
            else if (Key == 2)
            {
                Pizza = "Extra Large";
            }
            string Query = "select * from SateTbl where Item = '{0}'";
            Query = string.Format(Query, Pizza);
           // Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());
            Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());

        }
        int n = 0;
        string Items;
        int GrdTotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(SmallBtn.Checked == true)
            {
                Key = 1;
                Items = "Small Sate";
            }else if(MediumBtn.Checked == true)
            {
                Key = 2;
                Items = "Medium Sate";
            }
            else if(LargeBtn.Checked == true)
            {
                Key = 3;
                Items = "Large Sate";
            }
            else if (ExtraLargeBtn.Checked == true)
            {
                Key = 4;
                Items = "Extra Large Sate";
            }
            GetPrice(Key);
            int Qty = Convert.ToInt32(QtyTb.Text);
            int total = Qty * Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDgv);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;
            BillDgv.Rows.Add(newRow);
            n++;
            GrdTotal = GrdTotal + total;
            GrdTotallbl.Text = "Rs " + GrdTotal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings Obj = new settings();
            Obj.Show();
            this.Hide();
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        
        
        int prodid, prodprice, prodqty, tottal, pos = 70;

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string prodname;

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SATE ORDERING", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            foreach (DataGridViewRow row in BillDgv.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(130, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total : RS" + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("******SATE***********" + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BillDgv.Rows.Clear();
            BillDgv.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
        }

       

    }
}
