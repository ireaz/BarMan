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
    public partial class FormCategory : Form
    {
        private Category CategoryItem = new Category();
        private int categoryid;
        private string categoryname;
        private int parentcategoryid;




        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            ClassDesign.CustomizeDataGridView(DGVCategory);
            ClassDesign.AddButtonsToGrid(DGVCategory);

            //  DGVCategory.DataSource = CategoryControll.GetAllCategory();

            tabPage2.Hide();
            tabControl1.TabPages.Remove(tabPage2);

            CategoryControll.CategoryComboBox(cbParentEdit);
            CategoryControll.CategoryComboBox(cbParent);




            DGVCategory.DataSource = CategoryControll.GetAllCategory();



        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (Cname.Text != "")
            {

                if (CategoryControll.IsCategoryNameAvailable(Cname.Text))
                {
                    if (cbParent.FindStringExact(cbParent.Text) != -1 && cbParent.Text != "هیچی")
                        CategoryControll.AddCategory(
                       Cname.Text, (int)cbParent.SelectedValue
                        );

                    else
                        CategoryControll.AddCategory(
                 Cname.Text
                  );

                }
                else
                    MessageBox.Show("این دسته بندی وجود دارد " + Cname.Text, "هشدار");


            }
            else { MessageBox.Show("اسم دسته بندی خالی است !", "هشدار"); }

            LodDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textEdit.Text != "")
            {
                if (CategoryControll.IsCategoryNameAvailable(textEdit.Text) || cbParentEdit.Text != textEdit.Text)
                {
                    if (cbParentEdit.FindStringExact(cbParentEdit.Text) != -1 && cbParentEdit.Text != "هیچی" && cbParentEdit.Text != null)
                    {
                        CategoryControll.UpdateCategory(
                  categoryid, textEdit.Text, (int)cbParentEdit.SelectedValue
                    ); MessageBox.Show("ssssssss");
                    }
                    else
                        CategoryControll.UpdateCategory(
                            categoryid,
                            textEdit.Text
                                       );



                    LodDGV();//لود دیتا گرد ویو
                }
                else
                { MessageBox.Show("این دسته بندی با والد  " + cbParentEdit.Text + "وجود دارد ", "هشدار"); }

            }
            else { MessageBox.Show("اسم دسته بندی خالی است !", "هشدار"); }



            ClassDesign.HindenTabPages(tabControl1, tabPage2, tabPage1);
        }

        private void DGVCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DGVCategory.Columns["Delete"].Index)
                {    // گرفتن اطلاعات سطر انتخاب شده
                    var row = DGVCategory.Rows[e.RowIndex];

                    //نگه داشتن اطلاعات کالا قبل از حذف 
                    var categoryName = row.Cells["CategoryName"].Value.ToString();


                    // تایید حذف از کاربر
                    var result = MessageBox.Show($"آیا از حذف {categoryName} اطمینان دارید؟", "حذف محصول", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        // حذف رکورد از دیتابیس
                        var categoryToDelete = CategoryControll.FindCategoryByName(categoryName);
                        DbContextHelper.Delete(categoryToDelete);

                        LodDGV();

                        DatabaseManager.DeleteAll(CategoryControll.GetCategoryID_With_Name(categoryName), "Category");


                    }
                }







                if (e.ColumnIndex == DGVCategory.Columns["Edit"].Index)
                {
                    if (tabControl1.TabPages.Contains(tabPage1))
                    {
                        ClassDesign.HindenTabPages(tabControl1, tabPage1, tabPage2);


                    }




                    categoryname = DGVCategory.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();





                    Category CategoryItem = CategoryControll.GetCategoryByName(categoryname);
                    if (CategoryItem != null)
                    {




                        textEdit.Text = categoryname;
                        parentcategoryid = Convert.ToInt32(CategoryItem.ParentCategoryID);
                        cbParentEdit.SelectedValue = parentcategoryid;
                        categoryid = Convert.ToInt32((int)CategoryItem.CategoryID);


                    }
                    else
                    { MessageBox.Show("سطر انتخابی خالی است "); }




                }


            }
        }

        private void DGVCategory_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            // 
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

            DGVCategory.DataSource = CategoryControll.FilterProducts(textBox1.Text);
        }

        private void DGVCategory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (DGVCategory.Columns["CategoryName"] != null && DGVCategory.Columns["ParentCategoryName"] != null)
            {
                DGVCategory.Columns["CategoryName"].HeaderText = "نام‌دسته‌بندی‌";
                DGVCategory.Columns["ParentCategoryName"].HeaderText = "نام‌دسته‌بندی‌والد";
            }




        }

        public void LodDGV()
        {
            if (textBox1.Text != "")
            {
                CategoryControll.GetAllCategory();
                DGVCategory.DataSource = CategoryControll.FilterProducts(textBox1.Text);

            }
            else { DGVCategory.DataSource = CategoryControll.GetAllCategory(); }
            CategoryControll.CategoryComboBox(cbParentEdit);
            CategoryControll.CategoryComboBox(cbParent);
        }

        private void FormCategory_Resize(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassDesign.HindenTabPages(tabControl1, tabPage2, tabPage1);
        }

        private void FormCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
