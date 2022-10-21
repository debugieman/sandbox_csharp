namespace Syntax_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

            Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
            Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!


            int new_number = 55;
            
            var result  = (new_number >= 20) ? "Big" : "small";

            Console.WriteLine(result);






















        }
    }
}