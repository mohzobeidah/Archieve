using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.Repository
{
    public class ClassificationService : Repository<Classification>, IClassificationService
    {
        public ClassificationService(DataContext dataContext):base(dataContext)
        {
                    
        }

        //public async Task<Classification> deleteClassifiction(int? id,string username)
        //{
        //    Classification getid = await FindAsync(id);
        //    if (getid !=null)
        //    {
        //        getid.IsDelete = true;
        //        getid.UpdateDate = DateTime.UtcNow;
        //    }
        //    var xx=await UpdateAndLogAsync(getid,username);
        //    return null;
        //}

        public IQueryable<Classification> GetClassifications(string filter, int initalPage, int pageSize, out int totalRecord, out int recordsFilter)
        {
            var data = GetQueryable(c => c.IsDelete == false);
             totalRecord = GetQueryable(c => c.IsDelete == false).Count();
            if (!string.IsNullOrEmpty(filter))
            {
                data= data.Where(c => c.ClassificationName .ToLower().Contains(filter.ToLower()));
            }
            recordsFilter = data.Count();
            var fullData = data.OrderByDescending(x => x.InsertDate)
                            .Skip(initalPage).Take(pageSize);
            return fullData;
        }

    }
}
