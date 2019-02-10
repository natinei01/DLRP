using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int tex;
            int anwser;
            Console.Write("Input your PayMount:");
            int.TryParse(Console.ReadLine(), out result);
            Console.Write("Input your Tex peryear:");
            int.TryParse(Console.ReadLine(), out tex);
            anwser = result * tex / 100;
            Console.WriteLine($"your tex peryear={anwser}");                                   
            Console.ReadKey();
                
        }
    }
}
