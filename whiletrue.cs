using System; 
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Podaj liczbe ");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba == 0)
            {
                Console.Clear();
                Console.WriteLine("Koniec programu!");
                break;
            }

        }
    }
}







