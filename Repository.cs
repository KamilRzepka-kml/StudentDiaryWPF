using StudentDiaryWPF.Models.Domains;
using StudentDiaryWPF.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDiaryWPF
{
    public class Repository
    {
        public List<Group> GetGroups()
        {
            using (var context = new ApplicationDBContext())
            {
                return context.Groups.ToList();
            }
        }
        
        public List<StudentWrapper> GetStudents(int groupId)
        {
            using (var context = new ApplicationDBContext())
            {
                var students = context
                    .Students
                    .Include(x => x.Group)
                    .Include(x => x.Raitings)
                    .AsQueryable();

                if (groupId != 0)
                    students = students.Where(x => x.GroupId == groupId);

                return students.ToList();
            }

        }
    }
}
   