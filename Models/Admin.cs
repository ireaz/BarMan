using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarMan.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("شناسه کاربر")]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("نام کاربری")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("رمز عبور")]
        public string Password { get; set; }  
        [Required]
        [DisplayName("نقش کاربر")]
        public string Role { get; set; }  
    }

}
