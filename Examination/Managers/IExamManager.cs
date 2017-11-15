using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    interface IExamManager
    {
        List<Exam> Exams { get; }
        void AddExam(Exam ex);
        void RemoveExam(Exam ex);
        Exam GetExamByIndex(int index);
        Exam GetExamById(Guid id);
    }
}
