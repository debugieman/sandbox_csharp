// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Peek();
Console.WriteLine($"Top value of this stack is  { 1}");
int myStackItem = stack.Pop();
Console.WriteLine(myStackItem);