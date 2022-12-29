namespace ThirdWeekTasks;

class Program
{
    static void Main()
    {
        var shape = new Shape();
        Console.WriteLine("Default properties: " + shape.Color + " and " + shape.IsFilled);
        shape.Color = "magenta";
        shape.IsFilled = false;
        Console.WriteLine("Changed properties: " + shape.Color + " and " + shape.IsFilled);
        Console.WriteLine(shape.ToString());

        var shape2 = new Shape("black", true);
        Console.WriteLine("Properties of second shape created using parametrized constructor: " + shape2.Color + " and " + shape2.IsFilled);

        var square = new Square(5);
        Console.WriteLine(square.ToString());
    }
}