using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc3
{
    internal class Program
    {
        class Cu3aH
        {
            private string strCipher;
            private int shift;
            public string GetCipher()
            {
                return strCipher;
            }
            public void SetCipher(string code, int shift)
            {
                this.strCipher = EncryptStr(code, shift);
                this.shift = shift;
            }
            private string EncryptStr(string code, int shift)
            {
                char[] alphabet = { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' };
                char l;
                int index;
                string stringCipher = "";
                for (int i = 0; i < code.Length; i++)
                {
                    
                    l = code[i];
                    if (l == ' ')
                    {
                        stringCipher += l;
                        continue;
                    }
                    index = Array.IndexOf(alphabet, l);
                    index += shift;
                    if (index > 32)
                    {
                        index -= 33;
                    } else if (index < 0)
                    {
                        index += 33;
                    }
                    stringCipher += alphabet[index];
                }
                return stringCipher;
            }
        }
        static void Main(string[] args)
        {
            Cu3aH myCipher = new Cu3aH();
            myCipher.SetCipher("��� ����� �� �������� ����� �� �����", 18);
            Console.WriteLine(myCipher.GetCipher());
            myCipher.SetCipher("�� ����� � �������� ����� �� �����", 1);
            Console.WriteLine(myCipher.GetCipher());
            Console.ReadKey(true);
        }
    }
}