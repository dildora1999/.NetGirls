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
            case "8":
                FindFirstTwentyPerfectSquaresAndFromArray();
                break;
            case "9":
                ConcatTwoArrays();
                break;
            case "10":
                ConcatTwoArraysAlternatively();
                break;
            case "11":
                ConcatTwoSortedArrays();
                break;
            case "12":
                RotateArrayByK();
                break;
            case "13":
                FibonacciNumbers();
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

    private static void FindFirstTwentyPerfectSquaresAndFromArray()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6 };
        Array.ForEach(array, OnAll);
        Console.WriteLine("First twenty perfect squares:");
        for (int i = 1; i <= 20; i++)
            Console.WriteLine(Math.Pow(i, 2) + " ");
    }

    private static void OnAll(int number)
    {
        if (Math.Sqrt(number) == (int)Math.Sqrt(number))
            Console.WriteLine("Number " + number + " is perfect square");
    }

    private static void ConcatTwoArrays()
    {
        int[] array1 = new[] { 1, 2, 3 };
        int[] array2 = new[] { 4, 5, 6 };
        array1 = array1.Concat(array2).ToArray();
        Array.ForEach(array1, i => Console.Write("\"" + i + "\"" + " "));
    }

    private static void ConcatTwoArraysAlternatively()
    {
        int[] array1 = new[] { 1, 2, 3, 7 };
        int[] array2 = new[] { 4, 5, 6 };
        int[] array = new int[array1.Length + array2.Length];
        int first = 0;
        int second = 0;
        int third = 0;
        while (first < array1.Length && second < array2.Length)
        {
            array[third++] = array1[first++];
            array[third++] = array2[second++];
        }

        while (first < array1.Length)
            array[third++] = array1[first++];
        while (second < array2.Length)
            array[third++] = array2[second++];

        Array.ForEach(array, i => Console.Write("\"" + i + "\"" + " "));
    }

    private static void ConcatTwoSortedArrays()
    {
        int[] array1 = new[] { 1, 3, 4 };
        int[] array2 = new[] { 2, 5, 6 };
        array1 = array1.Concat(array2).OrderBy(o => o).ToArray();
        Array.ForEach(array1, i => Console.Write("\"" + i + "\"" + " "));
    }

    private static void FibonacciNumbers()
    {
        double[] array = new double[100];
        double first = 1;
        double second = 1;
        array[0] = first;
        array[1] = second;
        for (int i = 2; i < 100; i++)
        {
            double next = first + second;
            array[i] = next;
            first = second;
            second = next;
        }

        Array.ForEach(array, i => Console.Write("\"" + i + "\"" + " "));
    }
}