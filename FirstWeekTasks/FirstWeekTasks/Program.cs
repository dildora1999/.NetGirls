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
            case "7":
                MultiplicationTable();
                break;
        }
    }

    private static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    private static void MultiplicationTable()
    {
        Console.Write("Please input the number for table: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
            Console.Write("{0} * {1} = {2} \n", number, i, number * i);
    }
}