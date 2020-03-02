using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class ContractWorkplace:BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal DiscountAmount { get; set; } //indirim miktarı

        //bir anlaşmaşı kurumun birden çok hastası olur
        
        //Mapping
        //public virtual List<Patient> Patients { get; set; }



    }
}
