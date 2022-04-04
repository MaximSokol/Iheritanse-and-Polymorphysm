using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Dauther2 : Print
    {
        public void ToPaint(string str)
        {
            Console.WriteLine($"{str}", Console.ForegroundColor = ConsoleColor.Red);
        }
        //------------------------------------------
    }
}
