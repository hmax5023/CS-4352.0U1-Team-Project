﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMiner
{
    //creates, accesses, and deletes characters, words, and lines (as needed)
    public class LineStorage
    {
        //constructor
        public LineStorage(URLDesc[] lines)
        {
            FileLines = lines;
        }

        //accessors
        public URLDesc[] FileLines { get; set; }
        //takes in the character number, the word number, and the line number 
        //and determines the character there
        //used to store all lines with no ambiguity
        public void SetChar(int lineCount, int wordCount, int characterCount, char value)
        {
            //count -1 as count starts at 1 and array starts at 0 index
            URLDesc urldesc = FileLines[lineCount - 1];
            string line = urldesc.Description;
            //split by space
            string[] words = line.Split(' ');
            //wordcount-1 to start at 0 index
            string word = words[wordCount - 1];
            char character = word[characterCount - 1];
            StringBuilder wordBuilder = new StringBuilder(word);
            wordBuilder[characterCount - 1] = value;
            //convert to a string
            word = wordBuilder.ToString();
            words[wordCount - 1] = word;
            string newLine = String.Join(" ", words);
            FileLines[lineCount - 1] = new URLDesc() { Description = newLine, URL = urldesc.URL };
        }
        //returns a character in a word and line
        public char Char(int lineCount, int wordCount, int characterCount)
        {
            string line = FileLines[lineCount - 1].Description;
            string[] words = line.Split(' ');
            //wordcount-1 to start at 0 index
            string word = words[wordCount - 1];
            char character = word[characterCount];
            return character;
        }
        //returns the number of words in a line
        public int Word(int lineNumber)
        {
            string line = FileLines[lineNumber - 1].Description;
            //split by space
            string[] words = line.Split(' ');
            int wordCount = words.Length;
            return wordCount;
        }
    }
}
