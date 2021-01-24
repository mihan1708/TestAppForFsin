using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForFSIN.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Registration_number { get; set; }
        public DateTime Release { get; set; }
        public DateTime Date_of_registration { get; set; }
        public List<Technical_inspection> technical_Inspections { get; set; }
    }
}
