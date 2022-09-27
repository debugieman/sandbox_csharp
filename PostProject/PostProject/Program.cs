// See https://aka.ms/new-console-template for more information
using PostProjectID;

Console.WriteLine("Hello, World!");
Post post1 = new Post("TITLE TITLE TITLE ", true, "USER USER USER ");
Post post2 = new Post("TITLE TITLE TITLE ", true, "USER USER USER ");
Post post3 = new Post("TITLE TITLE TITLE ", true, "USER USER USER ");
Post post4 = new Post("TITLE TITLE TITLE ", true, "USER USER USER ");
Post post5 = new Post("TITLE TITLE TITLE ", true, "USER USER USER ");
Console.WriteLine(post1.ToString());
Console.WriteLine(post2.ToString());
Console.WriteLine(post3.ToString());
Console.WriteLine(post4.ToString());
Console.WriteLine(post5.ToString());
Console.ReadLine();