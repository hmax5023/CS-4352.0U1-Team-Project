using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMiner
{
    //creates virtual lines of the circular shifts of stored lines
    //provides routines to access individual characters and words of shifted lines
    public class CircularShift
    {

        public List<URLDesc> Shifts = new List<URLDesc>();
        //constructor
        LineStorage LineStorage;
        public CircularShift(LineStorage LS)
        {
            LineStorage = LS;
        }

        public void Setup()
        {
            foreach (var line in LineStorage.FileLines)
            {
                string [] words = line.Description.Split(' ');
                int wordcount = words.Length;
                string templine = "";
                List<URLDesc> shifts = new List<URLDesc>();
                List<string> Listofwords = line.Description.Split(' ').ToList();
                string firstword = "";

                shifts.Add(new URLDesc()
                {
                    Description = String.Join(" ", words),
                    URL = line.URL
                }
                );
                while (shifts.Count != wordcount)
                {
                    firstword = Listofwords[0];
                    Listofwords.RemoveAt(0);
                    Listofwords.Add(firstword);
                    shifts.Add(new URLDesc()
                    {
                        Description = String.Join(" ", Listofwords),
                        URL = line.URL
                    });
                }



                Shifts.AddRange(shifts);
            }

 
        }

        //causes a character in a word of a shift to be character
        private void SetChar(int shiftCount, int wordCount, int characterCount, char character)
        {

        }
        //returns a character in a word in a shift
        public string Char(int Shift, int Word, string NextChar)
        {
            return NextChar; //placeholder
        }

        //returns number of words in shift
        public int Word(int Shift)
        {
            return Shift; //placeholder
        }
    }
}
//    for (int i = 0; i < wordcount; i++)
//    {
//        templine += words[i];

//    }
//    firstword = words[0];
//    shifts.Add(templine);