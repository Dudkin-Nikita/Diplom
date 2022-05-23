using System.ComponentModel.DataAnnotations;

namespace CarComponents.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string Codeword { get; set; } = string.Empty;

        [Display(Name = "Название страницы (заголовок)")]
        public string Title { get; set; } = "Информационная страница";

        [Display(Name = "Содержание страницы")]
        public string Text { get; set; } = "Содержание заполняется администратором";
    }
}
