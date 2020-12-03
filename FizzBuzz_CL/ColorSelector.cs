using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_CL
{
    public class ColorSelector
    {

        private ConsoleColor bgColor;
        private ConsoleColor fgColor;


        public void Set( string fg = " ", string bg = " ")
        {
            switch (bg.ToLower())
            {
                case ("white"):
                    
                    bgColor = ConsoleColor.White;
                    break;
                case ("green"):
                    bgColor = ConsoleColor.Green;
                    break;
                case ("red"):
                    bgColor = ConsoleColor.Red;
                    break;
                case ("blue"):
                    bgColor = ConsoleColor.Blue;
                    break;
                case ("yellow"):
                    bgColor = ConsoleColor.Yellow;
                    break;
                case ("gray"):
                    bgColor = ConsoleColor.Gray;
                    break;
                case ("grey"):
                    bgColor = ConsoleColor.Gray;
                    break;

                default:
                    bgColor = ConsoleColor.Black;
                    break;
            }


            switch (fg.ToLower())
            {
                case ("black"):
                    fgColor = ConsoleColor.Black;
                    break;
                case ("green"):
                    fgColor = ConsoleColor.Green;
                    break;
                case ("red"):
                    fgColor = ConsoleColor.Red;
                    break;
                case ("blue"):
                    fgColor = ConsoleColor.Blue;
                    break;
                case ("yellow"):
                    fgColor = ConsoleColor.Yellow;
                    break;
                case ("gray"):
                    fgColor = ConsoleColor.Gray;
                    break;
                case ("grey"):
                    fgColor = ConsoleColor.Gray;
                    break;

                default:
                    fgColor = ConsoleColor.White;
                    break;
            }

            if (bg == fg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.BackgroundColor = bgColor;
                Console.ForegroundColor = fgColor;

            }
        }
    }
}
