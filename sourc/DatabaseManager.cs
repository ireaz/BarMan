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
                        await Task.Delay(3000);
                    }
                    loadingForm.Invoke(new Action(() => loadingForm.Close()));
                }

                // منتظر اتمام Task فرم لودینگ
                loadingTask.Wait();
            }
        }





        // بررسی وجود رکوردها در جدول Admin
        public static bool HasAdminRecords()
        {
            return DbContextHelper.ExecuteInDbContext(context => context.Admins.Any());

         

        }




        public static bool Login(string username, string password)
        {

            return DbContextHelper.ExecuteInDbContext(context => context.Admins.Any(
                
                admin => admin.UserName == username && admin.Password == password)                               
            );

          
        }


     

      



    }

}
