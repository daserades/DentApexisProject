using DentApexis.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.BLL.Singleton
{
    public class DbTool
    {
        private static DentApexisDBContext _Instance;

        public static DentApexisDBContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DentApexisDBContext();
                }
                return _Instance;
            }

        }


    }
}
