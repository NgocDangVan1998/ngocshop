using NgocShop.Data.Infrastructure;
using NgocShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Repositories
{
    public interface IOrderDetailRepository
    {

    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IMenuRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
