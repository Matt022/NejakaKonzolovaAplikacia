using NejakaKonzolovaAplikacia;

namespace JustSimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name: ");
            string? name = Console.ReadLine();


            var greetings = new Pozdrav(name);

            Console.WriteLine();

            Console.Write("Type your lastname: ");
            string? lastName = Console.ReadLine();

            var greetingsSecond = new Pozdrav(name, lastName);

        }
    }
}