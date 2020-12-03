using System;
using FizzBuzz_CL;
using System.Threading; 

namespace FizzBuzz
{
    class Program
    {

        
        static void Main(string[] args)
        {
            NumberLister nl = new NumberLister();
            ColorSelector cs = new ColorSelector();
            HelpOption ho = new HelpOption();

            cs.Set();

            Console.WriteLine(ho.HelpText());


            Console.WriteLine("Welcome to FizzBuzz");
            
            /*
            //Sleep to allow user to read Header and Options
            Thread.Sleep(5000);

            // Legacy, in-line test #CodeCleanUp
            //Console.WriteLine(nl.Counter(1,200,"5Pop","25Snaggle","50Derp"));
            */





        }
    }
}
