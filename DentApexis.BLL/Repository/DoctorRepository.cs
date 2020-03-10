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
   public class DoctorRepository: BaseRepository<Doctor>
    {
        private DentApexisDBContext db;
        public DoctorRepository()
        {
            db = DbTool.Instance;

        }

        public new void Insert(Doctor Item)
        {
            Item.FullName = Item.Name + " " + Item.Surname;
            db.Set<Doctor>().Add(Item);
            db.SaveChanges();
        }

        public Doctor SelectByFullName(string itemFullname)
        {
            Doctor appUser = new Doctor();
            appUser = SelectAll().Where(x => x.FullName == itemFullname).FirstOrDefault();
            return appUser;
        }
    }
}
