using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.MODEL.Entity
{
    public class Expense:BaseEntity
    {
        public int ID { get; set; }
        public decimal EmployeeSalary { get; set; }
        public decimal StaffDoctorSalary { get; set; }
        public decimal Invoice { get; set; }//faturalar
        public decimal MaterialExpense { get; set; }//Malzeme giderleri
        public int InsurancePremium { get; set; }//Sigorta pirimleri
        public DateTime ExpensePeriod { get; set; }//Gider dönemi(ocak,Şubat vs)

    }
}
