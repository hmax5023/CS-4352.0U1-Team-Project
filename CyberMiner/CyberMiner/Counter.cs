using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMiner
{
    public class Counter
    {
        /*
       *counts the number of lines (separated by '$'), 
       * words (separated by ' '),
       * and characters
       */
        public void GetCount(string[] File)
        {

            //string Line;
            foreach (string AllLines in File)
            {
                //split by $
                string[] lines = AllLines.Split('$');
                LineStorage potato = new LineStorage(lines);
                int LineCount = 1;
                foreach (string Line in lines)
                {
                    //split by space
                    string[] words = Line.Split(' ');
                    int WordCount = 1;
                    foreach (string word in words)
                    {
                        WordCount++;
                        int CharCount = 1;
                        //count each char in a word
                        foreach (char character in word)
                        {
                            CharCount++;
                            potato.SetChar(LineCount, WordCount, CharCount, character);
                        }
                    }
                }
                LineCount++;
            }
        }
    }
}
