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


string numberAsString = "128";
int parsedValue;
bool success = int.TryParse(numberAsString, out parsedValue);
//when parsing is succesfull bool is true 


Console.WriteLine("Please enter a number that you would liek to check for odd or even:  ");
string userinput = Console.ReadLine();
int input1;
int number;
bool success_conversion = int.TryParse(userinput, out number);
if (success_conversion)
{
    Console.WriteLine("Conversion successfull");
    int userinput_1 = userinput
}
else
{
    Console.WriteLine("COnversion not succesfull");
}


public static void Check(var userinput)
{
    if (!(userinput % 2 = 0))
    {
        return;
    }
    Console.WriteLine("Number is even");


}

