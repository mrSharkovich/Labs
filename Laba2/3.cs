//using System;

//namespace Laba2
//{
//    public class _3
//    {
//        static void Main(string[] args)
//        {
//            double a, b, c; // вводим тип переменных
//            object n;

//            a = Convert.ToDouble(Console.ReadLine());
//            b = Convert.ToDouble(Console.ReadLine());//считаваем с консоли и переводим в тип double
//            c = Convert.ToDouble(Console.ReadLine());

//            if (a==b && b==c && a==c) //Проверяем условие для равностороннего
//            {
//                n = "3";
//            }
//            else if ((a == b && b != c && a != c)
//                || (a != b && b != c && a == c)
//                || (a != b && b == c && a != c))//Проверяем условие, если 2 стороны одинаковые
//            {
//                n = "2";
//            }
//            else //Иначе все стороны разные
//            {
//                n = "1";
//            }
//            Console.WriteLine("Результат: ");
//            Console.WriteLine(n);   //выводим результат
//            while (Console.ReadKey().Key != ConsoleKey.Enter) { }    //оставляем консоль открытой
//        }
//    }
//}
 