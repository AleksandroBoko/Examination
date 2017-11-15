using Examination.Domain;
using Examination.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.UI
{
    class MainView
    {
        IStudentManager studentManager;
        ITeacherManager teacherManager;
        ISubjectManager subjectManager;
        IExamManager examManager;
        IExamMarkManager examMarkManager;

        public MainView()
        {
            studentManager = new StudentManager();
            teacherManager = new TeacherManager();
            subjectManager = new SubjectManager();
            examManager = new ExamManager();
            examMarkManager = new ExamMarkManager();
        }

        public void Modulate()
        {
            ModulateStudents();
            ModulateTeachers();
            ModulateSubjects();
            ModulateExams();
            ModulateExamMarks();
        }

        void ModulateStudents()
        {
            studentManager.AddStudent(new Student() { Id = Guid.NewGuid(), FirstName = "Sasha", LastName = "Bond" });
            studentManager.AddStudent(new Student() { Id = Guid.NewGuid(), FirstName = "Irina", LastName = "Tomenko" });
            studentManager.AddStudent(new Student() { Id = Guid.NewGuid(), FirstName = "Grisha", LastName = "Kostenko" });
            studentManager.AddStudent(new Student() { Id = Guid.NewGuid(), FirstName = "Sergey", LastName = "Budko" });
        }

        void ModulateTeachers()
        {
            teacherManager.AddTeacher(new Teacher() { Id = Guid.NewGuid(), FirstName = "Igor", LastName = "Skvorets" });
        }

        void ModulateSubjects()
        {
            subjectManager.AddSubject(new Subject() { Id = Guid.NewGuid(), Name = ".Net" });
        }

        void ModulateExams()
        {
            Subject subject = subjectManager.GetSubjectByIndex(0);
            examManager.AddExam(new Exam() {Id = Guid.NewGuid(), SubjectId = subject.Id, Name = "C# basic constractions" });
        }

        void ModulateExamMarks()
        {
            Exam exam = examManager.GetExamByIndex(0);
            Teacher teacher = teacherManager.GetTeacherByIndex(0) as Teacher;
            for (int i = 0; i < studentManager.GroupStudents.Count; i++)
            {
                Student student = studentManager.GetStudentByIndex(i) as Student;
                examMarkManager.ExamMarks.Add(
                        new ExamMark() { Id = Guid.NewGuid(),
                            ExamId = exam.Id,
                            TeacherId = teacher.Id,
                            StudentId = student.Id,
                            Value = student.GetStudentCoef() * teacher.GetTeacherCoef()
                        });
            }
        }

        public void ShowModulateResult()
        {
            var result = from student in studentManager.GroupStudents
                         from teacher in teacherManager.GroupTeachers
                         from subject in subjectManager.Subjects
                         from exam in examManager.Exams
                         from examMark in examMarkManager.ExamMarks
                         where student.Id == examMark.StudentId
                         where subject.Id == exam.SubjectId
                         where teacher.Id == examMark.TeacherId
                         where exam.Id == examMark.ExamId
                         select new
                         {
                             SubjectName = subject.Name,
                             ExamName = exam.Name,
                             StudentFName = student.FirstName,
                             StudentLName = student.LastName,
                             TeacherFName = teacher.FirstName,
                             TeacherLName = teacher.LastName,
                             ExamMarkValue = examMark.Value
                         };

            if (result != null)
                result.ToList().ForEach(n => 
                Console.WriteLine($"subject: {n.SubjectName}\n" +
                                  $"topic: {n.ExamName}\n" +
                                  $"student: {n.StudentFName} {n.StudentLName}\n" +
                                  $"teacher: {n.TeacherFName} {n.TeacherLName}\n" +
                                  $"mark: {n.ExamMarkValue}\n"));
        }
    }
}
