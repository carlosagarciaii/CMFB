using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Globalization;

namespace FizzBuzz_CL
{
    public class NumberLister
    {
        private const int Min = 1;
        private const int Max = 100;
        private int CurrentNumber ;
        private List<string> counterOutput = new List<string>();
        //private Dictionary<string,string> counterOutput = new Dictionary<string, string>();

        private ColorSelector cs = new ColorSelector();


        /*
         * This expects the user to input a Min, Max, and MatchList
         * MatchList arguments must be in the format of numberletter
         * Example: 24Fizz 
         *          For every 24th, this will return Fizz
        */

        public string Counter(int cMin = Min, int cMax= Max, params string[] matchList)
        {


            CurrentNumber = 0;
            Regex numberMatch = new Regex(@"(?<=\b)(\d+)(?=\:\D+\b)");
            Regex stringMatch = new Regex(@"(?<=\b\d+\:)(\D+)(?<=\b)");
            int pulledInt; // = new int();
            string pulledString; // = new string();
            string add2List;

            if(cMax > int.MaxValue)
            {
                return "The Number Supplied is too large. \nPlease select a smaller number.";
            }
            else if (cMax == int.MaxValue)
            {
                Console.WriteLine("You have given the highest possible INTeger. \nAre you sure you want to continue? \n<Type Y or Yes to Continue>");
                string continuePrompt = Console.ReadLine();




                if (continuePrompt.ToLower() != "y" && continuePrompt.ToLower() != "yes")
                {
                    return "User has elected to stop.";
                }
            }

            do
            {

                CurrentNumber++;

                if (matchList.Length > 0)
                {
                    add2List = String.Empty;
                    foreach (string matchItem in matchList)
                    {
                        pulledInt = int.Parse(numberMatch.Match(matchItem).ToString());
                        pulledString = stringMatch.Match(matchItem).ToString();
                        if (CurrentNumber % pulledInt == 0)
                        {
                            if (add2List == string.Empty)
                            {
                                add2List = pulledString;
                            }
                            else
                            {
                                add2List += pulledString;
                            }
                        }
                    }
                    if (add2List != string.Empty)
                    {
                        counterOutput.Add(add2List);
                    }
                    else
                    {
                        counterOutput.Add(CurrentNumber.ToString());
                    }


                }
                else
                {
                    if (CurrentNumber % 3 == 0 && CurrentNumber % 5 == 0)
                    {
                        counterOutput.Add("Fizz - Buzz");
                    }

                    else if (CurrentNumber % 3 == 0)
                    {
                        counterOutput.Add("Fizz");
                    }
                    else if (CurrentNumber % 5 == 0)
                    {
                        counterOutput.Add( "Buzz");

                    }
                    else if (CurrentNumber == Min)
                    {
                        counterOutput.Add( cMin.ToString());
                    }
                    else
                    {
                        counterOutput.Add( CurrentNumber.ToString());
                    }
                }

            }
            while (CurrentNumber < cMax);


            string finalOutput;
            finalOutput = string.Empty;

            foreach (var item in counterOutput)
            {
                foreach (var pattern in matchList)
                {
                    
                }
                
                //finalOutput += item + "\n";
            }

            return finalOutput;
        }




    }
}
