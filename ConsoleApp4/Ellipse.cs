using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Ellipse : Figure, IGeometrical
    {
        #region ---===    Private    ===---

        private int _minorAxis;
        private int _majorAxis;

        #endregion

        #region ---===    Get / Set    ===---

        public int MinorAxis
        {
            get 
            { 
                return _minorAxis;
            }
            set 
            {
                if (value <= 0)
                {
                    throw new MyException($"MinorAxis = {value}");
                }

                _minorAxis = value; 
            }
        }

        public int MajorAxis
        {
            get 
            { 
                return _majorAxis;
            }
            set 
            {
                if (value <= 0)
                {
                    throw new MyException($"MajorAxis = {value}");
                }

                _majorAxis = value; 
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Ellipse(int minorAxis, int majorAxis, int x, int y)
           : base(x, y)
        {
            _minorAxis = minorAxis;
            _majorAxis = majorAxis;
        }

        public Ellipse(Ellipse ellipse)
            : this(ellipse._minorAxis, ellipse._majorAxis, 
                  ellipse._center.PosX, ellipse._center.PosY)
        { 
        }

        #endregion

        #region ---===    Override Method    ===---

        public override void Hide()
        {
            throw new NotImplementedException();
        }

        

        public override void Show()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ---===    IGeometrical    ===---

        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public double GetPerimetr()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
