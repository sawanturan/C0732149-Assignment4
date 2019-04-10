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

        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) ! = null)
                    {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {Counter} lines.");
            }
        }
    }
}