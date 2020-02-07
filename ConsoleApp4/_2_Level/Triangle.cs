using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    class Triangle : Figure
    {
        #region ---===    Private    ===---

        private int _sideA;
        private int _sideB;
        private int _sideC;

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

        public int SideC
        {
            get 
            { 
                return _sideC;
            }
            set
            {
                if (value <= 0)
                {
                    throw new MyException($"SideC = {value}");
                }

                _sideC = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Triangle(int sideA, int sideB, int sideC, int x, int y)
            : base(x, y)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
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

        #endregion
        

        
    }
}
