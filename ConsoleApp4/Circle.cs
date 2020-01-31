using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Circle : Figure
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
            : base(x, y)
        {
            Radius = radius;
        }

        #endregion

        #region ---===    Override Method    ===---

        public override void Hide()
        {
            throw new NotImplementedException();
        }

        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ---===    IGeometrical    ===---

        #endregion

       

    }
}
