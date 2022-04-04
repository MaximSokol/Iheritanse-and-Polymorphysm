using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class GoodPuple : Puple
    {
        public override void Study()
        {
            Console.WriteLine("GoodPuple studies good!");
        }
        //-----------------------------

        public override void Read()
        {
            Console.WriteLine("GoodPuple is good at reading!");
        }
        //-----------------------------

        public override void Write()
        {
            Console.WriteLine("GoodPuple is good at writing!");
        }
        //-----------------------------

        public override void Relax()
        {
            Console.WriteLine("GoodPuple is good at relaxing!");
        }
        //-----------------------------
    }
}
