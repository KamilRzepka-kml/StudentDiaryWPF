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
     
    }

}