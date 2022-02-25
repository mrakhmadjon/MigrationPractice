using Microsoft.EntityFrameworkCore;
using MigrationPractice.Data.Models;
using MigrationPractice.Data.Models.HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPractice.Data
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = (localdb)\MSSQLLocalDB;database = HotelListing;trusted_Connection=True; integrated security = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Uzbekistan", ShortName = "UZB" ,Language = "UZ"},
                new Country { Id = 2, Name = "Russia", ShortName = "RUS" , Language = "RU"},
                new Country { Id = 3, Name = "England", ShortName = "ENG", Language = "EN" }
                
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Internationa Uzb Hotel", Rating = 4.7, CountryId = 1},
                new Hotel { Id = 2, Name = "SuperContinental", Rating = 3.5, CountryId = 2},
                new Hotel { Id = 3, Name = "Internationa Uzb Hotel", Rating = 4.0, CountryId = 3}
                );



            //
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, FullName = "Abdusattor Ortiqov", Experience = 20, CardNumber = "6800101023233003" },
                new Teacher { Id = 2, FullName = "Sardor Komilov", Experience = 25, CardNumber = "6800101023235005" },
                new Teacher { Id = 3, FullName = "Jahongir Aripov", Experience = 28, CardNumber = "6800101023234004" }
                );

            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Math", TeacherId = 1 },
                new Subject { Id = 2, Name = "Physics", TeacherId = 2 },
                new Subject { Id = 3, Name = "Informatics", TeacherId = 3 });


            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Name = "MAth group"},
                new Group { Id = 2, Name = "Physics group" },
                new Group { Id = 3, Name = "Informatics group"}
                );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Alijon", LastName = "Karimov", Age = 20, GroupId = 1  },
                new Student { Id = 2, FirstName = "Javohir", LastName = "Jorayev", Age = 25, GroupId = 2  },
                new Student { Id = 3, FirstName = "Xurshid", LastName = "Torayev", Age = 26, GroupId = 3  }
                );

            modelBuilder.Entity<GroupsTeacher>().HasData(
                new GroupsTeacher { Id = 1, GroupId = 1, TeacherId = 1 },
                new GroupsTeacher { Id = 2, GroupId = 2, TeacherId = 3 },
                new GroupsTeacher { Id = 3, GroupId = 3, TeacherId = 3 }
                );
            

        }


        



    }
}
