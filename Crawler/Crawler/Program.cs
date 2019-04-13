using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.DirSearch(@"F:\");


            Console.WriteLine("Done");
            Console.Beep();

            Console.ReadKey();


        }
    }
}
