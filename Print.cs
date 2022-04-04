using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Print
    {
        public virtual void ToPaint(string str) 
        { 
            Console.WriteLine($"{str}", Console.ForegroundColor = ConsoleColor.Yellow);
        }
        //---------------------------------------
    }
}
