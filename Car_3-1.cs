using System;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("класс Машина");
            Car car1 = new Car()
            {
                brand = "Mersedes",
                model = 2021,
                number = 152184
            };

            Car car2 = new Car()
            {
                brand = "ВАЗ",
                model = 785,
                number = 578957
            };
            car1.Start();
            car2.Stop();

            Console.WriteLine("Введите свою машину: марка, модель, номер");
            Car yourcar = new Car()
            {
                brand = Convert.ToString(Console.ReadLine()),
                model = int.Parse(Console.ReadLine()),
                number = int.Parse(Console.ReadLine())
            };

            yourcar.Start();
            yourcar.Stop();
            
            Console.ReadKey();
        }
    }
}
