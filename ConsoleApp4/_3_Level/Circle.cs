using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Circle : Ellipse, IGeometrical
    {
        #region ---===    Private    ===---

        private int _radius;

        #endregion

        #region ---===    Get / Set    ===---

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new MyException($"Radius = {value}");
                }

                _radius = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Circle(int radius, int x, int y)
            : base(radius, radius, x, y)
        {
            _radius = radius;
        }

        public Circle(Circle circle)
            : this(circle._radius, 
                  circle._center.PosX, circle._center.PosY)
        { 
        }

        #endregion

        #region ---===    Override Method    ===---

        public override void Hide()
        {
            UI.PrintCircle(this, Console.BackgroundColor);
        }

        public override void Show()
        {
            UI.PrintCircle(this);
        }

        #endregion

        #region ---===    IGeometrical    ===---
        new public double GetArea()
        {
            return (Math.PI * Math.Pow(_radius, 2));
        }

        new public double GetPerimetr()
        {
            return (2.0 * Math.PI * _radius);
        }
        #endregion

    }
}
