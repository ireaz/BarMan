using BarMan.Models;
using BarMan.sourc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BarMan
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           // db_Connect.Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // تنظیمات سرویس‌ها
            db_Connect.Initialize();

            // بررسی وجود دیتابیس
            DatabaseManager.EnsureDatabaseExistsAsync().Wait();

           // isAdmin();
            // بررسی رکوردهای جدول Admin

            Application.Run(new Home());
            
        }

        public static void isAdmin()
        {
            bool hasAdminRecords = DatabaseManager.HasAdminRecords();


            if (hasAdminRecords)
            {
                Login login = new Login();
                login.ShowDialog();
            }
            else
            {
                // MessageBox.Show("برای برنامه کاربر ثبت کنید ", "هشدار");

                MessageBox.Show(
               "لطفاً برای استفاده ایمنتر از برنامه، حساب کاربری ایجاد کنید.", 
               "هشدار", 
               MessageBoxButtons.OK, 
               MessageBoxIcon.Information 
           );

            }


        }






    }
}
