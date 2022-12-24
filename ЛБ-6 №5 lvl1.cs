using System;
namespace ЛАБ6__5_УР_1
{
    struct st
    {
        public string famile;
        public int inf;
        public int pos;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            st[] sp = new st[5];
            string[] s = new string[] { "Иванов", "Петров", "Сидоров", "Кузнецов", "Макаров" };
            int[] inf = new int[] { 4, 2, 3, 1, 5 };
            int[] pos = new int[] { 0, 2, 1, 6, 2 };
            for (int i = 0; i < 5; i++)
            {
                sp[i].famile = s[i];
                sp[i].inf = inf[i];
                sp[i].pos = pos[i];
            }
            for (int i = 0; i < 5; i++)
            {
                if (sp[i].inf == 2)
                {
                    for (int l = 0; l < 5 - 1; l++)
                    {
                        double amax = sp[l].pos;
                        int lmax = l;
                        for (int j = i + 1; j < 5; j++)
                        {
                            if (sp[j].pos > amax)
                            {
                                amax = sp[j].pos;
                                lmax = j;
                            }
                        }
                        st temp;
                        temp = sp[lmax];
                        sp[lmax] = sp[l];
                        sp[l] = temp;
                    }
                }
            }
            for (int k = 0; k < 5; k++)
            {
                if (sp[k].inf == 2)
                {
                    Console.WriteLine($"Фамилия: {sp[k].famile}");
                    Console.WriteLine($"Результат: {sp[k].pos}");
                }
            }

        }
    }
}
