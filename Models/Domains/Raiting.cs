using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiaryWPF.Models.Domains
{
    public class Raiting
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
    }
}
