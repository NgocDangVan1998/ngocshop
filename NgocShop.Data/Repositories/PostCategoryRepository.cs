using NgocShop.Data.Infrastructure;
using NgocShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
        PostCategory Add(PostCategory entity);
    }
    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public virtual PostCategory Add(PostCategory entity)
        {
            return DbContext.PostCategories.Add(entity);
        }
    }
}
