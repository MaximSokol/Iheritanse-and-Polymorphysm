using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task #1


            //string str = "Hello";

            //Print print = new Print();
            //print.ToPaint(str);

            //print = new Dauther1();
            //Dauther1 dauther1Obj = (Dauther1)print;
            //dauther1Obj.ToPaint(str);

            //Dauther1 objDau = null;
            //if(dauther1Obj is Dauther1)
            //{
            //    objDau = (Dauther1)dauther1Obj;
            //}
            //objDau.ToPaint(str);

            // Task #2

            //ClassRoom classRoomObj = new ClassRoom(new Puple(), new ExcelentPuple(), new GoodPuple(), new BadPuple());
            //classRoomObj.Study();
            //classRoomObj.Read();
            //classRoomObj.Write();
            //classRoomObj.Relax();

            // Task #3

            //Vehicle v = new Vehicle();
            //v = new Car(10, 30, 20.5, 200, "2019", 2.4, "Carbon");
            //v.ShowDate();

            //v = new Plane(10, 30, 20.5, 200, "2019", 8, 78);
            //v.ShowDate();

            //v = new Ship(10, 30, 47.5, 47, "2022", 145, "SomePlace");
            //v.ShowDate();

            // Task #4 


            string version = Console.ReadLine();
            if(version == "pro")
            {
                ProDocumentWorker pro = new ProDocumentWorker();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else if(version == "exp")
            {
                ExpertDocumentWorker exp = new ExpertDocumentWorker();
                exp.OpenDocument();
                exp.EditDocument();
                exp.SaveDocument();
            }
            else
            {
                DocumentWorker dw = new DocumentWorker();
                dw.OpenDocument();
                dw.EditDocument();
                dw.SaveDocument();
            }
        }
    }
}
