using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    abstract class Figure
    {
        #region ---===    Protected    ===---

        protected Point _center;
        protected char _symbol;
        protected ConsoleColor _color;

        #endregion

        #region ---===    Get / Set    ===---

        public char Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public Point Center
        {
            get
            {
                return _center;
            }
            set
            {
                if (value.PosX < 0 || value.PosX > Constant.MAX_WIDTH
                && value.PosY < 0 || value.PosY > Constant.MAX_HEIGHT)
                {
                    throw new MyException($"Incorrectly set Centr = {value.PosX},{value.PosY}");
                }

                _center = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Figure(int x, int y, 
            char sym = '*', ConsoleColor color = ConsoleColor.White)
        {
            _center = new Point(x, y);
            _symbol = sym;
            _color = color;
        }

        #endregion

        #region ---===    Metods    ===---

        public abstract void Move(int x, int y);

        public abstract void Show();

        public abstract void Hide();

        #endregion

    }
}
