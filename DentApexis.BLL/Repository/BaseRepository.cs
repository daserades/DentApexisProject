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
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private DentApexisDBContext db;
        public BaseRepository()
        {
            db = DbTool.Instance;

        }

        public void Delete(T item)
        {
            db.SaveChanges();

        }

        public void Insert(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();

        }

        public List<T> SelectAll()
        {
            return db.Set<T>().ToList();

        }

        public T SelectById(int itemID)
        {
            return db.Set<T>().Find(itemID);
        }

        public void Update(T item)
        {
            T update = item;
            db.Entry(update).CurrentValues.SetValues(item);
            db.SaveChanges();

        }
    }
}
