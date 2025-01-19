using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarMan.Models
{
    public class Suppliers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }
        [DisplayName("نام تامین کننده")]
        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }


        [DisplayName("شماره تماس تامین کننده")]
        [Required]
        [StringLength(11)]
        public string ContactNumber { get; set;}

        [DisplayName("ایمیل تامین کننده")]
        public string Email { get; set;}

        [DisplayName("توضیحات")]
        [Required]
        
        public string Description { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }  // ارتباط با تراکنش‌ها

    }
}
