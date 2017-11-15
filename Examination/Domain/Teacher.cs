using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Teacher : Person
    {
        public double GetTeacherCoef()
        {
            double result = 0;
            do
            {
                result = Math.Round(PersonRandom.NextDouble(),1);
            }
            while (result < 0.5);


            return result; 
        }
    }
}
