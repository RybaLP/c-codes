using System;
class Program
{
    static void Main(string[] args)
    {
        int[] tablica = new int[10];
        int suma = 0;
        int iloczyn = 1;
        int srednia = 0;
        int min = 1;
        int max = 0;
        Console.WriteLine("Witaj użytkowniku! \n Proszę podać 10 liczb! ");
        for(int i = 0; i<10; i++)
        {
            
            Console.WriteLine($"Liczba: {i + 1}");
            tablica[i] = int.Parse(Console.ReadLine());
            suma += tablica[i];
            iloczyn *= tablica[i];
        }

        srednia = (suma / tablica.Length);

        for (int i = 0; i < 10; i++)
        {
            if (tablica[i] > max)
            {
                max = tablica[i];
            }
            if (tablica[i] < min)
            {
                min = tablica[i];
            }
        }

        Console.Clear();
        Console.WriteLine($"1) Wynik sumy podanych liczb: {suma}");
        Console.WriteLine($"2) Wynik iloczynu podanych liczb: {iloczyn}");
        Console.WriteLine($"3) Srednia arytmetyczna wynosi: : {srednia}");
        Console.WriteLine($"4) Najwieksza liczba to: {max} a najmniejsza: {min}");

        Console.WriteLine("Podane przez Ciebie liczby to:");

        foreach(int i in tablica)
        {
            Console.Write($"{i}" + " ");
        }
    }
}