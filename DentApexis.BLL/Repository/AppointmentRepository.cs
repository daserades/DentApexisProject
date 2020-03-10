using DentApexis.BLL.Singleton;
using DentApexis.DAL.Context;
using DentApexis.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.BLL.Repository
{
    public class AppointmentRepository: BaseRepository<Appointment>
    {
        private DentApexisDBContext db;
        public AppointmentRepository()
        {
            db = DbTool.Instance;

        }
        public new void Insert(Appointment Item)
        {
            Item.FullName = Item.PatientName + " " + Item.PatientSurname;
            db.Set<Appointment>().Add(Item);
            db.SaveChanges();
        }


    }
}
