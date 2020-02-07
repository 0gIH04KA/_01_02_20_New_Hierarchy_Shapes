using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class BL
    {
        public static void SetActualKey(ConsoleKey key, ref Direction direction, ref Action action)
        {
            action = SetAction(key);
            direction = SetDirection(key);
        }

        private static Direction SetDirection(ConsoleKey key)
        {
            Direction direction;
            switch (key)
            {
                case ConsoleKey.LeftArrow:

                    direction = Direction.Left;

                    break;

                case ConsoleKey.RightArrow:

                    direction = Direction.Right;

                    break;

                case ConsoleKey.UpArrow:

                    direction = Direction.Up;

                    break;


                case ConsoleKey.DownArrow:

                    direction = Direction.Down;

                    break;

                default:

                    direction = Direction.NoAction;

                    break;
            }

            return direction;
        }

        private static Action SetAction(ConsoleKey key)
        {
            Action action;
            switch (key)
            {
                case ConsoleKey.Escape:

                    action = Action.PressExit;

                    break;

                case ConsoleKey.Tab:

                    action = Action.Tabulation;

                    break;

                case ConsoleKey.F1: // размер фигуры++

                    action = Action.ResizeIncrease;

                    break;

                case ConsoleKey.F2: // размер фигуры--

                    action = Action.ResizeReduction;

                    break;

                default:

                    action = Action.NoAction;

                    break;
            }

            return action;
        }

        public static void ButtonsEngine(Container container, ref Figure activeFigure, ref int activeFigureId, Direction direction, Action action)
        {
            MoveObject(ref activeFigure, direction);
            ActionObject(container, ref activeFigure, ref activeFigureId, action);
        }

        private static void MoveObject(ref Figure activeFigure, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:

                    activeFigure.Hide();
                    activeFigure.Move(1, 0);
                    activeFigure.Show();

                    break;

                case Direction.Left:

                    activeFigure.Hide();
                    activeFigure.Move(-1, 0);
                    activeFigure.Show();

                    break;

                case Direction.Up:

                    activeFigure.Hide();
                    activeFigure.Move(0, -1);
                    activeFigure.Show();

                    break;

                case Direction.Down:

                    activeFigure.Hide();
                    activeFigure.Move(0, 1);
                    activeFigure.Show();

                    break;
            }
            
        }

        private static void ActionObject(Container container, ref Figure activeFigure, ref int activeFigureId, Action action)
        {
            switch (action)
            {
                case Action.Tabulation:

                    if (activeFigureId < container.ItemsCount -1) 
                    {
                        activeFigure.Color = ConsoleColor.White; 
                        activeFigure = container.Figures[++activeFigureId];
                    }
                    else 
                    {
                        activeFigureId = 0;
                        activeFigure.Color = ConsoleColor.White; 
                        activeFigure = container.Figures[activeFigureId];
                    }

                    break;

                case Action.ResizeIncrease:

                    activeFigure.Hide();
                    activeFigure.Resize(1);
                    activeFigure.Show();

                    break;

                case Action.ResizeReduction:

                    activeFigure.Hide();
                    activeFigure.Resize(-1);
                    activeFigure.Show();

                    break;
            }
            
        }

    }
}
