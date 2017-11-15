using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    interface ISubjectManager
    {
        List<Subject> Subjects { get; }
        void AddSubject(Subject subject);
        void RemoveSubject(Subject subject);
        Subject GetSubjectByIndex(int index);
        Subject GetSubjectById(Guid id);
    }
}
