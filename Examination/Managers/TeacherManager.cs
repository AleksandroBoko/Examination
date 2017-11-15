using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    class TeacherManager: ITeacherManager
    {
        public List<Person> GroupTeachers { get; private set; }

        public TeacherManager()
        {
            GroupTeachers = new List<Person>();
        }

        public void AddTeacher(Person person)
        {
            GroupTeachers.Add(person);
        }

        public void RemoveTeacher(Person person)
        {
            GroupTeachers.Remove(person);
        }

        public Person GetTeacherByIndex(int index)
        {
            return GroupTeachers[index];
        }

        public Person GetTeacherById(Guid id)
        {
            return GroupTeachers.Where(t => t.Id == id).First();
        }
    }
}
