using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BeautyShopDbContext dbContext;

        public BeautyShopDbContext Init()
        {
            return dbContext ?? (dbContext = new BeautyShopDbContext()); //Neu null khoi tao
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}