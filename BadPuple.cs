using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class BadPuple : Puple
    {
        public override void Study()
        {
            Console.WriteLine("BadPuple studies bad!\n");
        }
        //-----------------------------

        public override void Read()
        {
            Console.WriteLine("BadPuple is good at bad!\n");
        }
        //-----------------------------

        public override void Write()
        {
            Console.WriteLine("BadPuple is good at bad!\n");
        }
        //-----------------------------

        public override void Relax()
        {
            Console.WriteLine("BadPuple is good at bad!\n");
        }
        //-----------------------------
    }
}
