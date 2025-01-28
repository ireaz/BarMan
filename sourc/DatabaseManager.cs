using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BarMan.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using BarMan.sourc;

namespace BarMan
{
    public static class DatabaseManager
    {
    
        
        public static async Task EnsureDatabaseExistsAsync()
        {
            bool runform = false;
            LoadingForm loadingForm = new LoadingForm();
            var loadingTask = Task.Run(() => Application.Run(loadingForm));
            loadingForm.UpdateStatus("در حال اتصال به دیتابیس");

            try
            {

                DbContextHelper.ExecuteInDbContext(context =>
                {

                    if (!context.Database.CanConnect())
                    {
                        loadingForm.UpdateStatus("در حال ساخت دیتابیس");
                        runform = true;

                        context.Database.Migrate(); // ایجاد دیتابیس
                    }
                });
                
               
                  
            
            
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بررسی یا ایجاد دیتابیس: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // بستن فرم لودینگ
                if (loadingForm != null && !loadingForm.IsDisposed)
                {
                    if (runform)
                    {
                        loadingForm.UpdateStatus(" دیتابیس ساخته شد");
                        Thread.Sleep(1000);
                  


                    }
                    loadingForm.Invoke(new Action(() => loadingForm.Close()));
                }

               
            }
        }





        // بررسی وجود رکوردها در جدول Admin
        public static bool HasAdminRecords()
        {
            return DbContextHelper.ExecuteInDbContext(context => context.Admins.Any());

         

        }




       



        public static void DeleteAll(int id, string tableName)
        {
            DbContextHelper.ExecuteInDbContext(context =>
            {
                switch (tableName.ToLower())
                {
                    case "category":
                        var category = context.Set<Category>().FirstOrDefault(c => c.CategoryID == id);
                        if (category != null)
                        {
                            context.Set<Category>().Remove(category);
                        }
                        break;

                    case "driver":
                        var driver = context.Set<Driver>().FirstOrDefault(d => d.DriverID == id);
                        if (driver != null)
                        {
                            context.Set<Driver>().Remove(driver);
                        }
                        break;

                    case "product":
                        var product = context.Set<Product>().FirstOrDefault(p => p.ProductID == id);
                        if (product != null)
                        {
                            context.Set<Product>().Remove(product);
                        }
                        break;

                    case "suppliers":
                        var supplier = context.Set<Suppliers>().FirstOrDefault(s => s.SupplierID == id);
                        if (supplier != null)
                        {
                            context.Set<Suppliers>().Remove(supplier);
                        }
                        break;

                    case "transaction":
                        var transaction = context.Set<Transaction>().FirstOrDefault(t => t.TransactionID == id);
                        if (transaction != null)
                        {
                            context.Set<Transaction>().Remove(transaction);
                        }
                        break;

                    default:
                        throw new ArgumentException("جدول مشخص شده یافت نشد.");
                }

                context.SaveChanges();
            });
        }







    }

}
