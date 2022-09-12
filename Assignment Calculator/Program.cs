namespace Assignment_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            do
            {
                try
                {
                    Console.Clear();
                    PrintMenu();
                    int select = AskUserForChoice("");
                    Console.WriteLine("Enter 1st number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int result = 0;

                    switch (select)
                    {
                        case 1:
                            {
                                result = Addition(num1, num2);
                            }
                            break;
                        case 2:
                            {
                                result = Subtraction(num1, num2);
                            }
                            break;
                        case 3:
                            {
                                result = Multiplication(num1, num2);
                            }
                            break;
                        case 4:
                            {
                                while (num2 == 0)
                                {
                                Console.WriteLine("Calculation not possible!");
                                num2 = Convert.ToInt32(Console.ReadLine());
                                }
                                result = Division(num1, num2);
                                    break;
                            }
                        case 9:
                            keepRunning = false;
                            Console.WriteLine("Thank you for using the calculator! Welcome back anytime!");
                            break;


                    }
                    Console.WriteLine("The result of the calculation are: " + result);
                    Console.ReadKey(true);
                    Console.Clear();

                }
                catch
                {

                    Console.WriteLine("Exception has occurred.");
                }


            } while (keepRunning);
        }
        static void PrintMenu()
            {
                Console.WriteLine("--------------- Calculator Menu ---------------");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 9 to Exit");
            }

            static int Addition(int num1, int num2) {
                int result = num1 + num2;
                return result;

            }

            static int Subtraction(int num1, int num2)
            {
                int result = num1 - num2;
                return result;

            }

            static int Multiplication(int num1, int num2)
            {
                int result = num1 * num2;
                return result;

            }

            static int Division(int num1, int num2)
            {
                int result = num1 / num2;
                return result;

            }

            static string? AskUserFor(string what)
            {
                Console.Write("Please enter choice of calculation: " + what);
                return Console.ReadLine();

            }
            static int AskUserForChoice(string what)
            {
                string? result = AskUserFor(what);
                int choice = Convert.ToInt32(result);
                return choice;
            }
        }
    }
