var FibonacciNumbers = new List<int> { 1, 1 };
var previous1 = FibonacciNumbers[FibonacciNumbers.Count - 1];
var previous2 = FibonacciNumbers[FibonacciNumbers.Count - 2];
FibonacciNumbers.Add(previous1 + previous2);

foreach (var item in FibonacciNumbers)
    Console.WriteLine(item);
