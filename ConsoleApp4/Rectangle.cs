using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Rectangle : Figure, IGeometrical
    {
        #region ---===    Private    ===---

        private int _sideA;
        private int _sideB;

        #endregion

        #region ---===    Get / Set    ===---

        public int SideA
        {
            get 
            { 
                return _sideA; 
            }
            set
            {
                if (value <= 0)
                {
                    throw new MyException($"SideA = {value}");
                }

                _sideA = value;
            }
        }

        public int SideB
        {
            get 
            { 
                return _sideB; 
            }
            set
            {
                if (value <= 0)
                {
                    throw new MyException($"SideB = {value}");
                }

                _sideB = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Rectangle(int sideA, int sideB, int x, int y)
            : base(x, y)
        {
            SideA = sideA;
            SideB = sideB;
        }

        #endregion

        #region ---===    Override Method    ===---

        public override void Show()
        {

            UI.PrintRectangle(this);
        }

        public override void Hide()
        {
            UI.PrintRectangle(this, Console.BackgroundColor);
        }

        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ---===    IGeometrical    ===---

        public double GetArea()
        {
            return (SideA * SideB);
        }

        public double GetPerimetr()
        {
            return (2 * (SideA + SideB));
        }

        #endregion
    }
}
