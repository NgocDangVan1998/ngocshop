using NgocShop.Data.Infrastructure;
using NgocShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
        Error Add(Error entity);
    }
    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory) 
        {
            
        }

        public virtual Error Add(Error entity)
        {
            return DbContext.Errors.Add(entity);
        }
    }
}
