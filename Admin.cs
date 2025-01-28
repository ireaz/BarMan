using BarMan.sourc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarMan
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser();

        }

        private void Admin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AddUser(); break;
                case Keys.Escape:
                    this.Close(); break;

            }
        }

        public void AddUser()
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("لطفا نام کاربر و رمز را پرکنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (AdminControll.IsAdminEmpty() && comboBox1.SelectedIndex == 1)
                { MessageBox.Show("اولین کاربر باید ادمین باشد . \n لطفن نقش کاربر رو Admin انتخاب کنید  ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    if (!AdminControll.IsAdmin(textBox1.Text))
                    {
                        BarMan.Models.Admin admin = new BarMan.Models.Admin
                        {
                            UserName = textBox1.Text,
                            Password = AdminControll.HashPassword(textBox2.Text),
                            Role = comboBox1.Text
                        };



                        DbContextHelper.Add(admin);
                        this.Close();
                    }
                    else MessageBox.Show("این نام کاربری وجود دارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPasword_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !cbPasword.Checked;
        }
    }
}
