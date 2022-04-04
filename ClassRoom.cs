using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class ClassRoom
    {
        Random rand = new Random();
       public Puple[]puple = new Puple[4];
        //----------------------

        public ClassRoom(Puple p1, Puple p2)
        {
            puple[0] = p1;
            puple[1] = p2;
            puple[2] = GeneratePuple();
            puple[3] = GeneratePuple();
        }
        //---------------------------------------

        public ClassRoom(Puple p1, Puple p2, Puple p3)
        {
            puple[0] = p1;
            puple[1] = p2;
            puple[2] = p3;
            puple[3] = GeneratePuple();
        }
        //-------------------------------------------------

        public ClassRoom(Puple p1, Puple p2, Puple p3, Puple p4)
        {
            puple[0] = p1;
            puple[1] = p2;
            puple[2] = p3;
            puple[3] = p4;
        }
        //-------------------------------------------------

        public Puple GeneratePuple()
        {
            int r = rand.Next(1, 3);

            switch (r)
            {
                case 1: return new ExcelentPuple();
                case 2: return new GoodPuple();
                case 3: return new BadPuple();
            }
            return new BadPuple();
        }
        //-------------------------------------------------

        public void Study()
        {
            foreach(Puple value in puple)
            {
                value.Study();
            }
        }
        //------------------------

        public void Read()
        {
            foreach(Puple value in puple)
            {
                value.Read();
            }
        }
        //------------------------

        public void Write()
        {
            foreach(Puple value in puple)
            {
                value.Write();
            }
        }
        //------------------------

        public void Relax()
        {
            foreach (Puple value in puple)
            {
                value.Relax();
            }
        }
        //------------------------
    }
}
