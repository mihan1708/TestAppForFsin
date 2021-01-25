using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestApplicationForFSIN.Models;

namespace TestApplicationForFSIN.ViewModels
{
    public class CreateInspectionViewModel
    {
        [Display(Name ="Номер карты")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Введите дату проверки")]
        [Display(Name = "Дата проверки")]
        [DataType(DataType.Date)]
        public DateTime Date_inspection { get; set; }

        [Display(Name = "Замечания")]
        public string Remarks { get; set; }

        public Car Car { get; set; }
        
    }
}
