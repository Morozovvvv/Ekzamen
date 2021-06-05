using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public int sum = 0;
        public int Sum
        {
            set
            {
                sum += value;
            }
            get
            {
                return sum;
            }
        }
    }
}
