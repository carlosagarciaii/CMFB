using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_CL
{
    public class HelpOption
    {
        private string HelpMessage;

        public string HelpText()
        {
            HelpMessage = "Welcome to FizzBuzz\n" +
                "\n" +
                "Basic Use:\n\n" +
                "FizzBuzz.exe {parameters}\n\n" +
                "Parameters:\n" +
                "   /#:{word}   Specifies the number you want replaced with the word.\n" +
                "      (IE:   /12:Stick will replace every multiple of 12 with 'Stick'.\n" +
                "      Default is 3:Fizz and 5:Buzz\n" +
                "\n" +
                "   /min:#   Specifies the lowest number to match.\n" +
                "      (IE:   /min:12 will start matching at 12\n" +
                "      Default is 1\n" +
                "\n" +
                "   /max:#   Specifies the highest number to match.\n" +
                "      (IE:   /max:200 will stop matching at 200\n" +
                "      Default is 1\n" +
                "\n" +
                "   /bg:{color}   Sets the Background Color for every matched number\n" +
                "   /fg:{color}   Sets the Foreground Color for every matched number\n" +
                "      (IE:   /fg:green will return Green Text)\n" +
                "      Default is /fg:white and /bg:black\n" +
                "      Colors Accepted:\n" +
                "         red\n" +
                "         green\n" +
                "         blue\n" +
                "         yellow\n" +
                "         white\n" +
                "         black\n" +
                "         gray or grey\n" +
                "\n" +
                "   /?   The Help Message will be displayed";



            return HelpMessage;
        }
    }
}
