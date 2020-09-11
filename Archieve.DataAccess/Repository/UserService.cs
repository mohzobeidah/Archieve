using Archieve.DataAccess.DataConfigration;
using Archieve.DataAccess.IRepository;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.Repository
{
    public class UserService : Repository<User>, IUserService
    {
        public UserService(DataContext dataContext) : base(dataContext)
        {

        }

        public IQueryable<User> GetUser(string filter, int initalPage, int pageSize, out int totalRecord, out int recordsFilter)
        {
            var data = GetQueryable(x=>1==1);
            totalRecord = GetQueryable(x => 1 == 1).Count();
            if (!string.IsNullOrEmpty(filter))
            {
                data = data.Where(c => c.UserName.ToLower().Contains(filter.ToLower()));
            }
            recordsFilter = data.Count();
            var fullData = data.OrderByDescending(x => x.Id)
                            .Skip(initalPage).Take(pageSize);
            return fullData;
        }

    }
}
