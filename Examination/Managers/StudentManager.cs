using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    class StudentManager:IStudentManager
    {
        public List<Person> GroupStudents { get; private set; }

        public StudentManager()
        {
            GroupStudents = new List<Person>();
        }

        public void AddStudent(Person student)
        {
            GroupStudents.Add(student);
        }

        public void RemoveStudent(Person student)
        {
            GroupStudents.Remove(student);
        }

        public Person GetStudentByIndex(int index)
        {
            return GroupStudents[index];
        }

        public Person GetStudentById(Guid id)
        {
            Person result = null;
            for(int i = 0; i < GroupStudents.Count; i++)
            {
                if(GroupStudents[i].Id == id)
                {
                    result = GroupStudents[i];
                    break;
                }
            }
            return result;
        }


    }
}
