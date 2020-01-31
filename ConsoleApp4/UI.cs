using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    // ToDo: добавить в методы ниже bool параметр который отвечает за заполнение отрисовки!! 
    class UI
    {
        #region ---===   Draw_Rectangle   ===---

        public static void PrintRectangle(Rectangle rectangle)
        {
            Console.CursorVisible = false;

            for (int i = 0; i <= rectangle.SideA; i++)
            {
                for (int j = 0; j <= rectangle.SideB; j++)
                {
                    Console.SetCursorPosition(rectangle.Center.PosX + i, rectangle.Center.PosY +j);
                    Console.ForegroundColor = rectangle.Color;
                    Console.Write(rectangle.Symbol);
                }
            }
        }

        public static void PrintRectangle(Rectangle rectangle, ConsoleColor color)
        {
            Console.CursorVisible = false;

            for (int i = rectangle.Center.PosX; i < rectangle.SideA; i++)
            {
                for (int j = rectangle.Center.PosY; j < rectangle.SideB; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.ForegroundColor = color;

                    Console.Write(rectangle.Symbol);
                }
            }
        }

        #endregion

        #region ---===   Draw_Triangle   ===---

        public static void PrintTriangle(Triangle triangle)
        {
            throw new MyException("Дописать)"); //ToDo: Дописать)
        }

        public static void PrintTriangle(Triangle triangle, ConsoleColor color)
        {
            throw new MyException("Дописать)"); //ToDo: Дописать)
        }

        #endregion

        #region ---===   Draw_Circle   ===---

        public static void PrintCircle(Circle circle)
        {
            throw new MyException("Дописать)"); //ToDo: Дописать)
        }

        public static void PrintCircle(Circle circle, ConsoleColor color)
        {
            throw new MyException("Дописать)"); //ToDo: Дописать)
        }

        #endregion

    }
}
