using System;

namespace donguler_for_loop;

class Program
{
    static void Main(string[] args)
    {
        // Ekrana girilen sayıya kadar olan tek sayıları yazdır.
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        for (int i = 1; i <= sayi; i++)
        {
            if(i % 2 == 1)
                Console.WriteLine(i);
        }
    }
}
