using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        switch (DateTime.Now.DayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("It's Monday");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Last day of the week");
                break;


            default:
                Console.WriteLine("other day");
                break;
        }


        Console.WriteLine("*************************");

        string userInput = Console.ReadLine();
        int yearOfBirth;
        if (int.TryParse(userInput, out yearOfBirth))
        {
            int age = DateTime.Now.Year - yearOfBirth;
            Console.WriteLine("You are" + age);

        }
        else

        {
            Console.WriteLine("Please enter again");


        }

        Console.WriteLine("******************************");
        double doubleV =  -3.5;
        int intV = (int)doubleV;
        Console.WriteLine(doubleV);






        Console.WriteLine(" ************  TABLICE / Arrays ********** ");

        string[] cars = { "BMW", "Merc", "Audi" };

        int i = 0;
        while (i <= 2)
        {
            Console.WriteLine(i);
            i++; 
        }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }   

    


}