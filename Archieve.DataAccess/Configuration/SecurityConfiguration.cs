using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class SecurityConfiguration
    {
    

        public SecurityConfiguration(EntityTypeBuilder<Security> entity)
        {


            if (DataContext.migrate)
            {
                entity.HasData(new Security { Id = 1, SecurityName = "عادي", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new Security { Id = 2, SecurityName = "سري", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
            }
        }




    }


}

