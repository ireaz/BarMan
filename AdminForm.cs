using BarMan.sourc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarMan
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
            LoadData();

        }
        public void btnDelete()
        {
            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "حذف";
            deleteButtonColumn.Image = Properties.Resources.Delete;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50; // تنظیم عرض ثابت
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // غیرفعال کردن تنظیم خودکار عرض
            DGVAdmins.Columns.Add(deleteButtonColumn);
            DGVAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void LoadData()
        {

            if (tbSerch.Text != "")
            {
                DGVAdmins.DataSource = AdminControll.FilterAdminName(tbSerch.Text);
            }
            else
            {
                DGVAdmins.DataSource = AdminControll.getUserAndIDAndRole();

            }
            if(DGVAdmins.Columns.Contains("UserID"))
            {
                DGVAdmins.Columns["UserID"].HeaderText = "شناسه کاربر";

                DGVAdmins.Columns["UserName"].HeaderText = "نام کاربر";
                DGVAdmins.Columns["Role"].HeaderText = "نقش کاربر";
            }
            
        }

        private void tbSerch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {


            btnDelete();
            LoadData();
            ClassDesign.CustomizeDataGridView(DGVAdmins);


        }

        private void DGVAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(DGVAdmins.Rows[e.RowIndex].Cells["UserID"].Value);
                string Name = DGVAdmins.Rows[e.RowIndex].Cells["UserName"].Value.ToString();

                if (e.ColumnIndex == DGVAdmins.Columns["Delete"].Index)
                {
                    if (AdminControll.isSingelRole() && DGVAdmins.Rows[e.RowIndex].Cells["Role"].Value.ToString() == "Admin")
                    {
                        MessageBox.Show("آخرین مدیر را نمیتون حذف کرد ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var result = MessageBox.Show($"\u202Bآیا از حذف {Name} اطمینان دارید؟ \u202C‬ ‬", "حذف کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            AdminControll.DeleteAdmin(id);
                            LoadData();

                        }
                    }
                }

            }
        }

        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { 
            this.Close();
            }
        }
    }
}
