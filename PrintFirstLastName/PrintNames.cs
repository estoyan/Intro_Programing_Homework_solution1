using System;


namespace PrintFirstLastName
{
    class PrintNames
    {
        static void Main()
        {
            string fullname = "Stoyan Yankov";
            string[] nameParts = fullname.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

        }
    }
}
