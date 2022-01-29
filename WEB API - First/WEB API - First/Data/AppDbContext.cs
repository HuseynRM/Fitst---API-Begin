using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API___First.Models;

namespace WEB_API___First.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public virtual  DbSet<Student> Students { get; set; }

        //seed data  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1 ,
                    Name = "Huseyn" ,
                    Surname= "Mammadov", 
                    CreatedAt=DateTime.UtcNow.AddHours(+4), 
                    CreatedBy="System", 
                    Isdeleted = false
                },
                 new Student
                 {
                     Id = 2,
                     Name = "Ali",
                     Surname = "Aliyev",
                     CreatedAt = DateTime.UtcNow.AddHours(+4),
                     CreatedBy = "System",
                     Isdeleted = false
                 }
            );
        }
    }
}
