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
        //constructor
        public LineStorage LineStorage { get; set; }
        public CircularShift(LineStorage LS)
        {
            LineStorage = LS;
        }

        public string[] FileLines { get; set; }

        public void Setup()
        {
            char cr = LineStorage.getChar();
            int wd = LineStorage.getWord();
        }
        //causes the character in a word of the shift to be NextChar
        private void SetChar(int Shift, int Word, int Character, char NextChar)
        {
            //count -1 as count starts at 1 and array starts at 0 index
            string line = FileLines[Shift];
            //split by space
            string[] words = line.Split(' ');
            //wordcount-1 to start at 0 index
            string word = words[Word - 1];
            char character = word[Character - 1];
            StringBuilder wordBuilder = new StringBuilder(word);
            wordBuilder[Character - 1] = NextChar;
            //convert to a string
            word = wordBuilder.ToString();
            words[Word - 1] = word;
            string newLine = String.Join(" ", words);
            FileLines[Shift] = newLine;
        }

        public string Char(int Shift, int Word, string NextChar)
        {
            string line = FileLines[Shift];
            string[] words = line.Split(' ');
            //wordcount-1 to start at 0 index
            string word = words[Word - 1];
            NextChar = words[Shift];
            return NextChar; //placeholder
        }

        //returns number of words in shift
        public int Word(int Shift)
        {
            return Shift; //placeholder
        }
    }
}
