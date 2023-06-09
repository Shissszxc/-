using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc5
{
    interface IMagic
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    class volshebnic : IMagic
    {
        public string Name
        {
            get;
            set;
        }
        public int Mana
        {
            get;
            set;
        }
        private string Effect
        {
            get;
            set;
        }
        public volshebnic(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void WriteInfo()
        {
            Console.WriteLine(Effect);
        }
    }
    class zaklinanie
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        public zaklinanie(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void WriteInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Mana);
        }
        public void Castvolshebnic(volshebnic volshebnic)
        {
            if (Mana >= volshebnic.Mana)
            {
                Mana -= volshebnic.Mana;
                Console.WriteLine($"{Name} �������!");
                volshebnic.WriteInfo();
            }
            else
            {
                int mana = volshebnic.Mana - Mana;
                Console.WriteLine($"��� ������������� {volshebnic.Name} �� ������� {mana} ������ ����. �������� �����!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            volshebnic alohomora = new volshebnic("���������", 60, "����� �����������!");
            volshebnic vingardiumLeviosa = new volshebnic("���������� �������", 60, "������� ����������� � ������!");
            zaklinanie harryPotter = new zaklinanie("����� ������", 100);
            harryPotter.Castvolshebnic(alohomora);
            harryPotter.Castvolshebnic(vingardiumLeviosa);
            Console.ReadKey(true);
        }
    }
}
