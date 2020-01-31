using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    [Flags]
    public enum Action
    {
        NoAction = 0x00,

        PressRight = 0x01,
        PressLeft = 0x02,
        PressUp = 0x04,
        PressDown = 0x08,

        Tabulation = 0x00FF,

        PressExit = 0xFFFF,

        MoveAction = PressRight | PressLeft | PressUp | PressDown,
    }
}
