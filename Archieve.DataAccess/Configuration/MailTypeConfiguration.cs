using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class MailTypeConfiguration
    {
       

        public MailTypeConfiguration(EntityTypeBuilder<MailType> entity)
        {

            if (DataContext.migrate) { 
                entity.HasData(new MailType {  Id= 1,MailName = "داخي", IsDelete = false ,  InsertDate= DateTime.Now , UpdateDate= DateTime.Now });
                entity.HasData(new MailType { Id = 2, MailName = "خارجي", IsDelete = false, InsertDate = DateTime.Now, UpdateDate = DateTime.Now });

            }

        }

       
    }
}
