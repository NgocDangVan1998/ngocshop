using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        NgocShopDbContext dbContext;
        public NgocShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NgocShopDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null) 
                dbContext.Dispose();
        }
    }
}
