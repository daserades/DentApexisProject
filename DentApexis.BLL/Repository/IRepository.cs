using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.BLL
{
    public interface IRepository<T> where T:class
    {
        void Insert(T item);

        void Update(T item);

        void Delete(T item);

        List<T> SelectAll();

        T SelectById(int itemID);


    }

}
