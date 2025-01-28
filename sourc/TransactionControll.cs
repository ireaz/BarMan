using BarMan.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarMan.sourc;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Wordprocessing;

namespace BarMan.sourc
{
    internal class TransactionControll
    {

        public static List<TransactionModel> TransactionData { get; set; } = new List<TransactionModel>();
        public static List<object> GetTransactionNotId()
        {

            return  DbContextHelper.ExecuteInDbContext(context =>
            {

                return context.Transactions
                    .Select(D => new {
                        D.ProductID ,
                        D.DriverID,
                        D.SupplierID,
                        D.Quantity,
                        D.Price,
                        D.Type,
                        D.Date,
                        D.TimeT
                    })
                .ToList<object>();
            });
        }
        public static List<Transaction> GetAllTransactions()
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
              
                return context.Transactions.ToList();
            });
        }



        public static List<TransactionModel> GetTransactionsWith(int id)
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Transactions
                    .Include(t => t.Product)
                    .Include(t => t.Driver)
                    .Include(t => t.Supplier)
                    .Where(t => t.ProductID == id)
                    .Select(t => new TransactionModel
                    {
                        TransactionID = t.TransactionID,
                        ProductName = t.Product.ProductName,
                        DriverName = t.Driver != null ? t.Driver.Name : "بدون راننده",
                        SupplierName = t.Supplier.SupplierName,
                        Quantity = t.Quantity,
                        Price = t.Price,
                        Type = t.Type,
                        Date = t.Date,
                        Time = t.TimeT
                    })
                    .ToList();
            });
        }
        public static List<TransactionModel> GetTransactionsWith()
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Transactions
                    .Include(t => t.Product)
                    .Include(t => t.Driver)
                    .Include(t => t.Supplier)
                    .Select(t => new TransactionModel
                    {
                        TransactionID = t.TransactionID,
                        ProductName = t.Product.ProductName,
                        DriverName = t.Driver != null ? t.Driver.Name : "بدون راننده",
                        SupplierName = t.Supplier.SupplierName,
                        Quantity = t.Quantity,
                        Price = t.Price,
                        Type = t.Type,
                        Date = t.Date,
                        Time = t.TimeT
                    })
                    .ToList();
            });
        }



        public static bool AddTransaction(int ProductId, int DriverID, int SupplierID, int Quantity, int Price, string Type, DateTime Date, TimeSpan time)
        {
            bool success = false;
            try
            {


                var newTransaction = new Transaction
                {
                    ProductID = ProductId,
                    DriverID = DriverID,
                    SupplierID = SupplierID,
                    Quantity = Quantity,
                    Price = Price,
                    Type = Type,
                    Date = Date,
                    TimeT=time
                    
                };

                DbContextHelper.Add(newTransaction);
                success = true;

            }

            catch (Exception ex) { success = false; }

            return success;

        }






        public static bool UpdateTransaction(int TransactionId,int ProductId, int DriverID, int SupplierID, int Quantity, int Price, string Type, DateTime Date,TimeSpan time)
        {
            bool success = true;
            try
            {


                var newTransaction = new Transaction
                {TransactionID = TransactionId,
                    ProductID = ProductId,
                    DriverID = DriverID,
                    SupplierID = SupplierID,
                    Quantity = Quantity,
                    Price = Price,
                    Type = Type,
                    Date = Date,
                    TimeT=time

                };

                DbContextHelper.Update(newTransaction);

            }

            catch (Exception ex) { success = false; }

            return success;
        }


          public static BarMan.Models.Transaction FindTransactionByID(int transactionid)
            {
                return DbContextHelper.ExecuteInDbContext(context =>
                {

                    return context.Transactions
                        .FirstOrDefault(p => p.TransactionID == transactionid);
                });

            }
        public static List<TransactionModel> FilterDateTime(DateTime DateO,DateTime DateE)
        {
            return TransactionData= DbContextHelper.ExecuteInDbContext(context =>
            {
                var query = context.Transactions
                   .Include(t => t.Product)
                   .Include(t => t.Driver)
                   .Include(t => t.Supplier)                  
                .Where(P => P.Date >= DateO && P.Date <= DateE);
                 return query.Select(t => new TransactionModel
                 {
                     TransactionID = t.TransactionID,
                     ProductName = t.Product.ProductName,
                     DriverName = t.Driver != null ? t.Driver.Name : "بدون راننده",
                     SupplierName = t.Supplier.SupplierName,
                     Quantity = t.Quantity,
                     Price = t.Price,
                     Type = t.Type,
                     Date = t.Date,
                     Time = t.TimeT
                 }).ToList();
             
            });

        }


        public static List<TransactionModel> FilterTransaction_By_ProductName(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return TransactionData;

            var filteredTransaction = TransactionData.Where(p =>
            {

                var Transaction = (dynamic)p;



                return Transaction.ProductName.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredTransaction;
        }
        public static List<TransactionModel> FilterTransaction_By_SuppliersName(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return TransactionData;

            var filteredTransaction = TransactionData.Where(p =>
            {

                var Transaction = (dynamic)p;



                return Transaction.SupplierName.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredTransaction;
        }

        public static List<TransactionModel> FilterTransaction_By_DriverName(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return TransactionData;

            var filteredTransaction = TransactionData.Where(p =>
            {
                var transaction = (dynamic)p;
                return transaction.DriverName.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredTransaction;
        }

        public static List<TransactionModel> FilterTransaction_By_Quantity(int filter)
        {
            var filteredTransaction = TransactionData.Where(p =>
            {
                var transaction = (dynamic)p;
                return transaction.Quantity == filter;
            }).ToList();

            return filteredTransaction;
        }

        public static List<TransactionModel> FilterTransaction_By_Price(decimal filter)
        {
            var filteredTransaction = TransactionData.Where(p =>
            {
                var transaction = (dynamic)p;
                return transaction.Price == filter;
            }).ToList();

            return filteredTransaction;
        }

        public static List<TransactionModel> FilterTransaction_By_Type(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return TransactionData;

            var filteredTransaction = TransactionData.Where(p =>
            {
                var transaction = (dynamic)p;
                return transaction.Type.Contains(filter, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            return filteredTransaction;
        }





    }
}
