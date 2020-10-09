using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubSetUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setup process");
            Console.WriteLine("STEP 1:");
            Console.WriteLine("VS menu[Tools] -> Options -> Source Control ->" +
                " (select Git)");
            Console.WriteLine("STEP 2:");
            Console.WriteLine("right-click solution[Add Solution Control]" +
                " -> Change tab to Team Explorer -> SYNC");

            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
