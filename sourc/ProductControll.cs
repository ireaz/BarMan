using BarMan.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarMan.Models;
using System.Reflection;

namespace BarMan.sourc
{
    internal class ProductControll
    {
        public static List<object> ProductData { get; set; } = new List<object>();


        public static List<object> GetProductWithCategoryName()
        {

            ProductData = DbContextHelper.ExecuteInDbContext(context =>  // ایجاد scope جدید
            {

                return context.Products
              .Include(p => p.Category) // بارگذاری داده‌های مربوط به Category
               .Select(p => new
               {
                   p.ProductName,            // نام محصول
                   p.ProductStock,           // موجودی محصول
                   CategoryName = p.Category.CategoryName // استفاده از نام دسته‌بندی به جای CategoryID
               })
                 .ToList<object>();  // تبدیل به لیست از نوع Object برای ارسال به DataGridView


            });
            return ProductData;
        }



        public static void DataGV(DataGridView DGV)
        {

            var products =GetProductsSortedByCategory();

            if (products != null && products.Count > 0)
            {
                ClassDesign.CustomizeDataGridView(DGV);

                // تبدیل به لیست و بررسی null برای Category
                 ProductData = products.ToList<object>();

                DGV.DataSource = ProductData;
                
            }
            else
            {
                // در صورت خالی بودن داده‌ها، فقط نام ستون‌ها تنظیم می‌شود
                DGV.DataSource = null;  // خالی کردن DataGridView
            }
            DGV.Columns["ProductID"].Visible= false;
            DGV.Columns["CategoryID"].Visible = false;
           


            if (DGV.Columns["ProductName"] == null)
            {
                DGV.Columns.Add("ProductName", "نام کالا");
            }
            if (DGV.Columns["ProductStock"] == null)
            {
                DGV.Columns.Add("ProductStock", "موجودی کالا");
            }
            if (DGV.Columns["CategoryName"] == null)
            {
                DGV.Columns.Add("CategoryName", "نام دسته‌بندی");
            }

            // تنظیم نام ستون‌ها
            DGV.Columns["ProductName"].HeaderText = "نام کالا";
            DGV.Columns["ProductStock"].HeaderText = "موجودی کالا";
            DGV.Columns["CategoryName"].HeaderText = "نام دسته‌بندی";



        }



        public static List<object> FilterProducts(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return ProductData;

            var filteredProducts = ProductData.Where(p =>
            {
                // فرض بر این است که p.ProductName و p.CategoryName به عنوان string در نظر گرفته می‌شود
                var product = (dynamic)p;  // استفاده از dynamic برای دسترسی به ویژگی‌های شیء ناشناخته

                // بررسی اینکه آیا محصول یا دسته‌بندی حاوی فیلتر است یا خیر
                return product.ProductName.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                       product.CategoryName.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredProducts;
        }


        public static BarMan.Models.Product FindProductByName(string productName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                // جستجو برای اولین محصول با نام مشخص
                return context.Products
                    .FirstOrDefault(p => p.ProductName == productName); // اگر رکورد پیدا نشد، مقدار null برمی‌گرداند
            });

        }


       
        public static List<object> GetProductsSortedByCategory()
        {
           return DbContextHelper.ExecuteInDbContext(context =>
            {
                // بارگذاری محصولات به همراه دسته‌بندی‌های آن‌ها (برای دسته‌بندی‌های فرزند و والد)
                var products = context.Products
                    .Include(p => p.Category)
                    .OrderBy(p => p.Category.ParentCategoryID)  // اول مرتب‌سازی بر اساس دسته‌بندی والد
                    .ThenBy(p => p.Category.CategoryName)      // سپس مرتب‌سازی بر اساس نام دسته‌بندی
                    .ThenBy(p => p.ProductName)
                    .Select(p => new { 
                    p.ProductID,
                    p.ProductName,
                    p.ProductStock,
                    CategoryID = p.Category.CategoryID,
                    CategoryName = p.Category.CategoryName, 
                    
                    })
                    
                    .ToList<object>();

                return products;
            });
        }

        public static bool IsProductNameAvailable(string productName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                var exists = context.Products
                      .Any(p => p.ProductName.ToLower() == productName.ToLower());


                return !exists;
            });
        }

        public static bool AddProduct(string productName, int productStock, int categoryId)
        {
            bool success = true;
            try
            {

                // ساخت نمونه‌ای از Product
                var newProduct = new Product
                {
                    ProductName = productName,
                    ProductStock = productStock,
                    CategoryID = categoryId // شناسه دسته‌بندی
                };
                // استفاده از تابع عمومی Add برای اضافه کردن به دیتابیس
                DbContextHelper.Add(newProduct);

            }

            catch (Exception ex) { success = false; }

            return success;

           




        }
        


        public static void UpdateProduct(int productId, string productName, int productNumber, int categoryId)
        {
            try
            {
                var product = new Product
                {
                    ProductID = productId,
                    ProductName = productName,
                    ProductStock = productNumber,
                    CategoryID = categoryId

                };

                // فراخوانی متد Update برای آپدیت محصول
                DbContextHelper.Update(product);
            }
            catch(Exception ex) { MessageBox.Show("فرایند ویرایش با مشکل مواجه شد"); }


        }



    }





}





