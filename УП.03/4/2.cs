using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc2
{
    class posilka
    {
        public string Description
        {
            get;
            private set;
        }
        public int Weight
        {
            get;
            private set;
        }
        public posilka(string description, int weight)
        {
            Description = description;
            Weight = weight;
        }
    }
    class SendingService
    {
        private static int LimitWeight;
        private const int Limit = 10;
        public void SendPackage(posilka package)
        {
            LimitWeight += package.Weight;
            if (LimitWeight >= Limit)
            {
                Console.WriteLine("Ошибка! Вес отправленных посылок превысил лимит, отправка прервана.");
            }
            else
            {
                Console.WriteLine("{0} весом {1} кг успешно отправлена.", package.Description, package.Weight);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            posilka package_1 = new posilka("Стандартная посылка №0000001", 4);
            posilka package_2 = new posilka("Тяжеловесная посылка №0000002", 7);
            SendingService sendingService = new SendingService();
            sendingService.SendPackage(package_1);
            sendingService.SendPackage(package_2);
            Console.ReadKey(true);
        }
    }
}
