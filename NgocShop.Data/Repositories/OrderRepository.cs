using NgocShop.Data.Infrastructure;
using NgocShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Repositories
{
    public interface IOrderRepository
    {

    }
    public class OrderRepository : RepositoryBase<Order>, IMenuRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
