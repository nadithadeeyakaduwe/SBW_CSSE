using SBW.DataAccess.Infastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Repositories
{
    public abstract class RepositoryBase
    {
        private SBWEntities dataContext;

        public SBWEntities DbContext
        {
            get { return dataContext ?? (dataContext = new DbFactory().Init()); }
        }

        protected RepositoryBase()
        {
        }

        public void Commit()
        {
            if (this.DbContext != null)
            {
                this.DbContext.Commit();
            }
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            if (DbContext != null)
            {
                DbContext.Entry(entity).State = EntityState.Modified;

                DbContext.SaveChanges();
            }
        }
    }
}
