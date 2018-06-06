using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string[] lines = System.IO.File.ReadAllLines(@"myfile.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();

        }
    }
}
