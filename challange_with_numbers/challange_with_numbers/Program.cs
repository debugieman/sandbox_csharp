
string username;
string password;



Register();
Console.ReadKey();






void Register()
{
    Console.WriteLine("Please enter your login");
    username = Console.ReadLine();




    Console.WriteLine("Please enter your password");
    password = Console.ReadLine();







    Console.WriteLine("Please enter your password again, use the same password");
    Console.ReadLine();
    Console.WriteLine("Thank you. Regisrtration has been succesfull");
         
    
    Console.WriteLine("---------------------------------------------");

}
void Login()
{
    Console.WriteLine("Please enter your username ");
    if (username == Console.ReadLine())
    {
        Console.WriteLine("Enter your password");
        if (password == Console.ReadLine())
        {
            Console.WriteLine("You are logged in");
        }

        else
        {
            Console.WriteLine("Login Failed, please check your username and passowrd. Make sure CAPSLOCK is off");
        }

    }

}

Console.ReadKey();