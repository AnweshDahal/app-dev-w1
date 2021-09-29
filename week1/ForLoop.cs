using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class ForLoop
    {
        public void FLoop(int range)
        {
            for (int i = 0; i <= range; i++)
            {
                Console.WriteLine(String.Format("The number is {0}", range));
            }
        }
    }
}
