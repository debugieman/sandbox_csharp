
Console.WriteLine("How old are you ?");
string age = Console.ReadLine();

var agex =  int.Parse(age);
switch (agex)
{
    case 15:
        Console.WriteLine("To young");
        break;
    case 25:
        Console.WriteLine("good to go ");
        break;
    default:
        Console.WriteLine("how old are u?");
        break;
}
Console.ReadKey();


int temperature = 101;
string stateOfMatter;



if (temperature < 0)
    stateOfMatter = "solid";
else
    stateOfMatter = "liquid";
Console.WriteLine($"State of matter is {stateOfMatter}");


/*
stateOfMatter = temperature < 0 ? "solid" : "liquid";
Console.WriteLine($"state of matter is {stateOfMatter}");
*/

if (temperature < 0)
    stateOfMatter = "solid";
else if (temperature >= 0 && temperature < 100) 
    stateOfMatter = "liquid";
else 
    stateOfMatter = "gas";
Console.WriteLine(stateOfMatter);

Console.ReadKey();