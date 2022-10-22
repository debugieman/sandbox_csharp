namespace New_Project_Wojtek_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number_list = new List<int>();
            int number_of_numbers = 1;

            Console.WriteLine("PLease enter number of numbers u wanna enter");
            number_of_numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the numbers");

            for (int i = 0; i < number_of_numbers; i++)

            {
                number_list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int Max_number = Int32.MinValue;
            foreach (int i in number_list)
            {
                if (i > Max_number)
                    Max_number = i;

            }
            int Min_number = Int32.MaxValue;
            foreach (int i in number_list)
            {
                if (i < Min_number)
                    Min_number = i;
            }
            var sum = 0;
            foreach (int i in number_list)
            {
                sum += i;
                

            }
            var Avrg = sum / number_of_numbers;

            Console.WriteLine($"The biggest value is : {Max_number}");
            Console.WriteLine($"The lowest value is: {Min_number}");
            Console.WriteLine($"The average value is {Avrg}");
            Console.ReadKey();
            





        }
    }
}