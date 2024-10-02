using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rastgele 10 adet sayıdan oluşan bir liste oluşturuyoruz
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 50));  // -50 ile 50 arasında rastgele sayılar
        }

        Console.WriteLine("Oluşturulan Liste: ");
        numbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Çift Sayılar: ");
        evenNumbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Tek Sayılar: ");
        oddNumbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("Negatif Sayılar: ");
        negativeNumbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine("Pozitif Sayılar: ");
        positiveNumbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // 15'ten büyük ve 22'den küçük sayılar
        var betweenNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: ");
        betweenNumbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // Her sayının karesi
        var squares = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Her Sayının Karesi: ");
        squares.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");
    }
}