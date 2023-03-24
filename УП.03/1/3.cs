using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc3
{
    class mashina
    {
        public string name;
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void InfoCar()
        {
            Console.WriteLine($"Авто: {name}, макс скорость: {maxSpeed}.");
        }
        public mashina()
        {
            this.name = "Машина";
            this.maxSpeed = 220;
        }
        public mashina(string name, double speed)
        {
            this.name = name;
            this.maxSpeed = speed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
