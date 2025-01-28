using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarMan.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("نام کالا")]
        public string ProductName { get; set; }

     

        [Required]
        [DisplayName("موجودی کالا")]
        public int ProductStock { get; set; }  // موجودی کالا

        [ForeignKey("Category")]
        [Required]
        [DisplayName("دسته‌بندی کالا")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

    }
    public class ProductAndCategoryName
    {
        
        public int ProductId { get; set; }

        [DisplayName("نام کالا")]
        public string ProductName { get; set; }



     
        [DisplayName("موجودی کالا")]
        public int ProductStock { get; set; }  // موجودی کالا

       
        [DisplayName("دسته‌بندی کالا")]
        public string CategoryName { get; set; }


    }

}
