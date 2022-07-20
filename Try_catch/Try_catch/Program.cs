Console.WriteLine("PLease enter your name and press enter: ");
string myName = Console.ReadLine();
string myNameUpper = String.Format($"Upper case: {myName.ToUpper()}");
Console.WriteLine(myNameUpper);
string myNameLower = String.Format($"Lower case: {myName.ToLower()}");
Console.WriteLine(myNameLower);




Console.WriteLine("Enter a number!");
string userInput = Console.ReadLine();

try
{
    int userInputAsInt = int.Parse(userInput);
}

//exception is any type of error
catch (FormatException)
{

    Console.WriteLine("Format Exception, please enter a number ");
}
finally
{
    Console.WriteLine("Thank you");
}

