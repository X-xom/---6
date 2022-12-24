using System;
namespace ЛАБ_6__2_УР_2
{
    internal class Program
    {
        struct School
        {
            public string famile;
            public double rez;
        }
        static void Main(string[] args)
        {
            School[] sc = new School[5];
            string[] fam = new string[5];
            double[] rez1 = new double[5];
            double[] rez2 = new double[5];
            double[] rez3 = new double[5];
            double[] rez = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите фамилию ученика: ");
                fam[i] = Console.ReadLine();
                Console.WriteLine("Введите результат по русскому языку: ");
                rez1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите результат по математике: ");
                rez2[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите результат по физике: ");
                rez3[i] = double.Parse(Console.ReadLine());
                rez[i] = (rez1[i] + rez2[i] + rez3[i])/3;
                sc[i].famile = fam[i];
                sc[i].rez = rez[i];
            }
            for (int i = 0; i < 5; i++)
            {
                if (sc[i].rez > 2)
                {
                    for (int j = 0; j < 5 - 1; j++)
                    {
                        double amax = sc[j].rez;
                        int jmax = j;
                        for (int I = j + 1; I < 5; I++)
                        {
                            if (sc[i].rez > amax)
                            {
                                amax = sc[i].rez;
                                jmax = I;
                            }
                        }
                        School temp;
                        temp = sc[jmax];
                        sc[jmax] = sc[j];
                        sc[j] = temp;
                    }
                }
            }
            Console.WriteLine("Фамилия: Результат: ");
            for (int k = 0; k < 5; k++)
            {
                if (sc[k].rez > 2)
                {
                    Console.WriteLine($"{sc[k].famile} {sc[k].rez}");
                }
            }
        }
    }
}
