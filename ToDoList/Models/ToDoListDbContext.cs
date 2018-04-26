using System;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoListDbContext : DbContext
    {
        public ToDoListDbContext()
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Port=8889;database=ToDoListWithMigrations;uid=root;pwd=root;");
        }

        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
