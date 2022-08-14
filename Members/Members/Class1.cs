namespace Members
{
    public class Class1
    {
        //member private field:
        private string memberName;
        public string jobTitle;
        private int salary = 20000;

        //member public field
        public int age;
        // member - property - exposes jobTitle safely - properties start with Capital Letter 
        public string JobTitle
        {
            get 
            {
                return jobTitle; 
            }
            set
            {
                jobTitle = value;
            }
        public void Introducing (bool isfriend)

        {
            if (isfriend = True)
            {
                SharingPrivateInfo();

            }
            else
            {
                Console.WriteLine($"Hi my name is {memberName} , and im years old");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }


        public  void Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Cook";


            Console.WriteLine("Object created");
       
        }
        // member finalizer destructor

         

