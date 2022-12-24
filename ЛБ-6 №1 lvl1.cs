using System;
namespace ЛАБ6__1_УР_1
{
    struct Sportsmen
    {
        public string famile;
        public string otchestvo;
        public double rez1, rez2, rez;
        public Sportsmen (string famile1, string otchestvo1, double rezz1, double rezz2)
        {
            famile = famile1;
            otchestvo = otchestvo1;
            rez1 = rezz1;
            rez2 = rezz2;
            rez = rez1 + rez2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sportsmen[] sp = new Sportsmen[5];
            sp[0] = new Sportsmen("Иванов", "Петрович", 1.55, 1.68);
            sp[1] = new Sportsmen("Петров", "Васильевич", 1.53, 1.88);
            sp[2] = new Sportsmen("Сидоров", "Дмитриевич", 1.42, 1.5);
            sp[3] = new Sportsmen("Кузнецов", "Витальевич", 1.47, 1.86);
            sp[4] = new Sportsmen("Макаров", "Николаевич", 1.46, 1.72);
            for (int i = 0; i < 5 - 1; i++)
            {
                double amax = sp[i].rez;
                int imax = i;
                for (int j = i + 1; j < 5; j++)
                {
                    if (sp[j].rez > amax)
                    {
                        amax = sp[j].rez;
                        imax = j;
                    }
                }
                Sportsmen temp;
                temp = sp[imax];
                sp[imax] = sp[i];
                sp[i] = temp;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Фамилия:{sp[i].famile} Отчество:{sp[i].otchestvo} Результат:{sp[i].rez}");
            }
        }
    }
}
