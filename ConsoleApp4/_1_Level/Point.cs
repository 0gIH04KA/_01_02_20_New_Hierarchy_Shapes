using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Point
    {
        #region ---===    Protected    ===---

        private int _positionX;
        private int _positionY;

        #endregion

        #region ---===    Get / Set    ===---

        public int PosX
        {
            get
            {
                return _positionX;
            }
            set
            {
                if (value < 0 || value > Constant.MAX_WIDTH)
                {
                    throw new MyException($"Incorrectly set X = {value}");
                }

                _positionX = value;
            }
        }

        public int PosY
        {
            get
            {
                return _positionY;
            }
            set
            {
                if (value < 0 || value > Constant.MAX_HEIGHT)
                {
                    throw new MyException($"Incorrectly set Y = {value}");
                }

                _positionY = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Point(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public Point(Point point)
            : this(point.PosX, point.PosY)
        {
        }

        #endregion

    }
}
