using System;
using System.Collections.Generic;
using System.Threading;

namespace MorseCode
{
    public class Morse
    {
        private const int frequency = 800;
        private const int dotDuration = 200;
        private const int dashDuration = 600;
        private const int wait = 200;
        private const int stop = 500;
        static public readonly IReadOnlyDictionary<char, string> CharsToMorse = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."}
        };
        static public readonly IReadOnlyDictionary<string, char> CharsToEng = new Dictionary<string, char>()
        {
            {".-", 'a'},
            {"-...", 'b'},
            {"-.-.", 'c'},
            {"-..", 'd'},
            {".", 'e'},
            {"..-.", 'f'},
            {"--.", 'g'},
            {"....", 'h'},
            {"..", 'i'},
            {".---", 'j'},
            {"-.-", 'k'},
            {".-..", 'l'},
            {"--", 'm'},
            {"-.", 'n'},
            {"---", 'o'},
            {".--.", 'p'},
            {"--.-", 'q'},
            {".-.", 'r'},
            {"...", 's'},
            {"-", 't'},
            {"..-", 'u'},
            {"...-", 'v'},
            {".--", 'w'},
            {"-..-", 'x'},
            {"-.--", 'y'},
            {"--..", 'z'},
            {"-----", '0'},
            {".----", '1'},
            {"..---", '2'},
            {"...--", '3'},
            {"....-", '4'},
            {".....", '5'},
            {"-....", '6'},
            {"--...", '7'},
            {"---..", '8'},
            {"----.", '9'}
        };
        public static void Play(string message)
        {
            foreach (char c in message)
            {
                if (c == ' ')
                {
                    Console.Write("\n");
                }
                else if (c == 'a')
                {
                    Dot();
                    DashStop();
                    Console.WriteLine("    <'a'>");
                }
                else if (c == 'b')
                {
                    Dash();
                    Dot();
                    Dot();
                    DotStop();
                    Console.WriteLine("  <'b'>");
                }
                else if (c == 'c')
                {
                    Dash();
                    Dot();
                    Dash();
                    DotStop();
                    Console.WriteLine("  <'c'>");
                }
                else if (c == 'd')
                {
                    Dash();
                    Dot();
                    DotStop();
                    Console.WriteLine("   <'d'>");
                }
                else if (c == 'e')
                {
                    DotStop();
                    Console.WriteLine("     <'e'>");
                }
                else if (c == 'f')
                {
                    Dot();
                    Dot();
                    Dash();
                    DotStop();
                    Console.WriteLine("  <'f'>");
                }
                else if (c == 'g')
                {
                    Dash();
                    Dash();
                    DotStop();
                    Console.WriteLine("   <'g'>");
                }
                else if (c == 'h')
                {
                    Dot();
                    Dot();
                    Dot();
                    DotStop();
                    Console.WriteLine("  <'h'>");
                }
                else if (c == 'i')
                {
                    Dot();
                    DotStop();
                    Console.WriteLine("    <'i'>");
                }
                else if (c == 'j')
                {
                    Dot();
                    Dash();
                    Dash();
                    DashStop();
                    Console.WriteLine("  <'j'>");
                }
                else if (c == 'k')
                {
                    Dash();
                    Dot();
                    DashStop();
                    Console.WriteLine("   <'k'>");

                }
                else if (c == 'l')
                {
                    Dot();
                    Dash();
                    Dot();
                    DotStop();
                    Console.WriteLine("  <'l'>");
                }
                else if (c == 'm')
                {
                    Dash();
                    DashStop();
                    Console.WriteLine("    <'m'>");
                }
                else if (c == 'n')
                {
                    Dash();
                    DotStop();
                    Console.WriteLine("    <'n'>");
                }
                else if (c == 'o')
                {
                    Dash();
                    Dash();
                    DashStop();
                    Console.WriteLine("   <'o'>");
                }
                else if (c == 'p')
                {
                    Dot();
                    Dash();
                    Dash();
                    DotStop();
                    Console.WriteLine("  <'p'>");
                }
                else if (c == 'q')
                {
                    Dash();
                    Dash();
                    Dot();
                    DashStop();
                    Console.WriteLine("  <'q'>");
                }
                else if (c == 'r')
                {
                    Dot();
                    Dash();
                    DotStop();
                    Console.WriteLine("   <'r'>");
                }
                else if (c == 's')
                {
                    Dot();
                    Dot();
                    DotStop();
                    Console.WriteLine("   <'s'>");
                }
                else if (c == 't')
                {
                    DashStop();
                    Console.WriteLine("     <'t'>");
                }
                else if (c == 'u')
                {
                    Dot();
                    Dot();
                    DashStop();
                    Console.WriteLine("   <'u'>");
                }
                else if (c == 'v')
                {
                    Dot();
                    Dot();
                    Dot();
                    DashStop();
                    Console.WriteLine("  <'v'>");
                }
                else if (c == 'w')
                {
                    Dot();
                    Dash();
                    DashStop();
                    Console.WriteLine("   <'w'>");
                }
                else if (c == 'x')
                {
                    Dash();
                    Dot();
                    Dot();
                    DashStop();
                    Console.WriteLine("  <'x'>");
                }
                else if (c == 'y')
                {
                    Dash();
                    Dot();
                    Dash();
                    DashStop();
                    Console.WriteLine("  <'y'>");
                }
                else if (c == 'z')
                {
                    Dash();
                    Dash();
                    Dot();
                    DotStop();
                    Console.WriteLine("  <'z'>");
                }
                else if (c == '0')
                {
                    Dash();
                    Dash();
                    Dash();
                    Dash();
                    DashStop();
                    Console.WriteLine(" <'0'>");
                }
                else if (c == '1')
                {
                    Dot();
                    Dash();
                    Dash();
                    Dash();
                    DashStop();
                    Console.WriteLine(" <'1'>");
                }
                else if (c == '2')
                {
                    Dot();
                    Dot();
                    Dash();
                    Dash();
                    DashStop();
                    Console.WriteLine(" <'2'>");
                }
                else if (c == '3')
                {
                    Dot();
                    Dot();
                    Dot();
                    Dash();
                    DashStop();
                    Console.WriteLine(" <'3'>");
                }
                else if (c == '4')
                {
                    Dot();
                    Dot();
                    Dot();
                    Dot();
                    DashStop();
                    Console.WriteLine(" <'4'>");
                }
                else if (c == '5')
                {
                    Dot();
                    Dot();
                    Dot();
                    Dot();
                    DotStop();
                    Console.WriteLine(" <'5'>");
                }
                else if (c == '6')
                {
                    Dash();
                    Dot();
                    Dot();
                    Dot();
                    DotStop();
                    Console.WriteLine(" <'6'>");
                }
                else if (c == '7')
                {
                    Dash();
                    Dash();
                    Dot();
                    Dot();
                    DotStop();
                    Console.WriteLine(" <'7'>");
                }
                else if (c == '8')
                {
                    Dash();
                    Dash();
                    Dash();
                    Dot();
                    DotStop();
                    Console.WriteLine(" <'8'>");
                }
                else if (c == '9')
                {
                    Dash();
                    Dash();
                    Dash();
                    Dash();
                    DotStop();
                    Console.WriteLine(" <'9'>");
                }
                else
                {
                    Console.WriteLine("Character '" + c + "' is not a standard character.");
                }
            }
            Console.WriteLine("Message '" + message + "' has finished beeping");
        }
        private static void Dot()
        {
            Console.Beep(frequency, dotDuration);
            Console.Write('.');
            Thread.Sleep(wait);
        }
        private static void DotStop()
        {
            Console.Beep(frequency, dotDuration);
            Console.Write('.');
            Thread.Sleep(stop);
        }
        private static void Dash()
        {
            Console.Beep(frequency, dashDuration);
            Console.Write('-');
            Thread.Sleep(wait);
        }
        private static void DashStop()
        {
            Console.Beep(frequency, dashDuration);
            Console.Write('-');
            Thread.Sleep(stop);
        }
        public static string ToMorse(string eng)
        {
            if (eng.Length == 1)
            {
                if (Morse.CharsToMorse.TryGetValue(Convert.ToChar(eng), out string y) == true)
                {
                    return y;
                }
                else
                {
                    return "Error was encountered <value was not a valid key>";
                }
            }
            else
            {
                return "Error was encountered <value.Length was not 1>";
            }
        }
        public static string ToEng(string morse)
        {
            if (Morse.CharsToEng.TryGetValue(morse, out char y) == true)
            {
                return Convert.ToString(y);
            }
            else
            {
                return "Error was encountered <value was not a valid key>";
            }
        }
    }
}