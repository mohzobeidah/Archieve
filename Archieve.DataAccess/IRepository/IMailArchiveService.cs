using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Archieve.DataAccess.IRepository
{
   public interface IMailArchiveService : IRepository<MailArchive>
    {
        IQueryable<MailArchive> GetMailArchives(string filter, int initalPage, int pageSize,
                                 out int totalRecord,
                                 out int recordsFilter);
        Task<MailArchive> getMailArchiveById(int? id, CancellationToken ct = default(CancellationToken));
        //public async Task<Classification> deleteClassifiction(int? id, string username);

        Task<bool> CheckIfArchivceNumberExist(string name);
    }
     
}
