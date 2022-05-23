using NejakaKonzolovaAplikacia;

namespace JustSimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name: ");
            string? name = Console.ReadLine();


            var pozdrav = new Pozdrav(name);
        }
    }
}