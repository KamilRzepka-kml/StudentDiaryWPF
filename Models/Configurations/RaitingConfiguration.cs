using StudentDiaryWPF.Models.Domains;
using System.Data.Entity.ModelConfiguration;

namespace StudentDiaryWPF.Models.Configurations
{
    public class RaitingConfiguration : EntityTypeConfiguration<Raiting>
    {
        public RaitingConfiguration()
        {
            ToTable("dbo.Raitings");

            HasKey(x => x.Id);
        }
    }
}
