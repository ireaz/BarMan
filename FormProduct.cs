using BarMan.Models;
using BarMan.sourc;
using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BarMan
{
    public partial class FormProduct : Form
    {
        public bool A;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

            ClassDesign.AddButtonsToGrid(DGVProduct);

            ClassDesign.CustomizeDataGridView(DGVProduct);
            A = false;

            LodDGV();

            CBLod();







        }
        private void textSerchProduct_TextChanged(object sender, EventArgs e)
        {
            DGVProduct.DataSource = ProductControll.FilterProducts(textSerchProduct.Text.ToString());
        }
        public void CBLod()
        {
            var Category = CategoryControll.GetCategor_ID_Name();
            if (Category != null && Category.Count > 0)
            {
                CBCtegories.DataSource = Category;
                CBCtegories.DisplayMember = "CategoryName";
                CBCtegories.ValueMember = "CategoryID";

            }
            else if (A == false)
            {
                MessageBox.Show("دسته بندی خالی استت دسته بندی را پر کنید ");
                ShowCategoryForm();
                A = true;

            }


        }


        private void DGVProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DGVProduct.Columns["Delete"].Index)
                {    // گرفتن اطلاعات سطر انتخاب شده
                    var row = DGVProduct.Rows[e.RowIndex];

                    //نگه داشتن اطلاعات کالا قبل از حذف 
                    var productName = row.Cells["ProductName"].Value.ToString();
                    var productStock = row.Cells["ProductStock"].Value.ToString();

                    // تایید حذف از کاربر
                    var result = MessageBox.Show($"آیا از حذف {productName} اطمینان دارید؟", "حذف محصول", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        DbContextHelper.Delete(ProductControll.FindProductByName(productName));  // حذف محصول بر اساس نام یا شناسه


                        LodDGV();


                        DatabaseManager.DeleteAll(ProductControll.GetProductID_With_Name(productName), "Product");

                    }
                }


                if (e.ColumnIndex == DGVProduct.Columns["Edit"].Index)
                {
                    // var result = MessageBox.Show($"آیا از حذف  اطمینان دارید؟", "حذف محصول", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    this.TopMost = false;





                    var row = DGVProduct.Rows[e.RowIndex];
                    var productName = row.Cells["ProductName"].Value.ToString();

                    int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                    int productstock = (int)Convert.ToInt32(row.Cells["ProductStock"].Value);
                    int CategoryId = (int)Convert.ToInt32(row.Cells["CategoryId"].Value);

                    // ارسال اطلاعات به فرم EditProduct
                    EditProduct editProduct = new EditProduct(productName, productstock, productId, CategoryId);



                    var result = editProduct.ShowDialog();
                    if (result == DialogResult.OK)
                        LodDGV();



                }



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowCategoryForm();
            CBLod();

        }
        //دسترو ADD
        private void button2_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "")
            {
                string ProductName = TBName.Text.ToString();
                if (CBCtegories != null)
                {
                    if (ProductControll.IsProductNameAvailable(ProductName))
                    {
                        int ProductStock = (int)NumberProduct.Value;
                        int CategoryIdnew = (int)CBCtegories.SelectedValue;

                        if (ProductControll.AddProduct(ProductName, ProductStock, CategoryIdnew))
                        {
                            LodDGV();

                            MessageBox.Show("محصول ثبت شد", "هشدار");

                        }
                        else { MessageBox.Show("مشکل در ثبت محصول", "هشدار"); }

                    }
                    else
                    {
                        MessageBox.Show("این محصول وجود دارد", "هشدار");

                    }
                }
                else
                {
                    MessageBox.Show("دسته بندی خالی است اول دسته بندی ثبت کنید ", "هشدار");
                    ShowCategoryForm();
                }


            }

            else
            { MessageBox.Show("نام محصول خالی است", "هشدار"); }




        }

        private void DGVProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DGVProduct.Columns["ProductID"].Visible = false;
            DGVProduct.Columns["CategoryID"].Visible = false;



            if (DGVProduct.Columns["ProductName"] == null)
            {
                DGVProduct.Columns.Add("ProductName", "نام کالا");
            }
            if (DGVProduct.Columns["ProductStock"] == null)
            {
                DGVProduct.Columns.Add("ProductStock", "موجودی کالا");
            }
            if (DGVProduct.Columns["CategoryName"] == null)
            {
                DGVProduct.Columns.Add("CategoryName", "نام دسته‌بندی");
            }

            // تنظیم نام ستون‌ها
            DGVProduct.Columns["ProductName"].HeaderText = "نام کالا";
            DGVProduct.Columns["ProductStock"].HeaderText = "موجودی کالا";
            DGVProduct.Columns["CategoryName"].HeaderText = "نام دسته‌بندی";
        }


        private void LodDGV()
        {
            ProductControll.GetProductsSortedByCategory();
            if (textSerchProduct.Text != "")
            {

                DGVProduct.DataSource = ProductControll.FilterProducts(textSerchProduct.Text.ToString());


            }
            else
            {
                DGVProduct.DataSource = ProductControll.GetProductsSortedByCategory();
            }




        }
        public void ShowCategoryForm()
        {
            FormCategory category = new FormCategory();

            this.TopMost = false;
            this.Hide();

            category.ShowDialog();
            CategoryControll.CategoryData = null;
            LodDGV();
            this.Show();

        }

        private void FormProduct_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void za(object sender, EventArgs e)
        {

        }

        private void textSerchProduct_TextChanged_1(object sender, EventArgs e)
        {
            DGVProduct.DataSource = ProductControll.FilterProducts(textSerchProduct.Text.ToString());
            
        }
    }
}
