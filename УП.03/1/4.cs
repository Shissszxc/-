using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc4
{
    class mashina
    {
        public string name;
        public double maxSpeed;
        private double _time;
        public double time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = CalculateTime(value);
            }
        }
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void InfoCar()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скрость: {maxSpeed}.");
        }
        public mashina()
        {
            this.name = "Автомобиль";
            this.maxSpeed = 180;
            this.time = 0;
        }
        public (string name, double speed, double time)
        {
            this.name = name;
            this.maxSpeed = speed;
            this.time = time;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4];
            double distance = 1000;
            Car jiguli = new Car("жигуль", 100, distance);
            cars[0] = jiguli;
            Car kaban = new Car("кабан", 200, distance);
            cars[1] = kaban;
            Car niva = new Car("нива", 170, distance);
            cars[2] = niva;
            Car bexa = new Car("беха", 300, distance);
            cars[3] = bexa;
            double[] races = new double[4];
            for (int i = 0; i < cars.Length; i++)
            {
                races[i] = cars[i].time;
            }
            Array.Sort(races);
            for (int i = 0; i < races.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (races[i] == cars[j].time)
                    {
                        Console.WriteLine($"{i+1} место получает машина {cars[j].name} с макс скоростью {cars[j].maxSpeed}, проехав {distance} км за {Math.Round(cars[j].time, 2)} ч");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}