using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class Patient:BaseEntity
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EMailAddress { get; set; }
        public string BloodGroup { get; set; }
        public string ContractWorkplace { get; set; }
        public string InfectiousDisease { get; set; }
        public string Adress { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        public string Reference { get; set; }
        public string TreatingDoctor { get; set; }
        
        public string Description { get; set; }
        
        
        public bool isActive { get; set; }

        //Foreign Key

        //public int ContractWorkplaceID { get; set; }
        //public int TreatmentPlanID { get; set; }
        public int TreatmentID { get; set; }




        //mapping 
        //bir hastanın birden fazla randevusu olur.
        //Bir hastanın bir doktoru olur.
        //Bir hastanın bir anlaşmalı kurumu olur.

        //Mapping


        public virtual List<Appointment> Appointments { get; set; }
        public virtual Treatment Treatment  { get; set; }
        public Doctor Doctor { get; set; }
        //public TreatmentPlan TreatmentPlan { get; set; }
        //public ContractWorkplace ContractWorkplace { get; set; }












    }
}
