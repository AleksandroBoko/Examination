using Examination.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Program
    {
        static MainView mainView;

        static void Main(string[] args)
        {
            //Teacher t = new Teacher();
            //Console.WriteLine(t.GetTeacherCoef());
            //Console.WriteLine(t.GetTeacherCoef());
            //Console.WriteLine(t.GetTeacherCoef());
            //Console.WriteLine(t.GetTeacherCoef());

            InitView();
            ShowView();

            Console.ReadKey();
        }

        static void InitView()
        {
            mainView = new MainView();
        }

        static void ShowView()
        {
            mainView.Modulate();
            mainView.ShowModulateResult();
        }
    }
}
