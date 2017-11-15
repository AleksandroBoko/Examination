using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    class SubjectManager: ISubjectManager
    {
        public List<Subject> Subjects { get; private set; }

        public SubjectManager()
        {
            Subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

        public void RemoveSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

        public Subject GetSubjectByIndex(int index)
        {
            return Subjects[index];
        }

        public Subject GetSubjectById(Guid id)
        {
            return Subjects.Where(s => s.Id == id).First();
        }

    }
}
