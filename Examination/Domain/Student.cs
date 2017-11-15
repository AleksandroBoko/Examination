using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Student : Person
    {
        public int GetStudentCoef()
        {
            return PersonRandom.Next(80, 100);
        }
    }
}
