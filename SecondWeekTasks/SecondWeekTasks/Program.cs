namespace SecondWeekTasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, input the task number, please: ");
        string? taskNumber = Console.ReadLine();
        switch (taskNumber)
        {
            case "1":
                MaxArray();
                break;
            case "2":
                ReverseArray();
                break;
            case "3":
                ElementThatOccursInArray();
                break;
            case "4":
                ElementsWithOddIndexes();
                break;
            case "5":
                SumOfTotalElements();
                break;
            case "6":
                IsStringPalindrome();
                break;
            case "7":
                ThreeTypesSum();
                break;
            case "12":
                RotateArrayByK();
                break;
            case "14":
                ArrayOfDigits();
                break;
            default:
                Console.WriteLine("Incorrect input!");
                break;
        }
    }

    private static void MaxArray()
    {
        int[] array = new[] { 5, 6, 3, 10, 1, 4 };
        Console.WriteLine(array.Max());
    }

    private static void ReverseArray()
    {
        int[] array = new[] { 5, 6, 3, 10, 1, 4 };
        array = array.Reverse().ToArray();
        Array.ForEach(array, i => Console.Write(i + "\t"));
    }

    private static void ElementThatOccursInArray()
    {
        int[] array = new[] { 5, 6, 3, 10, 1, 4 };
        Console.Write("Please enter number to find in array: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write(array.Any(i => i == number) ? "Yes this number is in array" : "No this number is not in array");
    }

    private static void ElementsWithOddIndexes()
    {
        int[] array = new[] { 5, 6, 3, 10, 1, 4 };
        for (int i = 0; i <= array.Length; i++)
            if (i % 2 != 0)
                Console.Write(array[i] + "\t");
    }

    private static void SumOfTotalElements()
    {
        int[] array = new[] { 5, 6, 3, 10, 1, 4 };
        Console.WriteLine("Sum is: " + array.Sum());
    }

    private static void IsStringPalindrome()
    {
        Console.Write("Please input the string to test: ");
        string? input = Console.ReadLine();
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        string firstHalf = input.Substring(0, input.Length / 2);
        string reversedString = new string(array);
        string secondHalfReversed = reversedString.Substring(0, reversedString.Length / 2);
        Console.Write(firstHalf.Equals(secondHalfReversed) ? "It is palindrome" : "It is not palindrome");
    }

    private static void ThreeTypesSum()
    {
        int[] array = new[] { 5, 6, 3, 10, 1, 4 };
        int sum1 = 0;
        for (int i = 0; i < array.Length; i++)
            sum1 += array[i];
        Console.WriteLine(sum1);

        int sum2 = 0;
        int j = 0;
        while (j < array.Length)
        {
            sum2 += array[j];
            j++;
        }

        Console.WriteLine(sum2);
        int sum3 = FindSumRecursively(array, array.Length);
        Console.WriteLine(sum3);
    }

    private static int FindSumRecursively(int[] array, int arrayLength)
    {
        if (arrayLength <= 0)
            return 0;
        return (FindSumRecursively(array, arrayLength - 1) + array[arrayLength - 1]);
    }

    private static void RotateArrayByK()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6 };
        Console.Write("Please enter number of positions to rotate array: ");
        int k = Convert.ToInt32(Console.ReadLine());
        while (k > 0)
        {
            int firstElement = array[0];
            for (int i = 0; i < (array.Length - 1); i++) array[i] = array[i + 1];
            array[(array.Length - 1)] = firstElement;
            k--;
        }

        Array.ForEach(array, i => Console.Write("\"" + i + "\"" + " "));
    }

    private static void ArrayOfDigits()
    {
        Console.Write("Please input the number to return its digits: ");
        string? input = Console.ReadLine();
        char[] array = input.ToCharArray();
        Array.ForEach(array, i => Console.Write("\"" + i + "\"" + " "));
    }
}