using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Puple
    {
        public virtual void Study()
        {
            Console.WriteLine("Puple studies not bad!");
        }
        //-----------------------------

        public virtual void Read()
        {
            Console.WriteLine("Puple is not bad at reading!");
        }
        //-----------------------------

        public virtual void Write()
        {
            Console.WriteLine("Puple is not bad at writing!");
        }
        //-----------------------------

        public virtual void Relax()
        {
            Console.WriteLine("Puple is not bad at relaxing!");
        }
        //-----------------------------
    }
}
