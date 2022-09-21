using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Intermediate_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter stop or start command");
                    String command = Console.ReadLine();
                    if (command.Equals("stop"))
                    {
                        sw.stop();
                    }
                    if (command.Equals("start"))
                    {
                        sw.start();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
