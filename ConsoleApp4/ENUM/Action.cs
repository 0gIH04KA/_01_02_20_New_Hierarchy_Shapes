﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    public enum Action
    {
        NoAction = 0x00,

        ResizeIncrease =  0x01,
        ResizeReduction = 0x02,

        Tabulation = 0x04,

        PressExit = 0xFFFF,
    }
}
