using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static int sumtotal(int x,int y)
        {
          int  sumtotal = x + y;
            return sumtotal;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(sumtotal(7, 8));
        }
    }
}
