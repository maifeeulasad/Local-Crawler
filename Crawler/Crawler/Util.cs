using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class Util
    {

        public static void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    try
                    {
                        foreach (string f in Directory.GetFiles(d))
                        {
                            Console.WriteLine(f);
                            File.AppendAllText(@"D:\crawl-F.txt", f + Environment.NewLine);
                        }
                        DirSearch(d);
                    }
                    catch(Exception ee)
                    {
                        Console.WriteLine(ee.Message);
                    }
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

    }
}
