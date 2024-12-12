using StudentDiaryWPF.Models.Configurations;
using StudentDiaryWPF.Models.Domains;
using System;
using System.Data.Entity;
using System.Linq;

namespace StudentDiaryWPF
{
    public class ApplicationDBContext : DbContext
    {
   
        public ApplicationDBContext()
            : base("name=ApplicationDBContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Raiting> Raitings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new RaitingConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
                
        }
    }

}