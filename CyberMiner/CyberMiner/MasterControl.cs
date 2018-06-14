
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
            LineStorage LSTest = new LineStorage(Splitbydollar);
           // LSTest.SetChar(2, 2, 3,'s');
            //Console.WriteLine(LSTest.FileLines[1]);
            //Console.ReadKey();
            //char test
           // char potato = LSTest.Char(2, 2, 3);
           // Console.WriteLine(potato);
            //Console.ReadKey();
            //word test
            //int lalala = LSTest.Word(2);
            //Console.WriteLine(lalala);


            //Circular Shift tests
            CircularShift CS = new CircularShift(LSTest);
            CS.Setup();

            Console.WriteLine("---------CIRCULAR SHIFTS----------");
            foreach (var shift in CS.Shifts)
            {
                Console.WriteLine(shift);
            }

            Console.WriteLine();

            Console.WriteLine("---------ALPHABETIZED SHIFTS----------");
            AlphabeticShift AS = new AlphabeticShift(CS);
            AS.Alpha();

            foreach (var shift in AS.AlphabetizedShifts)
            {
                Console.WriteLine(shift);
            }


            Console.ReadKey();

        }

    }
}