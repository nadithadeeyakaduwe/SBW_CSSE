using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Infastructure
{
    public class DbFactory
    {
        static SBWEntities dbContext;
        public SBWEntities Init()
        {
            return dbContext ?? (dbContext = new SBWEntities());
        }
    }
}
