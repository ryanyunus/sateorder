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
    public partial class settings : Form
    {
        Functions Con;
        public settings()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Key;
            try
            {

                int Pr = Convert.ToInt32(PriceTb.Text);
                if(SateCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select A Sate!!!");
                }else if(SateCb.SelectedIndex == 0){
                    Key = "Extra Large";
                    string Query = "Update SateTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Update!!!");
                }else if(SateCb.SelectedIndex == 1)
                {
                    Key = "Large";
                    string Query = "Update SateTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Update!!!");

                }
                else if(SateCb.SelectedIndex == 2)
                {
                    Key = "Medium";
                    string Query = "Update SateTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Update!!!");

                }
                else if(SateCb.SelectedIndex == 3)
                {
                    Key = "Small";
                    string Query = "Update SateTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Update!!!");

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }
    }
}
