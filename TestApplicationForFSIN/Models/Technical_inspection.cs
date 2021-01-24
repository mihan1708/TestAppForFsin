using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForFSIN.Models
{
    public class Technical_inspection
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date_inspection { get; set; }
        public string Remarks { get; set; }
        public Car Car { get; set; }
    }
}
