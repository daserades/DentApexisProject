using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class Doctor:BaseEntity
    {              
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }        
        public decimal AmountOfTurnover { get; set; }
        public string FullName { get; set; }
        public override string ToString()
        {
            return this.FullName;
        }

        //Mapping
        public virtual List<Appointment> Appointments { get; set; }
        public virtual List<Patient> Patients { get; set; }


    }
}
