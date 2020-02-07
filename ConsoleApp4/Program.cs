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
