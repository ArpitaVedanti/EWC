using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EWC.Models;
using Microsoft.EntityFrameworkCore;



namespace EWC.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
     {
        
     }   
     public DbSet<Category> Categorys { get; set;}
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    //     {
    //         modelBuilder.Entity<Category>().HasData(
               
    //             new Category { Id = 1, Name = "Action", DisplayOrder = 1}, 
    //             new Category { Id = 2, Name = "SciFi", DisplayOrder = 2},
    //             new Category { Id = 3, Name = "Comedy", DisplayOrder = 3 },
    //             new Category { Id = 4, Name = "History", DisplayOrder = 4 }
    //             );
    //     }
    }
}