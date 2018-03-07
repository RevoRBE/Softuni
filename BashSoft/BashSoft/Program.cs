using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Launcher
    {
        static void Main()
        {
            //IOManager.TraverseDirectory(@"C:\Users\Revolutionist\Documents\Visual Studio 2017\Projects\BashSoft");
            StudentsRepository.InitializeData();
            StudentsRepository.GetAllStudentsFromCourse("C#_Jul_2016");
        }
    }
}
