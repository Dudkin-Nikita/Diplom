using System.ComponentModel.DataAnnotations;

namespace CarComponents.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [UIHint("password")]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}
