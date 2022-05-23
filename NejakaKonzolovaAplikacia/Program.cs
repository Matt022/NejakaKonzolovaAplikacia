namespace JustSimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name: ");
            string? name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
        }
    }
}