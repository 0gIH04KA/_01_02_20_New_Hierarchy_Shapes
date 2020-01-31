using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_20_New_Hierarchy_Shapes
{
    [Serializable()]
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
