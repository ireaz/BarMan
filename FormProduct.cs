using BarMan.Models;
using BarMan.sourc;
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

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

            ClassDesign.ButtenDelet(DGVProduct);
            ClassDesign.ButtenEdit(DGVProduct);
            ClassDesign.CustomizeDataGridView(DGVProduct);
            ProductControll.DataGV(DGVProduct);
            ProductControll.GetProductWithCategoryName();


            CategoryControll.CategoryComboBox(CBCtegories);

        }  
        private void textSerchProduct_TextChanged(object sender, EventArgs e)
        {
            DGVProduct.DataSource = ProductControll.FilterProducts(textSerchProduct.Text.ToString());
        }

        private void DGVProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DGVProduct.Columns["Delete"].Index)
                {    // گرفتن اطلاعات سطر انتخاب شده
                    var row = DGVProduct.Rows[e.RowIndex];

                    // اگر می‌خواهید اطلاعات ردیف را برای عملیات حذف داشته باشید:
                    var productName = row.Cells["ProductName"].Value.ToString();
                    var productStock = row.Cells["ProductStock"].Value.ToString();

                    // تایید حذف از کاربر
                    var result = MessageBox.Show($"آیا از حذف {productName} اطمینان دارید؟", "حذف محصول", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // عملیات حذف محصول (با توجه به نیاز خود می‌توانید از دیتابیس حذف کنید)
                        // فرض کنید که متد DeleteProduct را برای حذف محصول از دیتابیس دارید
                        DbContextHelper.Delete(ProductControll.FindProductByName(productName));  // حذف محصول بر اساس نام یا شناسه

                       
                        ProductControll.DataGV(DGVProduct);
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
                    ProductControll.DataGV(DGVProduct);



                }



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCategory category = new FormCategory();
            
            this.TopMost = false;
            this.Hide();

           category.ShowDialog();
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "")
            {
                string ProductName = TBName.Text.ToString();

                if (ProductControll.IsProductNameAvailable(ProductName))
                {
                    int ProductStock = (int)NumberProduct.Value;
                    int CategoryIdnew = (int)CBCtegories.SelectedValue;

                    if (ProductControll.AddProduct(ProductName, ProductStock, CategoryIdnew))
                    {
                        ProductControll.DataGV(DGVProduct);

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
            { MessageBox.Show("نام محصول خالی است", "هشدار"); }




        }
    }
}
