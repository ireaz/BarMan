using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BarMan.sourc
{
    internal class AdminControll
    {


        public static List<object> AdminData { get; set; } = new List<object>();
        public static string AdminRole { get; set; } 


       
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // رمز عبور را به بایت‌ها تبدیل می‌کنیم
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                // هش کردن رمز عبور
                byte[] hash = sha256.ComputeHash(bytes);
                // تبدیل بایت‌ها به رشته‌ای از هگزادسیمال
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        
        public static bool VerifyPassword(string user,string EnterPassword)
        {
           
            string hashedPassword = HashPassword(EnterPassword);
            return hashedPassword == Password(user);
        }
        public static string Password(string user)
        {
            return DbContextHelper.ExecuteInDbContext(context => context.Admins.
               Where(admin => admin.UserName == user)
               .Select(P => P.Password).SingleOrDefault()
               ) ;
        }
        public static bool DeleteAdmin(int id)
        {
            var admin = DbContextHelper.ExecuteInDbContext(context => context.Admins
                .Where(admin => admin.UserID== id)
                .FirstOrDefault()
            );

            if (admin == null)
                return false;  
            
            DbContextHelper.Delete(admin); 

            return true;  
        }
        public static bool IsAdmin(string user)
        {
            var admin = DbContextHelper.ExecuteInDbContext(context => context.Admins
                .Where(admin => admin.UserName == user )
                .FirstOrDefault()
            );
            if (admin == null)
                return false;
            else
                return true;

        }
        public static BarMan.Models.Admin FindAdminByVehicleNumber(string user)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Admins
                    .FirstOrDefault(p => p.UserName == user);
            });

        }
        public static List<object> getUserAndIDAndRole()
        {

            return AdminData= DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Admins
                    .Select(p =>new { p.UserID, p.UserName,p.Role }).ToList<object>();

            });
        }
        public static List<object> FilterAdminName(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return AdminData;

            var filteredDrivers = AdminData.Where(p =>
            {

                var driver = (dynamic)p;



                return driver.UserName.Contains(filter, StringComparison.OrdinalIgnoreCase)||
                       driver.Role.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }

        public static string Role(string user)
        {
            return DbContextHelper.ExecuteInDbContext(context => context.Admins.
               Where(admin => admin.UserName == user)
               .Select(P => P.Role).SingleOrDefault()
               );
        }

        public static bool isSingelRole()
        {
            var role= DbContextHelper.ExecuteInDbContext(context => context.Admins.
               Where(admin => admin.Role == "Admin").ToList<object>()

               );

            if (role.Count > 0)
                return true;
            else
                return false;


        }
        public static bool IsAdminEmpty()
        {
          return  !DbContextHelper.ExecuteInDbContext(context => context.Admins.Any() );



        }
    }
}
