using System; //Smorg Maxim Hillel

namespace cyb28
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insert namber: ");
            long n = long.Parse(Console.ReadLine()), rez = 0, k = 0;

            while ((k = n % 10) != 0 || n / 10 != 0)
            {
                rez = rez * 10 + k;
                n /= 10;
            }

            Console.WriteLine("Autpoot: {0}", rez);
            Console.ReadKey();
        }
    }
}