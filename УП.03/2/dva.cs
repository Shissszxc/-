using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc2
{
    class Cu3aH
    {
        private int n = 0;
        public int GetCu3aH(int Cu3aH)
        {
            if (SetCu3aH(Cu3aH))
            {
                this.n = Cu3aH;
            } else
            {
                this.n = 0;
            }
            return this.n;
        }
        private bool SetCu3aH(int Cu3aH)
        {
            if (Cu3aH == this.n + 1)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cu3aH num = new Cu3aH();
            int Cu3aH;
            for (int i = 1; i >= 0; i = num.GetCu3aH(Cu3aH) +1)
            {
                Console.WriteLine($"¬ведите число {i}");
                Cu3aH = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey(true);
        }
    }
}
