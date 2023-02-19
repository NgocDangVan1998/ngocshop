using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NgocShopDbContext Init();
    }
}
