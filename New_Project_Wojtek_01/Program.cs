namespace New_Project_Wojtek_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number_list = new List<int>();

            // What if not number ? Loop it
            var number_of_numbers = "";
            int numberX = 1;
                       
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("PLease enter number of numbers u wanna enter");
                number_of_numbers = Console.ReadLine();




                if (int.TryParse(number_of_numbers, out numberX))
                {
                    Console.WriteLine($"OK, please enter {numberX} numbers of your choosing");
                    validInput = true;
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a proper number using digits ");

                }
            }






            for (int i = 0; i < numberX; i++)

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
            var Avrg = sum / numberX;

            Console.WriteLine($"The biggest value is : {Max_number}");
            Console.WriteLine($"The lowest value is: {Min_number}");
            Console.WriteLine($"The average value is {Avrg}");
            Console.ReadKey();
            



            

        }
    }
}