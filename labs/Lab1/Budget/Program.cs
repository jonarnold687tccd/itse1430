
/*
 * Budget
 * ITSE 1430
 * spring 2021
 * Jon Arnold
 */





using System;

namespace Budget
{
    class Program
    {
        static void Main ( string[] args )
        {
            if (args is null)
                throw new ArgumentNullException(nameof(args));
            Console.WriteLine("Program title Budget\n");
            Console.WriteLine("Course name ITSE 1430\n");
            Console.WriteLine("Spring 2021\n");
            Console.WriteLine("Jon Arnold\n\n");
            Console.Write("Please Enter Your Account Information\n");
            Console.Write("Enter your  Account Name:");
            AccountName = Console.ReadLine();
            Console.WriteLine("Enter your account number:");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter your starting balance:");
            StartingBalance = Console.ReadLine();

        }






        static string AccountName;
        static string AccountNumber;
        static string StartingBalance;


        static int Readint32 ()
        {
            return Readint32(Int32.MinValue);
        }

        static int Readint32 ( int ExactNumbers )
        {
            do
            {

                var input = Console.ReadLine();


                if (Int32.TryParse(input, out var result))
                {

                    if (result >= ExactNumbers)
                        return result;
                    else
                        DisplayError("there must be at least  " + ExactNumbers, "didgets");


                } else

                    DisplayError("Value must be  all numbers");

            } while (true);

             

        }

        private static void DisplayError ( string v1, string v2 )
        {
            throw new NotImplementedException();
        }

        private static void DisplayError ( string message )

        {
            Console.WriteLine(message);
        }



    }
    private static char DisplayMainMenu ()
    {

        Console.WriteLine("Main Menu");
        Console.WriteLine("A) Make a deposit");
        Console.WriteLine("B) Make a withdraw");
        Console.WriteLine("Q) quit");

       





        }

    }









}
