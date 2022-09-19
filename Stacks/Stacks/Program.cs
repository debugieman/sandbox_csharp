// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Peek();
Console.WriteLine($"Top value of this stack is  {1}");
int myStackItem = stack.Pop();
Console.WriteLine(myStackItem);



//QUEUE

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);   
queue.Enqueue(3);
Console.WriteLine($"The last value in queue is {queue.Peek()}");



Queue<string> Qstring = new Queue<string>();
Qstring.Enqueue("one");
Qstring.Enqueue("two");
Qstring.Enqueue("three");
Qstring.Enqueue("four");
foreach (string q in Qstring)
{
    Console.WriteLine(q);
}

Console.WriteLine("-----------------------------------------");

Queue<string> Qcopytest = new Queue<string>(Qstring.ToArray());

foreach (string q in Qcopytest)
{
    Console.WriteLine(q);
}

Console.ReadKey();