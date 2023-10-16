//using System;

//namespace Laba2
//{
//    public class _2
//    {
//        static void Main(string[] args)
//        {
//            double x, y; // вводим тип переменных
//            object quater;

//            x = Convert.ToDouble(Console.ReadLine());//считаваем с консоли и переводим в тип double
//            y = Convert.ToDouble(Console.ReadLine());

//            if (x > 0 && y > 0) //Проверяем условие для 1 четверти
//            {
//                quater = "1";
//            }
//            else if (x < 0 && y > 0)//Проверяем условие для 2 четверти
//            {
//                quater = "2";
//            }
//            else if (x < 0 && y < 0)//Проверяем условие для 3 четверти
//            {
//                quater = "3";
//            }
//            else if (x > 0 && y < 0)
//            {
//                quater = "4";//Проверяем условие для 4 четверти
//            }
//            else
//            {
//                quater = "точка на оси, не";//Случай с 0
//            }
//            Console.WriteLine(quater + " четверть");   //выводим результат
//            while (Console.ReadKey().Key != ConsoleKey.Enter) { }    //оставляем консоль открытой
//        }
//    }
//}
