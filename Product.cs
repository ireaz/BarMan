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
    public partial class EditProduct : Form
    {
        private string productName;
        private int productId;
        private int productnumber;
        private int categoryId;
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            Tproductname.Text = productName;
            ProductNumber.Value = productnumber;
            CategoryControll.CategoryComboBox(CBCategory);
            CBCategory.SelectedIndex = categoryId;

        }


        public EditProduct(string name, int Stock, int productid, int categoryid)
        {
            InitializeComponent();
            productName = name;
            productId = productid;
            productnumber = Stock;
            categoryId = categoryid-1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Tproductname.Text != "")
            {
                ProductControll.UpdateProduct(productId, Tproductname.Text, (int)ProductNumber.Value, (int)CBCategory.SelectedValue);
                MessageBox.Show("ویرایش شد ", "هشدار");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                MessageBox.Show("اسم محصول خالی است ", "هشدار");

            }


        }

        private void btncCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
