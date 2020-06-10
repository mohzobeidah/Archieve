using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Archieve.DataAccess.Repository
{
    public class EmployeeService : Repository<Employee>, IEmployeeService
    {
        public EmployeeService(DataContext dataContext):base(dataContext)
        {
                    
        }
        public IQueryable<Employee> GetEmployees(string filter, int initalPage, int pageSize, out int totalRecord, out int recordsFilter)
        {
            var data = GetQueryable(c => c.IsDelete == false);
             totalRecord = data.Count();
            if (!string.IsNullOrEmpty(filter))
            {
                data= data.Where(c => 
                                 c.FName.ToLower().Contains(filter.ToLower())||
                                 c.EmpId.ToString().ToLower().Contains(filter.ToLower())||
                                 c.FinID.ToLower().Contains(filter.ToLower()));
            }
            recordsFilter = data.Count();
            var fullData = data.OrderByDescending(x => x.InsertDate)
                            .Skip(initalPage).Take(pageSize);
            return fullData;
        }
    }
}
