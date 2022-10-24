using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        int a, b = 0;
        Console.WriteLine("какой сейчас год");
        a = int.Parse(Console.ReadLine());
        if (a % 4 == 0 || a % 100 == 0 && a % 400 == 0)
        {
            Console.WriteLine("Год високосный");
            Console.WriteLine("Введите номер месяца");
            b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 2)
            {
                Console.WriteLine("В месяце 29 дней");
            }
            if (b == 3)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 4)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 5)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 6)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 7)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 8)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 9)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 10)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 11)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 12)
            {
                Console.WriteLine("В месяце 30 дней");
            }
        }
        else
        {
            Console.WriteLine("Год не високосный");
            Console.WriteLine("Введите номер месяца");
            b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 2)
            {
                Console.WriteLine("В месяце 28 дней");
            }
            if (b == 3)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 4)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 5)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 6)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 7)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 8)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 9)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 10)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            if (b == 11)
            {
                Console.WriteLine("В месяце 31 день");
            }
            if (b == 12)
            {
                Console.WriteLine("В месяце 30 дней");
            }
        }


    }
}
