using System;

class Program
{
    static void Main(string[] args)
    {
        ///podaj ile chcesz dodac liczb do listy
        ///podaje liczbe
        ///podaj liczby do listy:
        ///petla sie konczy gdy podasz wystarczajaco duzo \

        Console.WriteLine("Podaj ile chcesz miec liczb w tablicy ");
        int n = int.Parse(Console.ReadLine());
        int[] tablica = new int [n];
        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"Liczba: {i + 1}");
            tablica[i] = int.Parse(Console.ReadLine());
        }
        foreach (int k in tablica)
        {
            Console.Write(k + " \n");
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Posortowana tablica bubble sortem:");
        foreach (int liczba in tablica)
        {
            Console.Write(liczba + " ");
        }
    }
}