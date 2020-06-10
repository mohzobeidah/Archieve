using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.DataConfigration
{
    public class DataContext:IdentityDbContext<User>
    {

        public DataContext(DbContextOptions<DataContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ImageArchive> ImageArchives { get; set; }
        public DbSet<MailArchive> MailArchives { get; set; }
        public DbSet<MailType> MailTypes { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
        public DbSet<StructureType> StructureTypes { get; set; }
    }
}
