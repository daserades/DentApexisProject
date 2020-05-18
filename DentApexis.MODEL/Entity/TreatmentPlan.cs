using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class TreatmentPlan:BaseEntity
    {
        public int ID { get; set; }
        public decimal TedaviUcret { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name+"-"+this.TedaviUcret;
        }
       
    }
}
