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
            
            #region ---===   Setting Console   ===---

            Console.WindowWidth = (int)Constant.MAX_WIDTH;
            Console.WindowHeight = (int)Constant.MAX_HEIGHT;

            Console.CursorVisible = false;

            #endregion

            #region ---===   Message For User   ===---

            int index = 0;
            string[] Message = new string[]
            {
                "Hello User (:",
                " ",
                "This program shows using some things of OOP",
                "Namely Encapsulation, Inheritance, Polymorphism",
                "As well Abstract classes and practical use Interface.",
                " ",
                "Now in the program such functions are available:",
                "- Figure movement, to move, press on the Arrows on the keyboard",
                "- Selected figure, to select next figure, press 'TAB' ",
                "- Increase and Decrease the selected figure press 'F1' / 'F2'",
                "- For selected figure in the left corner there is a calculation",
                "  of the perimeter and area",
                "- Exit the program, press 'ESC'",
                "",
                "After pressing any application button to enter the operating mode",
            };


            for
                (
                int i = (Constant.MAX_WIDTH / 5);
                i < (Constant.MAX_WIDTH / 5) + 1;
                i++
                )
            {
                for
                    (
                    int j = (Constant.MAX_HEIGHT / 5);
                    j < (Constant.MAX_HEIGHT / 5) + Message.Length;
                    j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write($"{Message[index++]}");
                }
            }

            Console.ReadKey();
            UI.ClearConsole();

            #endregion

            #region ---===   Container Figures   ===---

            Container container = new Container();

            container.AddFigure(Container.NewRectangle(new Point(30, 15), 7, 4));

            container.AddFigure(Container.NewSquare(new Point(30, 6), 4));

            container.AddFigure(Container.NewCircle(new Point(20, 11), 2));
            container.AddFigure(Container.NewCircle(new Point(4, 4), 3));
            container.AddFigure(Container.NewCircle(new Point(20, 4), 4));

            #endregion

            int activeFigureId = 0;
            Figure activeFigure = container[activeFigureId];

            do
            {
                UI.PrintAreaAndPerimetr(container, activeFigureId, 0, Constant.MAX_HEIGHT);

                activeFigure.Color = ConsoleColor.Magenta;

                container.Show();

                ConsoleKey key = Console.ReadKey().Key;

                BL.SetActualKey(key, ref direction, ref action);
                BL.ButtonsEngine(container, ref activeFigure, ref activeFigureId, direction, action);

            } while (action != Action.PressExit);

        }
    }
}
