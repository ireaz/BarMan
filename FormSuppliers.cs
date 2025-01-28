using BarMan.Models;
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
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
        }

        private void pbAddSuppliers_Click(object sender, EventArgs e)
        {
            FormSuppliers_Add_Edit formSuppliers_Add_Edit = new FormSuppliers_Add_Edit();
            formSuppliers_Add_Edit.ShowDialog();
            LodSuppliersData();

        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            ClassDesign.CustomizeDataGridView(DGVSuppliers);
            ClassDesign.AddButtonsToGrid(DGVSuppliers);

            LodSuppliersData();
            cbSerch.SelectedIndex = 0;
        }


        public void LodSuppliersData()
        {
            if (tbSerchSuppliers.Text != "")
            {
                Serch();
            }
            else
            {
                DGVSuppliers.DataSource = SuppliersControll.GetSupplier();

            }




        }

        public void Serch()
        {
            switch (cbSerch.SelectedIndex)
            {
                case 0:
                    DGVSuppliers.DataSource = SuppliersControll.FilterSuppliersName(tbSerchSuppliers.Text);
                    break;
                case 1:
                    DGVSuppliers.DataSource = SuppliersControll.FilterSuppliersTell(tbSerchSuppliers.Text);
                    break;
                case 2:
                    DGVSuppliers.DataSource = SuppliersControll.FilterSuppliersIdCod(tbSerchSuppliers.Text);
                    break;
                case 3:
                    DGVSuppliers.DataSource = SuppliersControll.FilterSuppliersEmail(tbSerchSuppliers.Text);
                    break;
                default:

                    break;
            }

        }

        private void tbSerchSuppliers_TextChanged(object sender, EventArgs e)
        {
            Serch();
        }



        private void DGVSuppliers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string SuppliersName = DGVSuppliers.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                string SuppliersIdCod = DGVSuppliers.Rows[e.RowIndex].Cells["Supplier_ID_Code"].Value.ToString();
                if (e.ColumnIndex == DGVSuppliers.Columns["Delete"].Index)
                {    // گرفتن اطلاعات سطر انتخاب شده
                    var result = MessageBox.Show($"آیا از حذف {SuppliersName} اطمینان دارید؟ تمام رکورد های مربوت به این خریدار حذف میشوند ", "حذف راننده", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DbContextHelper.Delete(SuppliersControll.FindSuppliersByIDCode(SuppliersIdCod));
                        LodSuppliersData();
                        DatabaseManager.DeleteAll(SuppliersControll.GetSupplierID_With_Supplier_ID_Code(SuppliersIdCod), "Suppliers");

                    }
                }

                else if (e.ColumnIndex == DGVSuppliers.Columns["Edit"].Index)
                {
                    Suppliers driver = SuppliersControll.FindSuppliersByIDCode(SuppliersIdCod);

                    FormSuppliers_Add_Edit formSuppliers_Edit = new FormSuppliers_Add_Edit(driver.SupplierID,
                        driver.SupplierName,
                        driver.Supplier_ID_Code,
                        driver.ContactNumber,
                        driver.Email,
                        driver.Description);


                    formSuppliers_Edit.ShowDialog();
                    LodSuppliersData();
                }
            }
        }

        private void DGVSuppliers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DGVSuppliers.Columns["SupplierName"] != null || DGVSuppliers.Columns["Supplier_ID_Code"] != null)
            {
                DGVSuppliers.Columns["SupplierName"].HeaderText = "نام تامین‌کننده";
                DGVSuppliers.Columns["Supplier_ID_Code"].HeaderText = "کد ملی تامین‌کننده";
                DGVSuppliers.Columns["ContactNumber"].HeaderText = "شماره تماس تامین‌کننده";
                DGVSuppliers.Columns["Email"].HeaderText = "ایمیل تامین‌کننده";
                DGVSuppliers.Columns["Description"].HeaderText = "توضیحات";
            }

        }

        private void FormSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
