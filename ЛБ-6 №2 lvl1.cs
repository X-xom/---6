using System;
namespace ЛАБ6__2_УР1
{
    struct Sportsmen
    {
        public string famile;
        public int grupp;
        public string prepfam;
        public double rez;
        public Sportsmen(string famile1,int grupp1, string prepfam1, double rez1)
        {
            famile = famile1;
            grupp = grupp1;
            prepfam = prepfam1;
            rez = rez1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sportsmen[] sp = new Sportsmen[5];
            sp[0] = new Sportsmen("Иванова", 2, "Абрамова", 1.68);
            sp[1] = new Sportsmen("Петрова", 1, "Васильков", 1.88);
            sp[2] = new Sportsmen("Сидорова", 5, "Боброва", 1.5);
            sp[3] = new Sportsmen("Кузнецова", 3, "Гусев", 1.47);
            sp[4] = new Sportsmen("Макарова", 4, "Смирнова", 1.72);
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
                Console.WriteLine($"Фамилия:{sp[i].famile} Группа:{sp[i].grupp} Фамилия преподавателя:{sp[i].prepfam} Результат:{sp[i].rez}");
            }
            Console.WriteLine($"Количество участниц:{5}");
        }
    }
}
