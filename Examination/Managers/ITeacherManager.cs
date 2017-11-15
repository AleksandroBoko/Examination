using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    interface ITeacherManager
    {
        List<Person> GroupTeachers { get; }
        void AddTeacher(Person person);
        void RemoveTeacher(Person person);
        Person GetTeacherByIndex(int index);
        Person GetTeacherById(Guid id);
    }
}
