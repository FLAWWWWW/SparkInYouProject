using System.ComponentModel.DataAnnotations;

namespace SparkInYou.Models
{
    public class Contact
    {
        // Данные, которые мы получаем от пользователя в форме
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Вам нужно ввести почту")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [StringLength(150, ErrorMessage = "Текст менее 150 символов")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        public string Message { get; set; }
    }
}
