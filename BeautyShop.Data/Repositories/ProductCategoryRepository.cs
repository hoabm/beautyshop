using BeautyShop.Data.Infrastructure;
using BeautyShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace BeautyShop.Data.Repositories
{
    //Dinh nghia cac phuong thuc can phai them
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) 
            : base(dbFactory) // su dung :base(name) de goi den Constructor cua lop cha RepositoryBase
        {

        }

        //Cac phuong thuc khong nam trong RepositoryBase se tao trong nay
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(x => x.Alias == alias);
        }
    }
}
