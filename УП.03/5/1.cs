using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zxc1
{
    interface IAnimal
    {
        void Voice();
    }
    class sobaka: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("гавгав");
        }
    }
    class Cot: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }
    class Owl: IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тихо, я сплю!");
            }
            else
            {
                Console.WriteLine("Уx");
            }
        }
    }
    class Misha: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Писк");
        }
    }
    class KON : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("Игого");
            }
            else
            {
                Console.WriteLine("Я устал");
            }
        }
    }
    internal class Program
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Мы гладим зверюшку, а она нам говорит:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new sobaka());
            myAnimals.Add(new Cot());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Misha());
            myAnimals.Add(new KON());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}
