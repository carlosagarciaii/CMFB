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
            Console.WriteLine(nl.Counter(cMax : int.MaxValue) );
        }
    }
}
