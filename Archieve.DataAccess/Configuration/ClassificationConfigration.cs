using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class ClassificationConfigration
    {

        public ClassificationConfigration(EntityTypeBuilder<Classification> entity)
        {

            if (DataContext.migrate)
                entity.HasData(new Classification { Id = 1, ClassificationName = "دولي ", IsDelete = false, InsertDate = DateTime.Now, UpdateDate = DateTime.Now });



        }
    }
}
