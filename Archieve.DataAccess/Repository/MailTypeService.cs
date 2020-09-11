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
    public class MailTypeService : Repository<MailType>, IMailTypeService
    {
        public MailTypeService(DataContext dataContext):base(dataContext)
        {
                    
        }
        public IQueryable<MailType> GetMailTypes(string filter, 
            int initalPage, int pageSize, out int totalRecord, out int recordsFilter)
        {
            var data = GetQueryable(c => c.IsDeleted == false);
             totalRecord = data.Count();
            if (!string.IsNullOrEmpty(filter))
            {
                data= data.Where(c => c.MailName.ToLower().Contains(filter.ToLower()));
            }
            recordsFilter = data.Count();
            var fullData = data.OrderByDescending(x => x.InsertDate)
                            .Skip(initalPage).Take(pageSize);
            return fullData;
        }
    }
}
