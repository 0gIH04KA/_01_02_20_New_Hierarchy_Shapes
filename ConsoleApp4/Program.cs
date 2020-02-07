using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Program
    {
        public static Direction direction = Direction.NoAction;
        public static Action action = Action.NoAction;

        static void Main(string[] args)
        {
            #region ---===   SettingConsole   ===---

            Console.WindowWidth = (int)Constant.MAX_WIDTH;
            Console.WindowHeight = (int)Constant.MAX_HEIGHT;

            Console.CursorVisible = false;

            #endregion

            #region ---===   ContainerFigures   ===---

            Container container = new Container();

            container.AddFigure(new Square(4, 30, 6));

            container.AddFigure(new Circle(2, 20, 11));
            container.AddFigure(new Circle(3, 4, 4));
            container.AddFigure(new Circle(4, 20, 4));

           

            #endregion

            int activeFigureId = 0;
            Figure activeFigure = container[activeFigureId];

            do
            {
                UI.PrintAreaAndPerimetr(container, activeFigureId, 0, Constant.MAX_HEIGHT);

                activeFigure.Color = ConsoleColor.Magenta;

                for (int figureCounter = 0; figureCounter < container.ItemsCount; figureCounter++)
                {
                    container[figureCounter].Show();
                }

                ConsoleKey key = Console.ReadKey().Key;

                BL.SetActualKey(key, ref direction, ref action);
                BL.ButtonsEngine(container, ref activeFigure, ref activeFigureId, direction, action);


                //BL.ConsoleClear(Constant.MAX_WIDTH, Constant.MAX_HEIGHT-2);
               

            } while (action != Action.PressExit);
            

            Console.SetCursorPosition(0, Constant.MAX_HEIGHT-2);
            //Console.WriteLine($"P = {container[3].GetPerimetr()}");
            //Console.WriteLine($"S = {obj.GetArea()}");

            Console.ReadKey();

        }
    }
}
