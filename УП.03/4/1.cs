using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc1
{
    class volshebnic
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
        public void Use()
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
        public void Castvolshebnic(volshebnic volshebnic)
        {
            if (Mana >= volshebnic.Mana)
            {
                Mana -= volshebnic.Mana;
                Console.WriteLine("{0} колдует!", Name);
                volshebnic.Use();
            }
            else
            {
                int mana = volshebnic.Mana - Mana;
                Console.WriteLine("Для использования {0} не хватает {1} единиц маны. Хлебните зелья!", volshebnic.Name, mana);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            volshebnic alohomora = new volshebnic("Алохомора", 60, "Замок открывается!");
            volshebnic vingardiumLeviosa = new volshebnic("Вингардиум Левиоса", 60, "Предмет поднимается в воздух!");
            zaklinanie harryPotter = new zaklinanie("Гарри Поттер", 100);
            harryPotter.Castvolshebnic(alohomora);
            harryPotter.Castvolshebnic(vingardiumLeviosa);
            Console.ReadKey(true);
        }
    }
}