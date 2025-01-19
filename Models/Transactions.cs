using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarMan.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("شناسه تراکنش")]
        public int TransactionID { get; set; }

        [ForeignKey("Product")]
        [Required]
        [DisplayName("شناسه محصول")]
        public int ProductID { get; set; }

        [ForeignKey("Driver")]
        
        [DisplayName("شناسه راننده")]
        public int DriverID { get; set; }

        [ForeignKey("Supplier")]
        [Required]
        [DisplayName("شناسه تامین کننده")]
        public int SupplierID { get; set; }

        [Required]
        [DisplayName("تعداد کالا")]
        public int Quantity { get; set; }

        [Required]
        [DisplayName("قیمت کالا")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("نوع تراکنش")]
        public string Type { get; set; }  

        [Required]
        [DisplayName("تاریخ تراکنش")]
        public DateTime Date { get; set; }

        public virtual Product Product { get; set; }  // ارتباط با محصول
        public virtual Driver Driver { get; set; }    // ارتباط با راننده
        public virtual Suppliers Supplier { get; set; } // ارتباط با تامین‌کننده
    }
}
