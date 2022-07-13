var fibonacciNumbers = new List<int> { 1, 1 };
Console.WriteLine("Wich Fibonacci number would u like to know? ");
var x = Console.ReadLine();
int num_x = Int32.Parse(x);



while (fibonacciNumbers.Count <num_x )
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
}



foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);