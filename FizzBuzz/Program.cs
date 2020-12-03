using System;
using FizzBuzz_CL;

namespace FizzBuzz
{
    class Program
    {

        
        static void Main(string[] args)
        {
            NumberLister nl = new NumberLister();

            Console.WriteLine("Hello World!");

            Console.WriteLine(nl.Counter(1,200,"5Pop","25Snaggle","50Derp"));
        }
    }
}
