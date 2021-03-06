
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class Appointment:BaseEntity
    {
        
        public int ID { get; set; }
        public string AppointmentDay { get; set; }
        public string AppointmentHour { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string FullName { get; set; }
        public string TreatingDoctor { get; set; }
        
        //Mapping
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }




    }
}
