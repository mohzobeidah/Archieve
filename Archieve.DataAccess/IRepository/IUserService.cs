using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.IRepository
{
    public interface IUserService: IRepository<User>
    {
        IQueryable<User> GetUser(string filter, int initalPage, int pageSize, out int totalRecord, out int recordsFilter);
    }
}
