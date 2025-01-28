using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarMan.Models
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DriverID { get; set; }

        [Required]
        [DisplayName("نام راننده")]
        [StringLength(100)]
        public string Name { get; set; }


        [Required]
        [DisplayName("راننده کدملی")]
        [StringLength(10)]
        public string DriverIDCode { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("شماره تماس راننده")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("نوع ماشین")]
        public string VehicleType { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("شماره ماشین")]
        public string VehicleNumber { get; set; }




        public virtual ICollection<Transaction> Transactions { get; set; }  // ارتباط با تراکنش‌ها

    }
}
