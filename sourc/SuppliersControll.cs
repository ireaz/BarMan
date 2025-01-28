using BarMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BarMan.sourc
{
    internal class SuppliersControll
    {

        public static List<object> SuppliersData { get; set; } = new List<object>();
        public static BarMan.Models.Suppliers FindSuppliersByIDCode(string SupplierIDCode)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Suppliers
                    .FirstOrDefault(p => p.Supplier_ID_Code == SupplierIDCode);
            });

        }

        public static BarMan.Models.Suppliers FindSuppliersByName(string Name)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Suppliers
                    .FirstOrDefault(p => p.SupplierName == Name);
            });

        }
        public static BarMan.Models.Suppliers FindSuppliersByEmil(string email)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Suppliers
                    .FirstOrDefault(p => p.Email == email);
            });

        }
        public static BarMan.Models.Suppliers FindSuppliersByTell(string Tell)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Suppliers
                    .FirstOrDefault(p => p.ContactNumber == Tell);
            });

        }



        public static List<object> GetSupplier()
        {

            return SuppliersData = DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Suppliers
                    .Select(D => new {
                        D.SupplierName,
                        D.Supplier_ID_Code,
                        D.ContactNumber,
                        D.Email,
                        D.Description
                    })
                .ToList<object>();
            });
        }

        public static List<object> GetSupplier_ID_Name()
        {

            return DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Suppliers
                    .Select(D => new {
                        D.SupplierID,
                        D.SupplierName
                   
                    })
                .ToList<object>();
            });
        }



        public static bool AddSupplier(string SuppliersName, string suppliersIdCod, string contactNumber, string  email, string description)
        {
            bool success = false;
            try
            {

               
                var newSuppliers = new Suppliers
                {
                    SupplierName = SuppliersName,
                    Supplier_ID_Code = suppliersIdCod,
                    ContactNumber = contactNumber,
                    Email = email,
                    Description = description
                };
             
                DbContextHelper.Add(newSuppliers);
                success = true;

            }

            catch (Exception ex) { success = false; }

            return success;






        }



        public static bool UpdateSupplier(int SuppliiersId,string SuppliersName, string suppliersIdCod, string contactNumber, string email, string description)
        {
            bool success = true;
            try
            {

              
                var UpdateSupplier = new Suppliers
                {
                   SupplierID= SuppliiersId,
                   SupplierName= SuppliersName,
                   Supplier_ID_Code= suppliersIdCod,
                   ContactNumber= contactNumber,
                   Email= email,
                   Description = description
                   
                };
              
                DbContextHelper.Update(UpdateSupplier);

            }

            catch (Exception ex) { success = false; }

            return success;
        }



        //نام
        public static List<object> FilterSuppliersName(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return SuppliersData;

            var filteredDrivers = SuppliersData.Where(p =>
            {

                var driver = (dynamic)p;



                return driver.SupplierName.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }

        //کدملی
        public static List<object> FilterSuppliersIdCod(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return SuppliersData;

            var filteredDrivers = SuppliersData.Where(p =>
            {

                var driver = (dynamic)p;



                return driver.Supplier_ID_Code.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }

        public static List<object> FilterSuppliersTell(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return SuppliersData;

            var filteredDrivers = SuppliersData.Where(p =>
            {

                var driver = (dynamic)p;



                return driver.ContactNumber.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }


        public static List<object> FilterSuppliersEmail(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return SuppliersData;

            var filteredDrivers = SuppliersData.Where(p =>
            {

                var driver = (dynamic)p;



                return driver.Email.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredDrivers;
        }


        public static bool IsSuppliersNameAvailable(string SuppliersName)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                var exists = context.Suppliers
                      .Any(p => p.SupplierName.ToLower() == SuppliersName.ToLower());


                return exists;
            });
        }
        public static bool IsSupplier_ID_CodeAvailable(string SupplierIDCode)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                var exists = context.Suppliers
                      .Any(p => p.Supplier_ID_Code.ToLower() == SupplierIDCode.ToLower());


                return exists;
            });
        }


        public static int GetSupplierID_With_Supplier_ID_Code(string SupplierIDCode)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Suppliers
                .Where(p => p.Supplier_ID_Code.ToLower() == SupplierIDCode.ToLower())
                    .Select(d => d.SupplierID)
                    .FirstOrDefault(); 
            });
        }


        public static bool IsIdCodUnique(string IdCod, int excludeId)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
            
                var exists = context.Suppliers
                    .Any(p => p.Supplier_ID_Code.ToLower() == IdCod.ToLower() && p.SupplierID != excludeId);

               
                return exists;
            });
        }

        public static bool IsNameUnique(string name, int excludeId)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {

                var exists = context.Suppliers
                    .Any(p => p.SupplierName.ToLower() == name.ToLower() && p.SupplierID != excludeId);


                return exists;
            });
        }


    }
}
