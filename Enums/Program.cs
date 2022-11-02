namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your gender ?1 - Male , 2- Female");

            string userInput = Console.ReadLine();
            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("Only women allowed");

            }
            else
            {
                Console.WriteLine("You are welcome");
            }
        }
    }
}