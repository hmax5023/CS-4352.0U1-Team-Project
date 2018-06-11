using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineStorage
{
    class Program
    {
        private static int count;
        private static object delimiterChars;

        public string SetChar { get; }
        public string Char { get; }
        public string Word { get => Word; set => Word = value; }


        

        static void Main(string[] args)
        {
            
        
        //splitting the word in single characters
        //reference: docs.microsoft.com
        SetChar(){

                string[] lines = System.IO.File.ReadAllLines(@"myfile.txt");
                string[] words = lines.Split('');
                foreach (var word in words)
                {
                    System.Console.WriteLine($"<{word}>");
                }

                //I am sure I am missing letters!!
                string[] letters = word.Split('a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u,', 'w', 'z');
                string[] letters = TaskExtensions.Slpit(delimiterChars);
                foreach (var letter in word )
                {
                    System.Console.WriteLine($"<{letter}>");
                }


            }
            //splitting the word in sigle letters and displaying the position of each letter in the word
            Char(){
                string[] lines = System.IO.File.ReadAllLines(@"myfile.txt");
                string[] words = lines.Split('');
                foreach (var word in words)
                {
                    System.Console.WriteLine($"<{word}>");
                    count++;
                    //display # wornd on the sentence
                    Console.WriteLine("Le word is in position n:", count++);
                }

                //I am sure I am missing letters!!
                string[] letters = word.Split('a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u,', 'w', 'z');
                string[] letters = TaskExtensions.Slpit(delimiterChars);
                foreach (var letter in word)
                {
                    System.Console.WriteLine($"<{letter}>");
                    count++;
                    //display # letter on the word
                    Console.WriteLine("The letters on position:", count++);
                }
                
            }


            //spliting each line/sentence in single words, counting the words and displaying the count
            // reference: docs.microsoft.com
            Word(){
                string[] lines = System.IO.File.ReadAllLines(@"myfile.txt");
                string[] words = lines.Split('');
                foreach (var word in words)
                {
                    System.Console.WriteLine($"<{word}>");
                    count++;
                }
                Console.WriteLine("The sentece has n words:", count++);
            }
        }
    }
}


