using System;

namespace lr3
{
    class Program
    {
        static int Znamen(int y1, int y2)
        {
            int y3;
            if ((y2 >= y1) && (y2 % y1 == 0))
            {
                y3 = y2;
                return y3;
            }
            else if ((y1 > y2) && (y1 % y2 == 0))
            {
                y3 = y1;
                return y3;
            }
            else

                y3 = y2 * y1;
            return y3;
        }
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Введите числитель первой дроби");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числитель второй дроби");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби");
            y2 = Convert.ToInt32(Console.ReadLine());
            int x3, y3;
            y3 = Znamen(y1, y2);

            x3 = x1 * (y3 / y1) + x2 * (y3 / y2);

            Console.WriteLine("a  = {0}/{1} \nb = {2}/{3} \na + b = {4}/{5}", x1, y1, x2, y2, x3, y3);
            Console.ReadKey();
        }
    }
}
