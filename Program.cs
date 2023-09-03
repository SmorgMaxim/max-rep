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
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Привіт, я навчаюся у школі Hillel!");
            Console.ReadKey();
        }
    }
}
