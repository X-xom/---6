using System;
namespace ЛАБ6__4_УР2
{
    struct Sportsmen
    {
        public string famile;
	    public double rez;
    }
     class Program
     {
         static void Main(string[] args)
         {
            Sportsmen[] sp = new Sportsmen[5];
            string[] fam = new string[] { "Иванов", "Петров", "Макаров", "Кузнецов", "Сидоров" };
            double[] rez1 = new double[] { 1.2, 2.0, 1.65, 1.56, 1.8 };
            double[] rez2 = new double[] { 1.3, 2.1, 1.6, 1.7, 1.9 };
            double[] rez = new double[5];
            for (int i = 0; i < 5; i++)
            {
                rez[i] = rez1[i] + rez2[i];
                sp[i].famile = fam[i];
                sp[i].rez = rez[i];
            }
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
                Console.WriteLine($"Фамилия: {sp[i].famile}");
                Console.WriteLine($"Результат: {sp[i].rez}");
            }
         }
     }

}
