using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public abstract class BaseEntity
    {
        
       
        public DateTime CreatedDate { get; set; }
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
