using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DiplomMisha.Model
{
    public class ApplicationContext : DbContext
    {
        private ApplicationContext()
        {
            Database.EnsureCreated();
        }
        private static ApplicationContext connectionHandler;
        public static ApplicationContext GetDbConnectionHandler()
        {
            if (connectionHandler == null)
            {
                connectionHandler = new ApplicationContext();
            }
            return connectionHandler;
        }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<GroupOfStudent> GroupOfStudents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NU9F27O;User ID = sa; Password = Deep2000;Database=helloappdb;Trusted_Connection=True;");            
            //optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=helloappdb;");
        }
    }
}

