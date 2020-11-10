using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.Data
{
    //public class ApplicationDbContext : DbContext
    //{
    //    public ApplicationDbContext()
    //    {
    //    }

    //    public ApplicationDbContext(DbContextOptions dbContextOptions)
    //        : base(dbContextOptions)
    //    {
    //    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        if (!optionsBuilder.IsConfigured)
    //        {
    //            optionsBuilder.UseSqlServer(@"Server=LAPTOP-722117P0\EMO;Database=ContainersCRM;Integrated Security=true;");
    //        }
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        //modelBuilder.Entity<UserCard>().HasKey(x => new { x.UserId, x.CardId });
    //        base.OnModelCreating(modelBuilder);
    //    }      
    //}
}
