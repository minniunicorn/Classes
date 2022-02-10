using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Newspaper
    {
        /// <summary>
        /// Название газеты
        /// </summary>
        public string name;
        /// <summary>
        /// Тираж
        /// </summary>
        public int number;
        /// <summary>
        /// Количество полос
        /// </summary>
        public int lanes;
        public void Init(string new_name, int new_number, int new_lanes)
        {
            name = new_name;
            number = new_number;
            lanes = new_lanes;
        }
        public void Info()
        {
            Console.WriteLine("Информация о газете:");
            Console.WriteLine($"Название газеты: {name}, тираж: {number}, количество полос: {lanes}");
        }
        public void ChangeName(string new_name)
        {
            name = new_name;
        }
        public void ChangeLanes(int new_lanes)
        {
            lanes = new_lanes;
        }
    }
}
