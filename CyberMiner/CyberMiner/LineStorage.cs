using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMiner
{
    //creates, accesses, and deletes characters, words, and lines (as needed)
    public class LineStorage
    {
        public LineStorage(string[] lines)
        {
            FileLines = lines;
        }

        string[] FileLines { get; set; }
        //takes in the character number, the word number, and the line number 
        //and determines the character there
        public void SetChar(int lineCount, int wordCount, int characterCount, char value)
        {
            string line = FileLines[lineCount-1];
            string[] words = line.Split(' ');
            string word = words[wordCount - 1];
            char character = word[characterCount - 1];

            StringBuilder wordBuilder = new StringBuilder(word);
            wordBuilder[characterCount] = value;
            word = wordBuilder.ToString();
            words[wordCount - 1] = word;
            string newLine = String.Join(" ", words);
            FileLines[lineCount - 1] = newLine;

        }
        public int Char(int word, int line, int character)
        {
            //returns an int representing a character in a word of a line
            //returns blank if out of range
            return character; //placeholder
        }
        public int Word(int line)
        {
            //returns number of words in a line
            return line; //placeholder
        }
    }
}
