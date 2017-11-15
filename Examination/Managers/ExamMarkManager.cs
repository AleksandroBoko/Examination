using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination.Domain;

namespace Examination.Managers
{
    class ExamMarkManager : IExamMarkManager
    {
        public List<ExamMark> ExamMarks { get; private set; }

        public ExamMarkManager()
        {
            ExamMarks = new List<ExamMark>();
        }

        public void AddExamMark(ExamMark exm)
        {
            ExamMarks.Add(exm);
        }

        public ExamMark GetExamMarkById(Guid id)
        {
            return ExamMarks.Where(e => e.Id == id).First();
        }

        public ExamMark GetExamMarkByIndex(int index)
        {
            return ExamMarks[index];
        }

        public void RemoveExamMark(ExamMark exm)
        {
            ExamMarks.Remove(exm);
        }
    }
}
