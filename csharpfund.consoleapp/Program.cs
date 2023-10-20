using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace cshapfund.consoleapp
{

    internal class program
    {

        static void Main(string[] args)
        {
            int Min = 0, Max = 0, StrLength = 0;
            string SelectedOption = "";
            bool answer1 = false, answer2 = false, answer3 = false, answer4 = false;

            string space = "----------------------------------------------";
            while (true)
            {
                Console.WriteLine("Please Select an option\n1.Generate Random Number \n2.Generate Random String\n" + space);
                try
                {
                    SelectedOption = Console.ReadLine();
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

                if (SelectedOption == "1")
                {
                    Console.WriteLine("please Enter Minimum value");
                    try
                    {
                        Min = int.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }


                    Console.WriteLine(space);
                    Console.WriteLine("please Enter Maximum value");
                    try
                    {
                        Max = int.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                    Console.WriteLine(space);

                    GenerateRandom(Min, Max);
                }

                else if (SelectedOption == "2")
                {
                    Console.WriteLine("Please Enter String Length");
                    try
                    {
                        StrLength = int.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        return;

                    }
                    Console.WriteLine("Answer the Following Questions by yes or no");
                    Console.WriteLine("Include Capital Leters (yes/no");

                    var option1 = Console.ReadLine();

                    if (option1.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        answer1 = true;
                    }
                    else if (option1.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        answer1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter yes or no.");
                        return;
                    }


                    Console.WriteLine("Include small Leters (yes/no)");

                    var option2 = Console.ReadLine();
                    if (option2.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        answer2 = true;
                    }
                    else if (option2.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        answer2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter yes or no.");
                        return;
                    }
                    Console.WriteLine("Include Numbers (yes/no)");

                    var option3 = Console.ReadLine();
                    if (option3.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        answer3 = true;
                    }
                    else if (option3.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        answer3 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter yes or no.");
                        return;
                    }
                    Console.WriteLine("Include Sympols (yes/no)");

                    var option4 = Console.ReadLine();

                    if (option4.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        answer4 = true;
                    }
                    else if (option4.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        answer4 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter yes or no.");
                        return;
                    }
                    GenerateString(StrLength, answer1, answer2, answer3, answer4);


                }
                Console.WriteLine("==================================");

            }
        }
        static void GenerateRandom(int Min, int Max)
        {
            var rd = new Random();
            var number = rd.Next(Min, Max);
            Console.WriteLine($"Your Random Number is {number}");
        }

        private const string buffer = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789*/!@$%^&*_";

        static void GenerateString(int StrLength, bool answer1, bool answer2, bool answer3, bool answer4)
        {
            var sb = new StringBuilder();
            var rnd = new Random();
            while (sb.Length < StrLength)
            {
                if (answer1 == true)
                {
                    var RandomIndex = rnd.Next(25, 50);
                    var StringResult = sb.Append(buffer[RandomIndex]);

                }
                if (answer2 == true)
                {
                    var RandomIndex = rnd.Next(0, 24);
                    var StringResult = sb.Append(buffer[RandomIndex]);
                }
                if (answer3 == true)
                {
                    var RandomIndex = rnd.Next(51, 60);
                    var StringResult = sb.Append(buffer[RandomIndex]);

                }
                if (answer4 == true)
                {
                    var RandomIndex = rnd.Next(61, 70);
                    var StringResult = sb.Append(buffer[RandomIndex]);

                }
            }
            Console.WriteLine($"Random String is : {sb}");
        }
    }
}