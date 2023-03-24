using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc1
{
    internal class Program
    {
        class Cu3aH
        {
            private int _red;
            private int _green;
            private int _blue;
            public int Red {
                get
                {
                    return _red;
                }
                set
                {
                    _red = NormalizeCu3aHValue(value);
                }
            }
            public int Green
            {
                get
                {
                    return _green;
                }
                set
                {
                    _green = NormalizeCu3aHValue(value);
                }
            }
            public int Blue
            {
                get
                {
                    return _blue;
                }
                set
                {
                    _blue = NormalizeCu3aHValue(value);
                }
            }
            public Cu3aH()
            {

            }
            public Cu3aH(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
            public void DisplayCu3aH()
            {
                Console.WriteLine($"{_red}, {_green}, {_blue}");
            }
            private int NormalizeCu3aHValue(int Cu3aHValue)
            {
                if (Cu3aHValue > 255)
                {
                    return 255;
                }
                if (Cu3aHValue < 0)
                {
                    return 0;
                }
                return Cu3aHValue;
            }
        }
        static void Main(string[] args)
        {
            Cu3aH crimson = new Cu3aH(190, 38, 76);
            crimson.DisplayCu3aH();
            Cu3aH gray = new Cu3aH();
            gray.Red = 180;
            gray.Green = 180;
            gray.Blue = 165;
            gray.DisplayCu3aH();
            Console.ReadKey(true);
        }
    }
}