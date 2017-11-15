using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    interface IStudentManager
    {
        List<Person> GroupStudents { get; }
        void AddStudent(Person student);
        void RemoveStudent(Person student);
        Person GetStudentByIndex(int index);
        Person GetStudentById(Guid id);
    }
}
