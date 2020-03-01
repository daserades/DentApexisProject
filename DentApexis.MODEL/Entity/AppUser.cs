using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class AppUser:BaseEntity
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string LastName{ get; set; }

        public string Password { get; set; }
        public string Pozisyon { get; set; }
        public string FullName { get; set; }

        public decimal Salary { get; set; }


    }
}
