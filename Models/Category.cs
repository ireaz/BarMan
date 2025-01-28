using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarMan.Models
{
    public class Category
    {
        [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("نام دسته‌بندی")]
        public string CategoryName { get; set; }


        // اضافه کردن یک رابطه خود ارجاع (Self-referencing) برای ویژگی‌های فرزند
        public int? ParentCategoryID { get; set; }  // دسته‌بندی اصلی برای هر زیرشاخه
        public virtual Category ParentCategory { get; set; } // به دسته‌بندی اصلی ارجاع می‌دهد

        // زیرشاخه‌های یک دسته‌بندی (رابطه یک به چند)
        public virtual ICollection<Category> SubCategories { get; set; }



        public virtual ICollection<Product> Products { get; set; }
    }
}
