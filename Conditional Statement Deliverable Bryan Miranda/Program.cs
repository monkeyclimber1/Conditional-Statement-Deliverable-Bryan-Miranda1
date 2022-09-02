using System;
// Bryan Miranda
// ISM 4300
// Conditional Statement Deliverable
namespace Conditional_Statement_Deliverable
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in an interger value");
            int grades = (1 - 100);
            try // Beginning of try catch statement
            {
                string input = Console.ReadLine();
                grades = int.Parse(input);

                while (true)
                {
                    if (grades >= 90) // If ranges created for each of the following grades
                    {
                        Console.WriteLine("Your Grade is an A");
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);


                    }
                    else if (grades >= 80 && grades <= 89)
                    {
                        Console.WriteLine("Your Grade is a B");
                        Console.WriteLine("Congratulations");
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);

                    }
                    else if (grades >= 70 && grades <= 79)
                    {
                        Console.WriteLine("Your Grade is a C");
                        Console.WriteLine("Just Barely Made It!");
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);

                    }
                    else if (grades >= 60 && grades <= 69)
                    {
                        Console.WriteLine("Your Grade is a D");
                        Console.WriteLine("Depending on the class you might have to talk to your advisor, sorry");
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);

                    }
                    else if (grades <= 59)
                    {
                        Console.WriteLine("Your Grade is a F");
                        Console.WriteLine("Sorry you failed the class, Better luck next semester");
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);

                    }
                    break;
                }
            }
            catch (FormatException)
            {
                while (true)
                {
                    Console.WriteLine("Use an integer type value");
                    Console.WriteLine("----OR-----");
                    Console.WriteLine("Use a Decimal data type for the grade value");
                    Console.ReadLine();
                    Console.ReadKey(true);
                    break;
                }// End of catch
            }
        }
    }
}

