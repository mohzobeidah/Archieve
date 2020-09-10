using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class MailArchiveConfigration
    {

        public MailArchiveConfigration(EntityTypeBuilder<MailArchive> entity)
        {


            //entity

            //       .HasMany(t => t.)
            //       .HasForeignKey(m => m.HomeTeamId)
            //       .WillCascadeOnDelete(false);
        }
    }
}
