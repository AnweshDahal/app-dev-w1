using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class IfElseStatement
    {
        public void IfStatement(int val)
        {
            if (val % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            } else if (val % 2 != 0)
            {
                Console.WriteLine("The number is Odd");
            } else
            {
                Console.WriteLine("The number could not be processed");
            }
        }
    }
}
