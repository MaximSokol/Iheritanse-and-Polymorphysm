using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class ExcelentPuple : Puple
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPuple studies excelent!");
        }
        //-----------------------------

        public override void Read()
        {
            Console.WriteLine("ExcelentPuple is excelent at reading!");
        }
        //-----------------------------

        public override void Write()
        {
            Console.WriteLine("ExcelentPuple is excelent at writing!");
        }
        //-----------------------------

        public override void Relax()
        {
            Console.WriteLine("ExcelentPuple is excelent at relaxing!");
        }
        //-----------------------------
    }
}
