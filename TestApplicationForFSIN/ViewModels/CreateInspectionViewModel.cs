using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForFSIN.ViewModels
{
    public class CreateInspectionViewModel
    {
        public int Number { get; set; }
        public DateTime Date_inspection { get; set; }
        public string Remarks { get; set; }
        public int Car_Id { get; set; }
    }
}
