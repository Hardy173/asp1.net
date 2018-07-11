using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore1.Models
{
    public class EmployeeView
    {
        [ScaffoldColumn(false)]
        
        public int ID {get; set;}


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        
        [Display(Name = "Фамилия")]
        public string SurName { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }


        [Required( ErrorMessage = "Поле должно быть установлено")]
        [Range(18, 70, ErrorMessage = "Возраст не может быть меньше 18 и больше 65!!!")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина названия города должна быть от 2 до 30 символов")]
        //[RegularExpression(@"[A-Za-z]{2,}|[ |-|.]", ErrorMessage = "Название города должно иметь длину от 2 символов и не должно иметь цифр")]
        [Display(Name = "Город")]
        public string City { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"[0-9]{1,}", ErrorMessage = "Опыт работы не может быть отрицательным")]
        [Display(Name = "Опыт работы")]
        public string Experience { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)\d\d", ErrorMessage = "Дата рождения введена не верно! Пример: DD.MM.YYYY")]
        [Display(Name = "Дата рождения")]
        public string DOB { get; set; }
    }
}
