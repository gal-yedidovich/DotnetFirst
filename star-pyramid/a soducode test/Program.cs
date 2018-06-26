using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_soducode_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input hight");
            int hight = Int32.Parse(Console.ReadLine());
            for (int i=1; i <= hight; i++)
            {
                Console.Write("*");
                for (int line=1; line < i; line++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
