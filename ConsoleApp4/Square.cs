using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Square : Rectangle, IGeometrical
    {

        #region ---===    Constructor    ===---

        public Square(int sideA, int x, int y)
            : base(sideA, sideA, x, y)
        {
        }

        #endregion

        #region ---===    Override Method    ===---

        public override void Show()
        {
            base.Show();
        }

        public override void Hide()
        {
            base.Hide();
        }

        public override void Move(int x, int y)
        {
            base.Move(x, y);
        }

        #endregion

        #region ---===    IGeometrical    ===---

        new public double GetArea()
        {
            return (SideA * SideA);
        }

        new public double GetPerimetr()
        {
            return (4 * SideA );
        }

        #endregion

    }
}
