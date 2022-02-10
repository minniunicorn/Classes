using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        /// <summary>
        /// Марка машины
        /// </summary>
        public string brand;
        /// <summary>
        /// Модель машины
        /// </summary>
        public int model;
        /// <summary>
        /// Номер машины
        /// </summary>
        public int number;

        public void Start()
        {
            Console.WriteLine("Машина " + brand + " " + model + " завелась");
        }
        public void Stop()
        {
            Console.WriteLine("Машина " + brand + " " + model + " остановилась");
        }
    }
}
