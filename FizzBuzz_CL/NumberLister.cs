using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_CL
{
    public class NumberLister
    {
        private const int Min = 1;
        private const int Max = 100;
        private int CurrentNumber ;
        private string counterOutput;

        public string Counter(int cMin = Min, int cMax= Max)
        {
            CurrentNumber = 0;
            counterOutput = "";

            

            do
            {
                counterOutput += "\n";
                CurrentNumber++;
                if (CurrentNumber %3 == 0 && CurrentNumber %5 == 0)
                {
                    counterOutput += "Fizz - Buzz";
                }
                
                else if(CurrentNumber % 3 == 0){
                    counterOutput += "Fizz";                    
                    }
                else if (CurrentNumber %5 == 0)
                {
                    counterOutput += "Buzz";

                }
                else if(CurrentNumber == Min)
                {
                    counterOutput += Min.ToString();
                }
                else
                {
                    counterOutput += CurrentNumber.ToString();
                }


            }
            while( CurrentNumber < cMax);
            
            return counterOutput;
        }




    }
}
