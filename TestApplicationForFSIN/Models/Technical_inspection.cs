using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForFSIN.Models
{
    public class Technical_inspection
    {
        public int Id { get; set; }
        [Display(Name = "Номер карты")]
        public int Number { get; set; }

        [Display(Name = "Дата проверки")]
        [DataType(DataType.Date)]
        public DateTime Date_inspection { get; set; }

        [Display(Name = "Замечания")]
        public string Remarks { get; set; }
        public Car Car { get; set; }
    }
}
