using BarMan.sourc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BarMan
{
    public partial class Login : Form
    {
        bool login = false;
        public Login()
        {
            InitializeComponent();
            TPasword.UseSystemPasswordChar = true;
            TUser.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islogin();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login == false)
                Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                if (TUser.Text == "")
                {
                    TUser.Select();


                }
                else if (TPasword.Text == "")
                {
                    TPasword.Select();

                }
                else
                    islogin();

            }
          else  if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public void islogin()
        {
            if (AdminControll.VerifyPassword(TUser.Text, TPasword.Text))
            {
                AdminControll.AdminRole = AdminControll.Role(TUser.Text);
                this.Close();

                login = true;

            }
            else if (TUser.Text == "" || TPasword.Text == "")
            { MessageBox.Show("نام کاربری یا رمز عبور خالی است !", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            { MessageBox.Show("نام کاربری یا رمز عبور اشتباه است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            TPasword.UseSystemPasswordChar = !checkBox1.Checked;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
