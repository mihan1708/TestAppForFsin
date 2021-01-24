using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForFSIN.ViewModels
{
    public class EditInspectionViewModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date_inspection { get; set; }
        public string Remarks { get; set; }
        public int Car_Id { get; set; }
    }
}
