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
        private EntityTypeBuilder<Security> entityTypeBuilder;

        public SecurityConfiguration(EntityTypeBuilder<Security> entity)
        {

            if (DataContext.migrate)
                entity.HasData(new Security {  Id= 1,SecurityName = "سري", IsDelete = false, InsertDate=DateTime.Now, UpdateDate=DateTime.Now });

           

        }

       
    }
}
