using System.ComponentModel.DataAnnotations;

namespace CarComponents.Domain.Entities
{
    public class CarComponent : EntityBase
    {
        [Display(Name="Название комплектующего")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Заполните тип услуги")]
        [Display(Name = "Тип комплектующего")]
        public string Type { get; set; } = string.Empty;

        [Display(Name = "Марка автомобиля комплектующего")]
        public string Mark { get; set; } = string.Empty;

        [Display(Name = "Модель автомобиля комплектующего")]
        public string Model { get; set; } = string.Empty;

        [Display(Name = "Описание комплектующего")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Цена комплектующего")]
        public double Price { get; set; }

        [Display(Name = "Изображение комплектующего")]
        public string TitleImagePath { get; set; } = string.Empty;
    }
}
