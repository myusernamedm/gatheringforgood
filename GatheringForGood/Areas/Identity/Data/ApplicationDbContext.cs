using System;
using System.Collections.Generic;
using System.Text;
using GatheringForGood.Areas.Identity;
using GatheringForGood.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GatheringForGood.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public DbSet<UserEnvironmentalActionCounts> UserEnvironmentalActionCounts { get; set; }
        public DbSet<SiteEnvironmentalActionCounts> SiteEnvironmentalActionCounts { get; set; }
        public DbSet<UserFeedback> UserFeedback { get; set; }
        public DbSet<UserContact> UserContact { get; set; }
        public DbSet<CountryList> CountryList { get; set; }
        public DbSet<FeaturedCodesList> FeaturedCodesList { get; set; }
        public DbSet<SkillsList> SkillsList { get; set; }
        public DbSet<InterestsList> InterestsList { get; set; }
        public DbSet<ArticlesList> ArticlesList { get; set; }
        public DbSet<ArticleDetails> ArticleDetails { get; set; }
        public DbSet<OffsetMyCarbonReceipts> OffsetMyCarbonReceipts { get; set; }
        public DbSet<UserBadges> UserBadges { get; set; }

        readonly DBConnectionStringFactory GetDBConnectionString = new();
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = GetDBConnectionString.DBConnectionString();

            optionsBuilder.UseSqlServer(ConnectionString).LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },LogLevel.Information).EnableSensitiveDataLogging(); //add to be able to see parameters in your log
        }
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }
        
    }
}
