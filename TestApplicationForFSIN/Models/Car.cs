using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForFSIN.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Display(Name = "Модель")]
        [Required(ErrorMessage = "Введите название модели")]
        public string Model { get; set; }

        [Display(Name = "Регистрационный номер")]
        [Required(ErrorMessage = "Введите регистрационный номер")]
        public string Registration_number { get; set; }

        [Display(Name = "Дата выпуска")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Введите дату выпуска автомобиля")]
        public DateTime Release { get; set; }

        [Display(Name = "Дата постановки на учёт")]
        [DataType(DataType.Date)]
        public DateTime Date_of_registration { get; set; }
        public List<Technical_inspection> technical_Inspections { get; set; }
    }
}
