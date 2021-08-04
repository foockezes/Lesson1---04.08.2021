using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Найти  квадратный корень из их произведения: √a·b.");
            double a = 16.80;
            double b = 12.40;
            Console.WriteLine(Math.Round(Math.Sqrt(a * b),2));

            
            Console.WriteLine("2. Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их  сумму. ");
            decimal A = 1.40m;
            decimal B = -5.50m;
            decimal C = 0.60m;
            decimal AC = A - C;
            Console.WriteLine($"Расстояние отрезка AC равно: {(AC)}");
            decimal BC = Math.Abs(B - C);
            Console.WriteLine($"Расстояние отрезка AC равно: {BC}");
            Console.WriteLine($"Сумма равно: {AC + BC}");

            
            Console.WriteLine("3. Найти расстояние между двумя точками с заданными координатами.");
            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;
            Console.WriteLine($"Расстояние равнa : {Math.Round(Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)),2)}");


            Console.WriteLine("4. Вывести число, полученное при перестановке цифр  исходного числа.");
            int num = 41;
            num = num / 10 + num % 10 * 10;
            Console.WriteLine(num);


            Console.WriteLine("5. Найти количество полных минут,  прошедших с начала суток. ");
            int s = 10985;
            Console.WriteLine(s / 60);


            Console.WriteLine("6. Определить номер дня недели");
            int k = 202;
            int weekN = 7;
            int resoult = (k % weekN);
            Console.WriteLine($" номер дня недели {resoult} - суббота");

        }
    }
}
