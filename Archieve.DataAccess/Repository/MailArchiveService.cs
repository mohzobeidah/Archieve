using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Microsoft.AspNetCore.Routing;

namespace Archieve.DataAccess.Repository
{
    public class MailArchiveService : Repository<MailArchive>, IMailArchiveService
    {
        public MailArchiveService(DataContext dataContext):base(dataContext)
        {
                    
        }

        public async Task<bool> CheckIfArchivceNumberExist(string name)
        {
            if (!string.IsNullOrEmpty(name))
            return await GetQueryable(m => m.MailId == name.Trim()).AnyAsync();
            return false;
        }

        public async Task<MailArchive> getMailArchiveById(int? id , CancellationToken ct = default(CancellationToken))
        {

            var mailArchive = await GetQueryable(m => m.ID == id)                       
                                                                 .Include(x=>x.MailType)
                                                                 .Include(x => x.PostType)
                                                                 .Include(x => x.Status)
                                                                 .Include(x => x.Security)
                                                                 .Include(x => x.Classification)

                                                                 .FirstOrDefaultAsync(ct);

            return mailArchive;
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

        public IQueryable<MailArchive> GetMailArchives(string filter, int initalPage, int pageSize, out int totalRecord, out int recordsFilter)
        {
            var data = GetQueryable(c => c.IsDelete == false);
             totalRecord = GetQueryable(c => c.IsDelete == false).Count();
            if (!string.IsNullOrEmpty(filter))
            {
                data = data.Where(c => c.Topic.ToLower()
                 .Contains(filter.ToLower()));
            }
            data=data.Include(x => x.Security).Include(x => x.user).Include(x => x.FromJehazId)
                .Include(x => x.ToJehazId).Include(y=>y.PostType).Include(x=>x.Status).Include(f=>f.MailType).Include(o=>o.Classification); 
            recordsFilter = data.Count();
            var fullData = data.OrderByDescending(x => x.InsertDate)
                            .Skip(initalPage).Take(pageSize);
            return fullData;
        }

    }
}
