using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace C0732149_Assignment4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadLine();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/732149/beowulf.txt"))
            {
                int counter = 0;
                int number = 0;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Fare") == true && line.Contains("War") == false || line.Contains("Fare") == true && line.Contains("War") == false)
                    {
                        int x = counter - 1;
                        number++;
                    }
                    counter++;
                }
                Console.WriteLine($"The number of lines that contains *Fare* without the word *War* in the Beowulf file is: {number}");
                file.Close();
                counter = File.ReadLines("").Count();
                Console.WriteLine("Number of Lines in the Beowulf File Are " + counter);
                
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
             foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if(char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}