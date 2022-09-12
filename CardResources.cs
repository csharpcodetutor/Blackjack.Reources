using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Reources
{
    public enum CardSuite
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades,
    }

    public class Card
    {
        public CardSuite FaceName { get; set; }

        public int FaceValue { get; set; }

        public bool Hidden { get; set; }

        public override string ToString()
        {
            return $"{FaceValue}{DrawSuite()}";
        }

        private char DrawSuite()
        {
            char suite = ' ';
            switch (FaceName)
            {
                case CardSuite.Hearts:
                    suite = '♥';
                    break;
                case CardSuite.Clubs:
                    suite = '♣';
                    break;
                case CardSuite.Diamonds:
                    suite = '♦';
                    break;
                case CardSuite.Spades:
                    suite = '♠';
                    break;
            }

            return suite;
        }

        public void PrintCard()
        {
            string _printString = "";
            if (FaceValue == 1)
            {
                _printString =
                    " V         " +
                    "           " +
                    "           " +
                    "     S     " +
                    "           " +
                    "           " +
                    "         V ";

            }
            if (FaceValue == 2)
            {
                _printString =
                    " V         " +
                    "     S     " +
                    "           " +
                    "           " +
                    "           " +
                    "     S     " +
                    "         V ";

            }
            if (FaceValue == 3)
            {
                _printString =
                    " V         " +
                    "     S     " +
                    "           " +
                    "     S     " +
                    "           " +
                    "     S     " +
                    "         V ";

            }
            if (FaceValue == 4)
            {
                _printString =
                    " V         " +
                    "   S   S   " +
                    "           " +
                    "           " +
                    "           " +
                    "   S   S   " +
                    "         V ";

            }
            if (FaceValue == 5)
            {
                _printString =
                    " V         " +
                    "   S   S   " +
                    "           " +
                    "     S     " +
                    "           " +
                    "   S   S   " +
                    "         V ";

            }
            if (FaceValue == 6)
            {
                _printString =
                    " V         " +
                    "   S   S   " +
                    "           " +
                    "   S   S   " +
                    "           " +
                    "   S   S   " +
                    "         V ";

            }
            if (FaceValue == 7)
            {
                _printString =
                    " V         " +
                    "   S   S   " +
                    "     S     " +
                    "   S   S   " +
                    "           " +
                    "   S   S   " +
                    "         V ";

            }
            if (FaceValue == 8)
            {
                _printString =
                    " V         " +
                    "   S   S   " +
                    "     S     " +
                    "   S   S   " +
                    "     S     " +
                    "   S   S   " +
                    "         V ";

            }
            if (FaceValue == 9)
            {
                _printString =
                    " V         " +
                    "   S S S   " +
                    "           " +
                    "   S S S   " +
                    "           " +
                    "   S S S   " +
                    "         V ";

            }
            if (FaceValue == 10 || FaceValue == 11 || FaceValue == 12 || FaceValue == 13)
            {
                _printString =
                    " V         " +
                    "    S S    " +
                    "     S     " +
                    "  S S S S  " +
                    "     S     " +
                    "    S S    " +
                    "         V ";

            }
            if (Hidden)
            {
                _printString =
                    " C#        " +
                    "           " +
                    "           " +
                    "  CASINO   " +
                    "           " +
                    "           " +
                    "        C# ";

            }

            PrintMethod(_printString);
        }

        private void PrintMethod(string _printString)
        {
            bool hasWrittenFirstNumber = false;

            switch (FaceName)
            {
                case CardSuite.Hearts:
                case CardSuite.Diamonds:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case CardSuite.Clubs:
                case CardSuite.Spades:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            for (int i = 0; i < _printString.Length; i++)
            {
                if (Hidden)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.BackgroundColor = ConsoleColor.White;

                if (i % 11 == 0 && i != 0)
                {
                    Console.CursorLeft -= 11;
                    Console.CursorTop += 1;
                }
                if (_printString[i] == 'S' && !Hidden)
                {
                    switch (FaceName)
                    {
                        case CardSuite.Hearts:
                            Console.Write('♥');
                            break;
                        case CardSuite.Clubs:
                            Console.Write('♣');
                            break;
                        case CardSuite.Diamonds:
                            Console.Write('♦');
                            break;
                        case CardSuite.Spades:
                            Console.Write('♠');
                            break;
                    }
                    continue;
                }
                else if (_printString[i] == 'V')
                {
                    if (FaceValue == 10)
                    {
                        if (hasWrittenFirstNumber == false)
                        {
                            Console.Write(10);
                            hasWrittenFirstNumber = true;
                            i++;
                        }
                        else
                        {
                            Console.CursorLeft--;
                            Console.Write(10);
                        }
                        continue;
                    }
                    else if (FaceValue == 11)
                    {
                        Console.Write("J");
                    }
                    else if (FaceValue == 12)
                    {
                        Console.Write("Q");
                    }
                    else if (FaceValue == 13)
                    {
                        Console.Write("K");
                    }
                    else if (FaceValue == 1)
                    {
                        Console.Write("A");
                    }
                    else
                    {
                        Console.Write(FaceValue);
                    }
                }
                else
                {
                    Console.Write(_printString[i]);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
