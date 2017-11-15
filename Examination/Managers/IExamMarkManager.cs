using Examination.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    interface IExamMarkManager
    {
        List<ExamMark> ExamMarks { get; }
        void AddExamMark(ExamMark exm);
        void RemoveExamMark(ExamMark exm);
        ExamMark GetExamMarkByIndex(int index);
        ExamMark GetExamMarkById(Guid id);
    }
}
