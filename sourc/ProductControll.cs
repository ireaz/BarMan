using BarMan.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;

namespace BarMan.sourc
{
    internal class ProductControll
    {
        public static List<object> ProductData { get; set; } = new List<object>();
        public static List<ProductAndCategoryName> ProductDataHome { get; set; } = new List<ProductAndCategoryName>();

        public static List<object> GetProductWithCategoryName()
        {

            return DbContextHelper.ExecuteInDbContext(context =>  // ایجاد scope جدید
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
           
        }


        public static List <object> GetProduct_ID_Name() {

            return DbContextHelper.ExecuteInDbContext(context =>  
            {

                return context.Products             
               .Select(p => new
               {
                   p.ProductID,
                   p.ProductName         
                          
               
               })
                 .ToList<object>(); 


            });

        }
      






        public static List<object> FilterProducts(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return ProductData;

            var filteredProducts = ProductData.Where(p =>
            {
                //dynamic
                var product = (dynamic)p; 

               
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
        public static BarMan.Models.Product FindProductByID(int productID)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                // جستجو برای اولین محصول با نام مشخص
                return context.Products
                    .FirstOrDefault(p => p.ProductID == productID); // اگر رکورد پیدا نشد، مقدار null برمی‌گرداند
            });

        }
        public static int FindStockByID(int productID)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                
                return context.Products
                    .Where(p => p.ProductID == productID)
                    .Select(p => p.ProductStock)
                    .FirstOrDefault(); 
            });
        }



        public static List<object> GetProductsSortedByCategory()
        {
            return ProductData= DbContextHelper.ExecuteInDbContext(context =>
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

        public static void UpdateProudactNUM(int productID, int number)
        {
            try
            {
                var product = FindProductByID(productID);
                product.ProductStock += number;




                DbContextHelper.Update(product);
            }
            catch { MessageBox.Show("فرایند ویرایش تعداد کالا با مشکل مواجه شد"); }
        }
        
        public static int GetProductID_With_Name(string Productname)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Products
                .Where(p => p.ProductName.ToLower() == Productname.ToLower())
                    .Select(d => d.ProductID)
                    .FirstOrDefault(); // بازیابی اولین شناسه یا مقدار پیش‌فرض (صفر برای int)
            });
        }


        public static List<ProductAndCategoryName> ProductHome()
        {
            return ProductDataHome= DbContextHelper.ExecuteInDbContext(context =>

            {
                return context.Products
               .Include(C => C.Category)
               .Select(p => new ProductAndCategoryName
               {
                   ProductId=p.ProductID,
                   ProductName = p.ProductName,
                   ProductStock = p.ProductStock,
                   CategoryName = p.Category.CategoryName // فرض بر این است که CategoryName در مدل Category وجود دارد

               }).ToList<ProductAndCategoryName>();


            });
        }
        public static List<ProductAndCategoryName> FilterProductshome(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return ProductDataHome;

            var filteredProducts =ProductDataHome.Where(p =>
            {
                //dynamic
                var product = (dynamic)p;


                return product.ProductName.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                       product.CategoryName.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredProducts;
        }

    }





}





