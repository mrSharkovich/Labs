using System;

namespace Laba2
{
    public class _4
    {
        static void Main(string[] args)
        {
            double x, y; // вводим тип переменных
            object ans;

            x = Convert.ToDouble(Console.ReadLine());//считаваем с консоли и переводим в тип double
            y = Convert.ToDouble(Console.ReadLine());


            if (y >= -2 && x>=y && x*x+y*y>=4 && x<0 ) //Проверяем условия по заданию
            {
                ans = "Точка входит в заданную область";
            }
            else                                      //В обратном случае
            {
                ans = "Точка не входит в заданную область";
            }
            Console.WriteLine(ans);   //выводим результат
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }    //оставляем консоль открытой
        }
    }
}
