using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;


            if(a > b)
            {
                Console.WriteLine("É verdade");
            }else if (a == a)
            {
                Console.WriteLine("Executou ElseIf");
            }
            else
            {
                Console.WriteLine("É mentira");
            }


                Console.ReadLine();
            
        }
    }
}
