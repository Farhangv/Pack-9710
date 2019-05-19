using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoctorOffice.Models
{
    public class Person
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [MinLength(2, ErrorMessage = "نام باید حداقل ۲ حرف داشته باشد")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        [StringLength(60,MinimumLength = 2, ErrorMessage = "نام خانوادگی باید حداقل ۲ و حداکثر ۶۰ حرف داشته باشد")]
        [Required]
        public string Family { get; set; }
        [Display(Name = "کد ملی")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "تعداد کاراکتر های کد ملی وارد شده باشد ۱۲ حرف با در نظر گرفتن خطوط تیره باشد")]
        [RegularExpression(@"^\d{3}-\d{6}-\d{1}$", ErrorMessage = "الگوی کد ملی وارد شده صحیح نیست")]
        public string NationalCode { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [NotMapped]
        public string FullName { get { return $"{this.Name} {this.Family}"; } }
    }
}