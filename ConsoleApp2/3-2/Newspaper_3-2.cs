using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Класс Газеты");

            Newspaper newspaper1 = new Newspaper()
            {
                name = "Сапфир",
                number = 545,
                lanes = 4
            };

            Console.WriteLine("Введите свою газету: название, тираж, кол-во полос");
            string name1 = Convert.ToString(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int lanes1 = int.Parse(Console.ReadLine());
            Newspaper newspaper2 = new Newspaper();
            newspaper2.Init(name1, number1, lanes1);

            newspaper1.Info();
            Console.WriteLine();
            newspaper2.Info();

            Console.WriteLine();
            Console.WriteLine("Измените название первой газеты");
            string name2 = Convert.ToString(Console.ReadLine());
            newspaper1.ChangeName(name2);

            Console.WriteLine("Измените количество полос первой газеты");
            int lanes2 = int.Parse(Console.ReadLine());
            newspaper1.ChangeLanes(lanes2);

            Console.WriteLine("Изменённая газета");
            newspaper1.Info();
            Console.ReadKey();
        }
    }
}
