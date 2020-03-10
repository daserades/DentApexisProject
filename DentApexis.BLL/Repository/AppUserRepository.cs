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
    public class AppUserRepository: BaseRepository<AppUser>
    {
        private DentApexisDBContext db;
        public AppUserRepository()
        {
            db = DbTool.Instance;

        }
        public new void Insert(AppUser Item)
        {
            Item.FullName = Item.Name + " " + Item.LastName;
            db.Set<AppUser>().Add(Item);
            db.SaveChanges();
        }
        public AppUser SelectByFullName(string itemFullname)
        {
            AppUser appUser = new AppUser();
            appUser = SelectAll().Where(x => x.FullName == itemFullname).FirstOrDefault();
            return appUser;
        }
    }
}
