using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class UI
    {
        #region ---===   Draw_Point   ===---

        public static void PrintPoint(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"{sym}");
        }

        public static void PrintPoint(int x, int y, char sym, ConsoleColor color)
        { 
            Console.ForegroundColor = color;
            PrintPoint(x, y, sym);
            Console.ResetColor();
        }

        #endregion

        #region ---===   Draw_Rectangle   ===---

        public static void PrintRectangle(Rectangle rectangle)
        {
            for (int i = 0; i <= rectangle.SideA; i++)
            {
                for (int j = 0; j <= rectangle.SideB; j++)
                {
                    PrintPoint(rectangle.Center.PosX + i, 
                               rectangle.Center.PosY + j, 
                               rectangle.Symbol, 
                               rectangle.Color);
                }
            }
        }

        public static void PrintRectangle(Rectangle rectangle, ConsoleColor color)
        {
            for (int i = 0; i <= rectangle.SideA; i++)
            {
                for (int j = 0; j <= rectangle.SideB; j++)
                {
                    PrintPoint(rectangle.Center.PosX + i,
                               rectangle.Center.PosY + j,
                               rectangle.Symbol,
                               color);
                }
            }
        }

        #endregion

        #region ---===   Draw_Square   ===---

        public static void PrintSquare(Square square)
        {
            for (int i = 0; i <= square.SideA; i++)
            {
                for (int j = 0; j <= square.SideA; j++)
                {
                    PrintPoint(square.Center.PosX + i,
                               square.Center.PosY + j,
                               square.Symbol,
                               square.Color);
                }
            }
        }

        public static void PrintSquare(Square square, ConsoleColor color)
        {
            for (int i = 0; i <= square.SideA; i++)
            {
                for (int j = 0; j <= square.SideA; j++)
                {
                    PrintPoint(square.Center.PosX + i,
                               square.Center.PosY + j,
                               square.Symbol,
                               color);
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

        #region ---===   Draw_Ellipse   ===---

        public static void PrintEllipse(Ellipse ellipse)
        {
            PrintPoint(ellipse.Center.PosX, ellipse.Center.PosY, ellipse.Symbol, ellipse.Color);

            int x = 0;
            int y = ellipse.MinorAxis;

            int majorAxis = ellipse.MajorAxis;
            int delta = (1 - 2 * ellipse.MajorAxis);

            while (y >= 0)
            {
                PlotEllipse(ellipse, x, y, ellipse.Color);

                int error = 2 * (delta + y) - 1;
                if ((delta < 0) && (error <= 0))
                {
                    x += 1;
                    delta += (2 * x + 1);
                    continue;
                }

                error = 2 * (delta - x) - 1;
                if ((delta > 0) && (error > 0))
                {
                    y -= 1;
                    delta += (1 - 2 * y);
                    continue;
                }

                x += 1;
                delta += (2 * (x - y));
                y -= 1;
            }
        }

        private static void PlotEllipse(Ellipse ellipse, int x, int y, ConsoleColor color)
        {
            PrintPoint(ellipse.Center.PosX + x, ellipse.Center.PosY + y, ellipse.Symbol, color);
            PrintPoint(ellipse.Center.PosX + x, ellipse.Center.PosY - y, ellipse.Symbol, color);
            PrintPoint(ellipse.Center.PosX - x, ellipse.Center.PosY + y, ellipse.Symbol, color);
            PrintPoint(ellipse.Center.PosX - x, ellipse.Center.PosY - y, ellipse.Symbol, color);
        }

        #endregion // ToDo: переделать алгоритм для эллипса

        #region ---===   Draw_Circle   ===---

        public static void PrintCircle(Circle circle)
        {
            PrintPoint(circle.Center.PosX, circle.Center.PosY, circle.Symbol, circle.Color);

            int x = 0;
            int y = circle.Radius;
            int delta = (1 - 2 * circle.Radius);

            while (y >= 0)
            {
                PlotEllipse(circle, x, y, circle.Color);

                int error = 2 * (delta + y) - 1;
                if ((delta < 0) && (error <= 0))
                {
                    x += 1;
                    delta += (2 * x + 1);
                    continue;
                }

                error = 2 * (delta - x) - 1;
                if ((delta > 0) && (error > 0))
                {
                    y -= 1;
                    delta += (1 - 2 * y);
                    continue;
                }

                x += 1;
                delta += (2 * (x - y));
                y -= 1;
            }
        }

        public static void PrintCircle(Circle circle, ConsoleColor color)
        {
            PrintPoint(circle.Center.PosX, circle.Center.PosY, circle.Symbol, color);

            int x = 0;
            int y = circle.Radius;
            int delta = (1 - 2 * circle.Radius);

            while (y >= 0)
            {
                PlotEllipse(circle, x, y, color);

                int error = 2 * (delta + y) - 1;
                if ((delta < 0) && (error <= 0))
                {
                    x += 1;
                    delta += (2 * x + 1);
                    continue;
                }

                error = 2 * (delta - x) - 1;
                if ((delta > 0) && (error > 0))
                {
                    y -= 1;
                    delta += (1 - 2 * y);
                    continue;
                }

                x += 1;
                delta += (2 * (x - y));
                y -= 1;
            }

        }

        #endregion

        #region ---===   Draw Area / Perimetr   ===---

        public static void PrintAreaAndPerimetr(Container container, int index, int posX, int posY)
        {
            PrintPerimetr(posY, Container.GetPerimetrThisFigures(container, index));
            PrintArea(posY, Container.GetAreaThisFigures(container, index));
        }

        public static void PrintPerimetr(int posY, double perimetr)
        {
            Console.SetCursorPosition(0, posY - 3);
            ClearLine();
            Console.Write($"Perimetr = {perimetr}");
        }

        public static void PrintArea(int posY, double area)
        {
            Console.SetCursorPosition(0, posY - 2);
            ClearLine();
            Console.Write($"Area = {area}");
        }

        public static void ClearLine()
        {
            string str = "                                                                                                                       \r"; //пробелы для очистки строки

            Console.Write(str);
        }

        #endregion

    }
}
