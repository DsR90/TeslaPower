using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TeslaPower.Migrations;


namespace TeslaPower.Models
{
    public class TeslaEntities:DbContext
    {
        public TeslaEntities():base("ConStr")
        {
            MigrateDatabaseToLatestVersion<TeslaEntities, Configuration> obj = new MigrateDatabaseToLatestVersion<TeslaEntities, Migrations.Configuration>();
            Database.SetInitializer(obj);
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Design> Designs { get; set; }
        public DbSet<CA> Ca { get; set; }
    }
}