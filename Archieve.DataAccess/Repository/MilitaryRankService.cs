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
    public class MilitaryRankService : Repository<MilitaryRank>, IMilitaryRankService
    {
        public MilitaryRankService(DataContext dataContext):base(dataContext)
        {
                    
        }


    }
}
