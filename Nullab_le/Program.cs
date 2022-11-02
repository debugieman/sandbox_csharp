namespace Nullab_le
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? favouritenumber = 11;
            Console.WriteLine("Favourite number:    " + (favouritenumber.HasValue ? favouritenumber.ToString() : ""));
        }
    }
}