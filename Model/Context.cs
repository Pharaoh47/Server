using System;
using Microsoft.EntityFrameworkCore;
using Bogus;
using Bogus.Extensions;

namespace Server.Model
{
    public class Context: DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public Context(){
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={AppContext.BaseDirectory}store.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            var resourceId = 1;
            var resources = new Faker<Resource>()
                .RuleFor(r => r.Id, _ => resourceId++)
                .RuleFor(r => r.Name, f => f.Hacker.Phrase())
                .RuleFor(r => r.Link, f => f.Internet.Url());
            modelBuilder.Entity<Resource>().HasData(resources.Generate(4700));
        }

    }
}