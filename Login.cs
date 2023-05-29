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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }else if(UnameTb.Text == "User" && PasswordTb.Text == "Pass")
            {
                Billing Obj = new Billing();
                Obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Data !!!");
            }
        }
    }
}
