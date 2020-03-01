using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class Treatment:BaseEntity

    {

        public int ID { get; set; }
        public string PatientFullName { get; set; }
        public decimal TotalPayment { get; set; }
        public bool isActive { get; set; }
        public string Description { get; set; }

        public string ListOfTreatments { get; set; }

        public Doctor Doctor { get; set; }
        [Required]
        public Patient Patient { get; set; }
       
    }
}
