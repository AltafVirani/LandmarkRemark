using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Landmark_Remark.Models;

    public class Landmark_RemarkContext : DbContext
    {
        public Landmark_RemarkContext (DbContextOptions<Landmark_RemarkContext> options)
            : base(options)
        {
        }

        public DbSet<Landmark_Remark.Models.LocationMarker> LocationMarker { get; set; }

        public DbSet<Landmark_Remark.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserID=5,
                FirstName = "Altaf",
                LastName = "Virani",
                UserName = "Altaf",
                Password = "Altaf"               
            },
            new User
            {
                UserID = 6,
                FirstName = "Guest FName",
                LastName = "Guest LName",
                UserName = "Guest",
                Password = "Guest"
            },
            new User
            {
                UserID = 7,
                FirstName = "Mark",
                LastName = "Taylor",
                UserName = "Mark",
                Password = "Mark"
            }
        );
        }
}
