
//using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMiner
{

    class MasterControl
    {
        static void Main(string[] args)
        {

            //openfile
            string[] linesFromFile = System.IO.File.ReadAllLines(@"myfile.txt");
            //sets the array of lines to one string
            string fileString = string.Join("", linesFromFile);
            string[] Splitbydollar = fileString.Split('$');

            //setchar test
            LineStorage setchartest = new LineStorage(Splitbydollar);
            setchartest.SetChar(2, 2, 3,'s');
            Console.WriteLine(setchartest.FileLines[1]);
            Console.ReadKey();



        }

        
    }
}