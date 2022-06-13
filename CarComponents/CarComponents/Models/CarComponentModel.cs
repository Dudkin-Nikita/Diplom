using System.ComponentModel.DataAnnotations;

namespace CarComponents.Models
{
    public class CarComponentModel
    {
        [Display(Name = "Название комплектующего")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Заполните тип комплектующего")]
        [Display(Name = "Тип комплектующего (обязательно для заполнения)")]
        public string Type { get; set; }

        [Display(Name = "Марка автомобиля комплектующего")]
        public string Mark { get; set; }

        [Display(Name = "Модель автомобиля комплектующего")]
        public string Model { get; set; }

        [Display(Name = "Максимальная цена комплектующего")]
        public double MaxPrice { get; set; }

        [Display(Name = "Минимальная цена комплектующего")]
        public double MinPrice { get; set; }
    }
}
