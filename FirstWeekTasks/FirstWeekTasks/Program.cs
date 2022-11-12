namespace FirstWeekTasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, input the task number, please: ");
        string? taskNumber = Console.ReadLine();
        switch (taskNumber)
        {
            case "1":
                HelloWorld();
                break;
            case "2":
                Greeting();
                break;
            case "3":
                GreetingAliceBob();
                break;
            case "4":
                Sum();
                break;
            case "5":
                SumMultipleThreeFive();
                break;
            case "6":
                SumOrProduct();
                break;
            case "7":
                MultiplicationTable();
                break;
            case "8":
                PrintAllPrimeNumbers();
                break;
            case "9":
                GuessingGame();
                break;
            case "10":
                PrintNext20LeapYears();
                break;
            case "11":
                AlternatingSeries();
                break;
            default:
                Console.WriteLine("Incorrect input!");
                break;
        }
    }

    private static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    private static void Greeting()
    {
        Console.Write("Please enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
    }

    private static void GreetingAliceBob()
    {
        Console.Write("Please enter your name: ");
        string? name = Console.ReadLine();
        if (name.Equals("Alice") || name.Equals("Bob")) Console.WriteLine("Hello " + name);
        else
            Console.WriteLine("Hello");
    }

    private static void Sum()
    {
        Console.Write("Please enter number till to sum: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= number; i++)
            sum += i;
        Console.WriteLine("Sum is: " + sum);
    }

    private static void Product()
    {
        Console.Write("Please enter number till to multiply: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int product = 1;
        for (int i = 1; i <= number; i++)
            product *= i;
        Console.WriteLine("Product is: " + product);
    }

    private static void SumMultipleThreeFive()
    {
        Console.Write("Please enter number till to sum: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= number; i++)
            if (i % 3 == 0 || i % 5 == 0)
                sum += i;
        Console.WriteLine("Sum of multiples of 3 or 5 is: " + sum);
    }

    private static void SumOrProduct()
    {
        Console.Write("Please enter S to find the sum or P to find the product: ");
        string? choice = Console.ReadLine();
        if (choice.Equals("s"))
            Sum();
        else if (choice.Equals("p"))
            Product();
        else
            Console.WriteLine("Incorrect input!");
    }

    private static void MultiplicationTable()
    {
        Console.Write("Please input the number for table: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
            Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
    }

    private static void PrintAllPrimeNumbers()
    {
        bool isPrime = true;
        Console.WriteLine("Prime numbers till 2147483647: ");
        for (int i = 2; i <= Int32.MaxValue; i++)
        {
            for (int j = 2; j <= 100; j++)
                if (i % j == 0 && i != j)
                {
                    isPrime = false;
                    break;
                }

            if (isPrime) Console.Write("\t" + i);
            isPrime = true;
        }
    }

    private static void GuessingGame()
    {
        var random = new Random();
        int number = random.Next(1, 10);
        int guessedNumber, numberOfGuesses = 1;
        do
        {
            Console.Write("Please guess the number between 1 to 10: ");
            guessedNumber = Convert.ToInt32(Console.ReadLine());
            if (guessedNumber > number)
            {
                Console.WriteLine("Your guess is high");
            }
            else if (guessedNumber < number)
            {
                Console.WriteLine("Your guess is low");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine("Number of guesses is: " + numberOfGuesses);
            }

            numberOfGuesses++;
        } while (guessedNumber != number);
    }

    private static void PrintNext20LeapYears()
    {
        int year = DateTime.Now.Year;
        int count = 0;
        while (count < 20)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine(year);
                count++;
            }

            year++;
        }
    }

    private static void AlternatingSeries()
    {
        Console.Write("Please enter number from 1 to million: ");
        int k = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= k; i++) sum += Math.Pow((-1), i + 1) / (2 * i - 1);
        Console.WriteLine("Result is: " + 4 * sum);
    }
}