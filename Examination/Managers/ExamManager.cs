using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Managers
{
    class ExamManager: IExamManager
    {
        public List<Exam> Exams { get; private set; }

        public ExamManager()
        {
            Exams = new List<Exam>();
        }

        public void AddExam(Exam ex)
        {
            Exams.Add(ex);
        }

        public void RemoveExam(Exam ex)
        {
            Exams.Remove(ex);
        }

        public Exam GetExamByIndex(int index)
        {
            return Exams[index];
        }

        public Exam GetExamById(Guid id)
        {
            return Exams.Where(e => e.Id == id).First();
        }
    }
}
