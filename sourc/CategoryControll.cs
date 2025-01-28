using BarMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace BarMan.sourc
{
    internal class CategoryControll
    {
        public static bool one=false;
        public static List<object> CategoryData { get; set; } = new List<object>();
        public static bool isCategory { get; set; } = new bool();

        public static void CategoryComboBox(ComboBox CB)
        {
            var defaultItem = new { CategoryID = -1, CategoryName = "هیچی" };
            var   LCategory = CategoryControll.GetCategor_ID_Name();
            if (LCategory != null && LCategory.Any()) // بررسی اینکه آیا لیست حاوی داده است
            {
                isCategory = true;
             
            }
           else if (one == false)
            { MessageBox.Show("دسته بندی وجود ندارد  دسته بندی اضافه کنید ");
                one = true;
                isCategory = false;
            }
            else
            {
                isCategory = false;              

            }
            LCategory.Insert(0, defaultItem);
            CB.DataSource = LCategory;
            CB.DisplayMember = "CategoryName";
            CB.ValueMember = "CategoryID";



        }
 






        public static List<object> GetCategor_ID_Name()
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Categories
                .Select(P => new { P.CategoryID, P.CategoryName })
                .ToList<object>();

            });

        }
        public static List<object> GetAllCategory()
        {
            return CategoryData = DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Categories
                .Select(P => new
                {
                    P.CategoryName,                   
                    ParentCategoryName = P.ParentCategoryID != null
                ? context.Categories
                    .Where(parent => parent.CategoryID == P.ParentCategoryID)
                    .Select(parent => parent.CategoryName)
                    .FirstOrDefault()
                : null // در صورت نبود ParentCategoryID، مقدار null می‌گذاریم
                })
                .ToList<object>();

            });

        }


        public static List<object> FilterProducts(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return CategoryData;

            var filteredProducts = CategoryData.Where(p =>
            {
               
                var product = (dynamic)p; 

                // بررسی اینکه آیا محصول یا دسته‌بندی حاوی فیلتر است یا خیر

                return product.CategoryName.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredProducts;
        }
        public static BarMan.Models.Category GetCategoryByName(string categoryName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Categories
                    .FirstOrDefault(p => p.CategoryName == categoryName); // بازگرداندن اولین مقدار یا null
            });
        }

        public static void AddCategory( string CategoryName, int ParentCategoryID)
        {
            try
            {
                var category = new Category
                {
                    
                    CategoryName = CategoryName,
                    ParentCategoryID = ParentCategoryID

                };

               
                DbContextHelper.Add(category);
            }
            catch (Exception ex) { MessageBox.Show($"فرایند افزودن با مشکل مواجه شد\nجزئیات خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
        public static void AddCategory(string CategoryName)
        {
            try
            {
                var category = new Category
                {

                    CategoryName = CategoryName,
                    ParentCategoryID = null

                };


                DbContextHelper.Add(category);
            }
            catch (Exception ex) { MessageBox.Show($"فرایند افزودن با مشکل مواجه شد\nجزئیات خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }


        public static void UpdateCategory(int CategoryID, string CategoryName, int ParentCategoryID)
        {
            try
            {
                var category = new Category
                {
                    CategoryID = CategoryID,
                    CategoryName = CategoryName,
                    ParentCategoryID= ParentCategoryID

                };

                
                DbContextHelper.Update(category);
            }
            catch (Exception ex) { MessageBox.Show($"فرایند ویرایش با مشکل مواجه شد\nجزئیات خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        public static void UpdateCategory(int CategoryID, string CategoryName)
        {
            try
            {
                var category = new Category
                {
                    CategoryID = CategoryID,
                    CategoryName = CategoryName,
                    ParentCategoryID = null

                };


                DbContextHelper.Update(category);
            }
            catch (Exception ex) { MessageBox.Show($"فرایند ویرایش با مشکل مواجه شد\nجزئیات خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }




        public static bool IsCategoryNameAvailable(string categoryName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                var exists = context.Categories
                      .Any(p => p.CategoryName.ToLower() == categoryName.ToLower());


                return !exists;
            });
        }


        public static BarMan.Models.Category FindCategoryByName(string categoryName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                // جستجو برای اولین محصول با نام مشخص
                return context.Categories
                    .FirstOrDefault(p => p.CategoryName == categoryName); // اگر رکورد پیدا نشد، مقدار null برمی‌گرداند
            });

        }


        public static void DGVCategory(DataGridView dataGridView)
        {

            dataGridView.DataSource = CategoryData;
        
        }

        public static int GetCategoryID_With_Name(string Categoryname)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Categories
                .Where(p => p.CategoryName.ToLower() == Categoryname.ToLower())
                    .Select(d => d.CategoryID)
                    .FirstOrDefault(); // بازیابی اولین شناسه یا مقدار پیش‌فرض (صفر برای int)
            });
        }


    }
}
