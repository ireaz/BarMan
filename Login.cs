using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarMan
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Login(TUser.Text, TPasword.Text))
            {


                this.Close();




            }
            else
            { MessageBox.Show("نام کاربری یا رمز عبور اشتباه است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
