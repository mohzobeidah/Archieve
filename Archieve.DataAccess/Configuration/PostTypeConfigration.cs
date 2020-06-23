using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
   public class PostTypeConfigration
    {

        public PostTypeConfigration(EntityTypeBuilder<PostType> entity)
        {

            if (DataContext.migrate) {
                entity.HasData(new PostType { Id = 1, PostName = "صادر",  IsDelete = false, InsertDate = DateTime.Now, UpdateDate = DateTime.Now });
                entity.HasData(new PostType { Id = 2, PostName ="وارد", IsDelete = false, InsertDate = DateTime.Now, UpdateDate = DateTime.Now });
            }

        }
    }
}
