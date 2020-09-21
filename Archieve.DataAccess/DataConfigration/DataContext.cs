using Archieve.DataAccess.Configuration;
using Archieve.DataAccess.ViewModel;
using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.DataConfigration
{
    public class DataContext:IdentityDbContext<User,IdentityRole, string>
    {
        public static bool migrate = true;
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
        public DbSet<MilitaryRank> MilitaryRanks { get; set; }

        public DbSet<UserActivity> UserActivities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            new MailTypeConfiguration(modelBuilder.Entity<MailType>());
            new SecurityConfiguration(modelBuilder.Entity<Security>());
            new ClassificationConfigration(modelBuilder.Entity<Classification>());
            new PostTypeConfigration(modelBuilder.Entity<PostType>());
            new StatusConfigration(modelBuilder.Entity<Status>());
            new WorkPlaceConfigration(modelBuilder.Entity<WorkPlace>());
            new StructureTypeConfigration(modelBuilder.Entity<StructureType>());
            new MailArchiveConfigration(modelBuilder.Entity<MailArchive>());
            new MilitaryRankConfigration(modelBuilder.Entity<MilitaryRank>());

            modelBuilder.Ignore<GeneralEntity>();
        }
    }
}
