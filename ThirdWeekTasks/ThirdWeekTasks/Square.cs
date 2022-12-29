namespace ThirdWeekTasks;

public class Square : Rectangle
{
    public Square()
    {
        Side = base.Width;
    }

    public Square(double side) : base(side, side)
    {
        Side = side;
    }

    public Square(double side, string color, bool isFilled) : base(side, side, color, isFilled)
    {
        Side = side;
        Color = color;
        IsFilled = isFilled;
    }

    private double Side { get; set; }

    public override double Width
    {
        get => Side;
        set => Side = value;
    }

    public override double Length
    {
        get => Side;
        set => Side = value;
    }

    public override string ToString()
    {
        return "A Square with side = " + Side + " , which is a subclass of " + base.ToString();
    }

    public override double GetArea()
    {
        return Math.Pow(Side, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * Side;
    }
}