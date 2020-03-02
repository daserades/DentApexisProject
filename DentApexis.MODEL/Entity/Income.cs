using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class Income:BaseEntity
    {
        public int ID { get; set;}
        public bool isPaid { get; set; }
        public decimal Payment { get; set; }
       
        public DateTime IncomePeriod { get; set; }//gelir dönemi

    }
}
