using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Armchair_rest_server.Models
{
    public class ArmchairDB : IdentityDbContext<IdentityUser>
    {
        public ArmchairDB() : base("name=ArmchairDB")
        {
            Database.SetInitializer<ArmchairDB>(null);
        }

        public DbSet<Furniture> Furniture { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Like> Likes { get; set; }

        //protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}