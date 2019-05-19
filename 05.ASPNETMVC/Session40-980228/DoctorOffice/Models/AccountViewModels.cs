using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "ایمیل")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [Display(Name = "مرا به یاد داشته باش")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "فیلد {0} باید حداقل {2} کاراکتر داشته باشد.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار کلمه عبور")]
        [Compare("Password", ErrorMessage = "کلمه عبور و تکرار آن مطابقت ندارند")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "نام")]
        [MinLength(2, ErrorMessage = "نام باید حداقل ۲ حرف داشته باشد")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "نام خانوادگی باید حداقل ۲ و حداکثر ۶۰ حرف داشته باشد")]
        [Required]
        public string Family { get; set; }
        [Display(Name = "کد ملی")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "تعداد کاراکتر های کد ملی وارد شده باشد ۱۲ حرف با در نظر گرفتن خطوط تیره باشد")]
        [RegularExpression(@"^\d{3}-\d{6}-\d{1}$", ErrorMessage = "الگوی کد ملی وارد شده صحیح نیست")]
        public string NationalCode { get; set; }


        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "ورود تاریخ تولد اجباری است")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "جنسیت")]
        public Gender Gender { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
