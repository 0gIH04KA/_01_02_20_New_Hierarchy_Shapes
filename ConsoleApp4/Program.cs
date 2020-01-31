using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Constant.MAX_WIDTH, Constant.MAX_HEIGHT);

            Container c1 = new Container();


            var obj = new Square(3, 1, 1);
            obj.Show();

            Console.SetCursorPosition(0, 10);
            Console.WriteLine($"P = {obj.GetPerimetr()}");
            Console.WriteLine($"S = {obj.GetArea()}");

            Console.ReadKey();

        }
    }
}
