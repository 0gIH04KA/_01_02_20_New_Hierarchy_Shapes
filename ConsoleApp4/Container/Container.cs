using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Container
    {
        #region ---===    Private    ===---

        private Figure[] _figures;
        private int _itemsCount;
        private int _currentItemIndex;

        #endregion

        #region ---===    Get / Set    ===---

        public int ItemsCount
        {
            get
            {
                return _itemsCount;
            }
        }

        public Figure this[int index]
        {
            get
            {
                return _figures[index];
            }
        }

        public Figure[] Figures
        {
            get
            {
                return _figures;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Container()
        {
            _figures = new Figure[Constant.MAXIMUM_FIGURES];
            _itemsCount = 0;
            _currentItemIndex = 0;
        }

        #endregion

        #region ---===    Metods    ===---

        public void AddFigure(Figure figure)
        {
            _figures[_itemsCount] = figure;
            ++_itemsCount;
        }

        public void DeleteFigure(int position)
        {
            if (position < 0 || position > _itemsCount)
            {
                throw new MyException("Position not correctly");
            }

            _figures[position].Hide();
            _figures[position] = null;
            --_itemsCount;
        }

        public void DeleteLastFigire()
        {
            --_itemsCount;
            _figures[_itemsCount].Hide();

            _figures[_itemsCount] = null;
        }

        public void Show()
        {
            for (int i = 0; i < _itemsCount; i++)
            {
                _figures[i].Show();
            }
        }

        #endregion

        #region ---===    IGeometrical    ===---

        public static double GetAreaThisFigures(Container container, int index)
        {
            double area;
            IGeometrical geometrical = container.Figures[index] as IGeometrical;

            if (geometrical == null)
            {
                return 0.0;
            }
            else
            {
                area = geometrical.GetArea();
            }

            return area;
        }

        public static double GetPerimetrThisFigures(Container container, int index)
        {
            double perimetr;
            IGeometrical geometrical = container.Figures[index] as IGeometrical;

            if (geometrical == null)
            {
                return 0.0;
            }
            else
            {
                perimetr = geometrical.GetPerimetr();
            }

            return perimetr;
        }

        #endregion

        #region ---===    New Figure    ===---

            #region ---===    Rectangle    ===---

                public static Rectangle NewRectangle(Point point, int sideA, int sideB)
                {
                    return new Rectangle(sideA, sideB, point.PosX, point.PosY);
                }

                public static Rectangle NewRectangle(int x, int y, int sideA, int sideB)
                {
                    return new Rectangle(sideA, sideB, x, y);
                }

        #endregion

            #region ---===    Square    ===---

                public static Square NewSquare(Point point, int sideA)
                {
                    return new Square(sideA, point.PosX, point.PosY);
                }

                public static Square NewSquare(int x, int y, int sideA)
                {
                    return new Square(sideA, x, y);
                }

            #endregion

            #region ---===    Triangle    ===--- 

                public static Triangle NewTriangle(Point point, int sideA)
                {
                    throw new MyException("Дописать)"); 
                }

                public static Triangle NewTriangle(int x, int y, int sideA)
                {
                    throw new MyException("Дописать)"); 
                }

            #endregion

            #region ---===    Ellipse    ===---

                public static Ellipse NewEllipse(Point point, int minorAxis, int majorAxis)
                {
                    return new Ellipse(minorAxis, majorAxis, point.PosX, point.PosY);
                }

                public static Ellipse NewEllipse(int x, int y, int minorAxis, int majorAxis)
                {
                    return new Ellipse(minorAxis, majorAxis, x, y);
                }

            #endregion

            #region ---===    Circle    ===---

                public static Circle NewCircle(Point point, int radius)
                {
                    return new Circle(radius, point.PosX, point.PosY);
                }

                public static Circle NewCircle(int x, int y, int radius)
                {
                    return new Circle(radius, x, y);
                }

            #endregion

        #endregion

    }
}
