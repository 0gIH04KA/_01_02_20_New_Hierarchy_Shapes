using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    [Flags]
    public enum Direction
    {
        NoAction = 0x00,

        Right = 0x01,
        Left = 0x02,
        Up = 0x04,
        Down = 0x08,

        MoveAction = Right | Left | Up | Down,
    }
}
