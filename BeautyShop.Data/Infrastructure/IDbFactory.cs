using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {   
        BeautyShopDbContext Init(); //la 1 phuong thuc, de khoi tao
    }
}
