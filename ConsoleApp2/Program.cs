internal class Program
{
    private static void Main(string[] args, int sum)
    {
        Console.WriteLine("Hello, World!");


        Console.WriteLine("Please enter a number   ");
        var user_input = int.Parse(Console.ReadLine());
        int sum1;

        while (user_input != 0)
        {
            sum1 += user_input;

        }
    }
}