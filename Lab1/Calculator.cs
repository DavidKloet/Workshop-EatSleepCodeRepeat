using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Calculator
    {
        public int Multiply(int valueLeft, int valueRight)
        {
            if (valueRight == 0 || valueRight == 0) throw new ArgumentOutOfRangeException("left or right is 0");

            return valueLeft * valueRight;
        }
    }
}
