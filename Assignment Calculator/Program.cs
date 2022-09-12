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
                    Console.WriteLine("Select from Calculator Menu");
                    PrintMenu();
                    int select = AskUserForChoice("XXXX");

                    switch(select)
                    {
                        case 1:
                            Addition();


                    }
                }
            }

        }

        static void PrintMenu()
        {
            Console.WriteLine("----------------Calculator----------------";
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");

            Console.WriteLine("Press 9 to Exit");
        }

        static int Addition() {

        }
    }
}