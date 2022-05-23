
namespace NejakaKonzolovaAplikacia
{
    internal class Pozdrav
    {
        public Pozdrav(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public Pozdrav(string name, string lastName)
        {
            Console.WriteLine($"Hello {name} {lastName} ");
        }
    }
}
