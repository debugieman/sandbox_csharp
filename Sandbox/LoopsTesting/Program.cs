Console.WriteLine("Hello, World!");
Console.Title = "Story of day and night";
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("Hello Would you like me to print FizzBuzz?");
string answerF = Console.ReadLine();
Console.WriteLine((answerF == "yes") ? "Great Let's play" : "Not in the mood? Lets play annyway!");



string answer_fizzbuzz = Console.ReadLine();

string answerS = Console.ReadLine();
Console.WriteLine((answerS == "yes") ? "Great Let's play" : "Dont be a party-pooper, l ets play annyway!");


Console.WriteLine("But 1st, what is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"What a great name {userName}, lets get started");

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine($"Ok Dear {userName}, It is {DateTime.Today} today /nThat was so much fun! Let's see what else we can do \n hm...\n hm...\n hm...\n hm...\n hm...\n hm...\n hm...");
Console.WriteLine("OK, I know lets have fun with multiplying numbers, give me two numbers in lines below:  ");

Console.WriteLine($"Ok {userName}, give me the 1st number ");
string number_1 = Console.ReadLine();
Console.WriteLine($"Great job  {userName},  now give me the second number  ");
string number_2 = Console.ReadLine();
var number_1_converted = Convert.ToInt32(number_1);
var number_2_converted = Convert.ToInt32(number_2);
Console.WriteLine(number_2_converted);
Console.WriteLine(number_1_converted);






// pokminic matme w c# , dopisac komentqarzr i do konsoli do wyswietlenia dla usera 
var sum = number_1_converted + number_2_converted;
var multiply = number_1_converted * number_2_converted;


Console.WriteLine("Now i will display some itertesting fact about your numberrs");
Console.WriteLine($"If you add the number together,  you will get: {sum}, \nhowever if u multiply them you will get {multiply}");



// Console.WriteLine($"Ok {userName}, what else we can do, lets play Heads or tails");

Console.WriteLine($" {userName}, lets play heads or tails?");
// var string useranswer = Console.WriteLine($"So {userName}, would you like to ? ");






// bool isPlaying = true;
//             int wins = 0;
//             int loses = 0;
//             bool heads = true;
//             char playerInput;
//             Random rnd = new Random();
//             while isPlaying = true;
//             {
//                 Console.WriteLine("Wins: {0} Loses: {1}", wins, loses);
//                 Console.WriteLine("H for heads, T for tails, E - exit");
//                 if (rnd.Next(0, 101) < 50)
//                 {
//                     heads = true;
//                 }
//                 else
//                 {
//                     heads = false;
//                 }
//                 playerInput = Char.ToLower(Console.ReadKey().KeyChar);
//                 Console.WriteLine("");
//                 if (playerInput == 'h')
//                 {
//                     if (heads)
//                     {
//                         wins++;
//                     }
//                     else
//                     {
//                         loses++;
//                     }
//                 }
//                 else if (playerInput == 't')
//                 {
//                     if (heads)
//                     {
//                         loses++;
//                     }
//                     else
//                     {
//                         wins++;
//                     }
//                 }
//                 else if (playerInput == 'e')
//                 {
//                     isPlaying = false;









Console.ReadKey();



