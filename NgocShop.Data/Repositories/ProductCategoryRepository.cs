using NgocShop.Data.Infrastructure;
using NgocShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
        ProductCategory Add(ProductCategory entity);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }

        public virtual ProductCategory Add(ProductCategory entity)
        {
            return this.DbContext.ProductCategories.Add(entity);
        }
    }
}
