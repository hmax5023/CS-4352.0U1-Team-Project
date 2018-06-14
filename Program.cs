using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMiner
{
    public class AlphabeticShift
    {
        //constructor
        public LineStorage {get; set;}
        public AlphabeticShift(LineStorage LS)
        {
            LineStorage = LS;
        }

    //alphabetizer class
    public void Alpha(char character, int word, int shift, char nextChar)
    {
        string line = FileLines[lineCount - 1];
        string[] words = line.Split('');
        string word = words[wordCount - 1];
        char character = word[characterCount - 1];

        StringBuilder wordAppend = new StringBuilder();
        StringBuilder oldLine = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            if (toAppend)
            {
                string toAdd = line[i];
                if (i == firstIndex)
                {
                    toAppend = false;
                    oldLine.Append(UpperCaseFirstChar(toAdd)).Append("");
                } else
                {
                    wordAppend.Append(toAdd).Append("");
                }
            } else
            {
                oldLine.Append(line[i]).Append("");
            }
        }
        
        //adding the words in a sorted list
        oldLine.Append(wordAppend.ToString());
        SortedList.Add(oldLine.ToString().Trim());

        //return the sorted list
        System.Collections.sort(SortedList);
    }

   

    //checking if the first word starts with a capitol letter
    private string UpperCaseFirstChar(string line)
    {
        if (line == null)
        {
            throw new ArgumentNullException(nameof(line));
        }

        if (line.Length <= 1)
        {
            return line;
            //return string line.ToUpperCase();
        }
        return oldLine.ToUpperCase(line);
        //return oldLine.ToUpperCase(line.ToCharArray(0)) + line.Substring(1);
    }




        public int CSIndex(int bla)
        {
            return blah;
        }

    class oldLine
    {
        internal static string ToUpperCase(char[] v)
        {
            throw new NotImplementedException();
        }

        internal static string ToUpperCase(string line)
        {
            throw new NotImplementedException();
        }
    }
}
}
