using StudentDiaryWPF.Models.Configurations;
using StudentDiaryWPF.Models.Domains;
using StudentDiaryWPF.Properties;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace StudentDiaryWPF
{
    public class ApplicationDBContext : DbContext
    {
        private static string _connectionString = $@"
            Server={Settings.Default.ServerAdress}\{Settings.Default.ServerName};
            Database={Settings.Default.Database};
            User Id={Settings.Default.User};
            Password={Settings.Default.Password};";

        public ApplicationDBContext()
            : base(_connectionString)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new RaitingConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
                
        }
    }

}