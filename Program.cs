using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("this is a while loop");

            while (i <=5) 
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("this is a do while loop");

            int j = 0;

            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j <=5);

            Console.ReadLine();
        }
    }
}
