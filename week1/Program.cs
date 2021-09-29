using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If Statement");
            IfElseStatement ieStatement = new IfElseStatement();
            ieStatement.IfStatement(5);
            Console.WriteLine();

            Console.WriteLine("Switch Statement");
            SwitchCase switchCase = new SwitchCase();
            switchCase.Switch(11);
            Console.WriteLine();

            Console.WriteLine("For Loop");
            ForLoop forLoop = new ForLoop();
            forLoop.FLoop(10);
            Console.WriteLine();

            Console.WriteLine("While Loop");
            WhileLoop whileLoop = new WhileLoop();
            whileLoop.Wloop(15);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
