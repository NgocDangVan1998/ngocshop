using NgocShop.Data.Infrastructure;
using NgocShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Repositories
{
    public interface IMenuGroupRepository
    {

    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
