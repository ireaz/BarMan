using BarMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarMan.sourc
{
    internal class DriverControll
    {
        public static List<object> DriverData { get; set; } = new List<object>();
        public static BarMan.Models.Driver FindDriverByName(string DriverName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                
                return context.Driver
                    .FirstOrDefault(p => p.Name == DriverName); 
            });

        }


        public static BarMan.Models.Driver FindDriverByVehicleNumber(string VehicleNumber)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
               
                return context.Driver
                    .FirstOrDefault(p => p.VehicleNumber == VehicleNumber); 
            });

        }
        public static BarMan.Models.Driver FindDriverByDriverIDCode(string DriverIDCode)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Driver
                    .FirstOrDefault(p => p.DriverIDCode == DriverIDCode);
            });

        }


        public static List<object> GetDriver()
        {

            return DriverData= DbContextHelper.ExecuteInDbContext(context =>
            {
            
            return context.Driver
                .Select(D => new {
                    D.Name,
                    D.DriverIDCode,
                    D.Phone,
                    D.VehicleType,
                    D.VehicleNumber
                })
                .ToList<object>();
                   
            });

        }

        public static List<object> GetDriver_ID_name()
        {

            return DriverData = DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Driver
                    .Select(D => new {
                        D.DriverID,
                        D.Name
                        
                    })
                    .ToList<object>();

            });

        }





        public static bool AddDriver(string DeiverName, string DriverIdCod, string Phone, string VehicleType,string VehicleNumber)
        {
            bool success = false;
            try
            {

                // ساخت نمونه‌ای از Product
                var newDriver = new Driver
                {
                  Name = DeiverName,
                  DriverIDCode = DriverIdCod,
                  Phone = Phone,
                  VehicleType = VehicleType,
                  VehicleNumber = VehicleNumber
                };
                // استفاده از تابع عمومی Add برای اضافه کردن به دیتابیس
                DbContextHelper.Add(newDriver);
                success = true;

            }

            catch (Exception ex) { success = false; }

            return success;






        }



        public static bool UpdateDriver(int DriverId,string DeiverName,string DriverIdCod, string Phone, string VehicleType, string VehicleNumber)
        {
            bool success = true;
            try
            {

                // ساخت نمونه‌ای از Product
                var UpdateDriver = new Driver
                { 
                    DriverID = DriverId,
                    Name = DeiverName,
                    DriverIDCode = DriverIdCod,
                    Phone = Phone,
                    VehicleType = VehicleType,
                    VehicleNumber = VehicleNumber
                };
                // استفاده از تابع عمومی Add برای اضافه کردن به دیتابیس
                DbContextHelper.Update(UpdateDriver);

            }

            catch (Exception ex) { success = false; }

            return success;






        }




        public static List<object> FilterDriverName(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return DriverData;

            var filteredDrivers = DriverData.Where(p =>
            {

                var driver = (dynamic)p;

                

                return driver.Name.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }

        public static List<object> FilterDriverVehicleNumber(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return DriverData;

            var filteredDrivers = DriverData.Where(p =>
            {

                var driver = (dynamic)p;



                return driver.VehicleNumber.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }
        public static List<object> FilterDriverIdCod(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return DriverData;

            var filteredDrivers = DriverData.Where(p =>
            {

                var driver = (dynamic)p;



                return driver.DriverIDCode.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }


        public static bool IsDriverNameAvailable(string DriverName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                var exists = context.Driver
                      .Any(p => p.Name.ToLower() == DriverName.ToLower());


                return !exists;
            });
        }
        public static bool IsDriverVehicleNumberAvailable(string VehicleNumber)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                var exists = context.Driver
                      .Any(p => p.VehicleNumber.ToLower() == VehicleNumber.ToLower());


                return !exists;
            });
        }



        public static bool IsNameUnique(string name, int excludeId)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                // جستجو برای اسم مشابه که DriverID آن متفاوت از excludeId باشد
                var exists = context.Driver
                    .Any(p => p.Name.ToLower() == name.ToLower() && p.DriverID != excludeId);

                // اگر مشابه یافت شود، false برمی‌گرداند، در غیر این صورت true
                return exists;
            });
        }
        public static bool IsVehicleNumberUnique( string VehicleNumber, int excludeId)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                // جستجو برای نام راننده و شماره وسیله نقلیه مشابه که DriverID آن متفاوت از excludeId باشد
                var exists = context.Driver
                    .Any(p => p.VehicleNumber.ToLower() == VehicleNumber.ToLower() && p.DriverID != excludeId);

                // اگر مشابه یافت شود، false برمی‌گرداند، در غیر این صورت true
                return exists;
            });
        }


        public static bool IsIdCodUnique(string IdCod, int excludeId)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                // جستجو برای نام راننده و شماره وسیله نقلیه مشابه که DriverID آن متفاوت از excludeId باشد
                var exists = context.Driver
                    .Any(p => p.DriverIDCode.ToLower() == IdCod.ToLower() && p.DriverID != excludeId);

                // اگر مشابه یافت شود، false برمی‌گرداند، در غیر این صورت true
                return exists;
            });
        }



        public static int GetDriverID_With_VehicleNumber(string VehicleNumber)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Driver
                .Where(p => p.VehicleNumber.ToLower()==VehicleNumber.ToLower())
                    .Select(d => d.DriverID)
                    .FirstOrDefault(); // بازیابی اولین شناسه یا مقدار پیش‌فرض (صفر برای int)
            });
        }




    }
}
