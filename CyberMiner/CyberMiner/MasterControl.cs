
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

            List<URLDesc> URLList = new List<URLDesc>();

            // Read in lines from file.
            foreach (string line in linesFromFile)
            {
                string[] SplitURLs = line.Split('$');
                URLDesc urldesc = new URLDesc
                {
                    Description = SplitURLs[0],
                    URL = SplitURLs[1]
                };
                URLList.Add(urldesc);
            }



            //setchar test
            LineStorage LSTest = new LineStorage(URLList.ToArray());
           // LSTest.SetChar(2, 2, 3,'s');
            //Console.WriteLine(LSTest.FileLines[1]);
            //Console.ReadKey();
            //char test
           //char potato = LSTest.Char(2, 2, 3);
           //Console.WriteLine(potato);
            //Console.ReadKey();
            //word test
            //int lalala = LSTest.Word(2);
            //Console.WriteLine(lalala);


            //Circular Shift tests
            CircularShift CS = new CircularShift(LSTest);
            CS.Setup();

            //Console.WriteLine("---------CIRCULAR SHIFTS----------");
            foreach (var shift in CS.Shifts)
            {
                //Console.WriteLine(shift);
            }

            //Console.WriteLine();

            //Console.WriteLine("---------ALPHABETIZED SHIFTS----------");
            AlphabeticShift AS = new AlphabeticShift(CS);
            AS.Alpha();

            foreach (var shift in AS.AlphabetizedShifts)
            {
                //Console.WriteLine(shift);
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"INSERT URLS (URL, Description) VALUES ('{shift.URL}','{shift.Description}')";
                cmd.Connection = sqlConnection1;
                try
                {
                    //add to db
                    sqlConnection1.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection1.Close();
                } 
                catch
                {
                    //do not add to db if not unique per constraint
                }

                }


            //Console.ReadKey();

        }

    }
}