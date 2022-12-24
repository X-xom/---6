using System;
namespace ЛАБ6__3_УР2
{
    struct Sportsmen
    {
        public string famile;
        public double rez1, rez2, rez3, rez;
        public Sportsmen(string famile1, double rezz1, double rezz2, double rezz3)
        {
            famile = famile1;
            rez1 = rezz1;
            rez2 = rezz2;
            rez3 = rezz3;
            rez = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sportsmen[] sp = new Sportsmen[5];
            sp[0] = new Sportsmen("Иванов", 3.23, 1.55, 1.68);
            sp[1] = new Sportsmen("Петров", 1.53, 1.88, 1.22);
            sp[2] = new Sportsmen("Сидоров", 2.77, 1.42, 1.5);
            sp[3] = new Sportsmen("Кузнецов", 2.05, 1.47, 1.86);
            sp[4] = new Sportsmen("Макаров", 1.23, 1.46, 1.72);
            for (int i = 0; i < 5; i++)
            {
                if (sp[i].rez1 > sp[i].rez2 && sp[i].rez1 > sp[i].rez3)
                {
                    sp[i].rez = sp[i].rez1;
                }
                if (sp[i].rez2 > sp[i].rez1 && sp[i].rez2 > sp[i].rez3)
                {
                    sp[i].rez = sp[i].rez2;
                }
                if (sp[i].rez3 > sp[i].rez1 && sp[i].rez3 > sp[i].rez2)
                {
                    sp[i].rez = sp[i].rez3;
                }
                Console.WriteLine($" Фамилия: {sp[i].famile} Результат: {sp[i].rez}");
            }
        }
    }
}
