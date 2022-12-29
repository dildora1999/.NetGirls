namespace ThirdWeekTasks;

public class Circle : Shape
{
    private double _radius;

    public Circle() => _radius = 1.0;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public Circle(double radius, string color, bool isFilled)
    {
        _radius = radius;
        Color = color;
        IsFilled = isFilled;
    }

    public double Radius
    {
        get => _radius;
        set => _radius = value;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * _radius;
    }

    public override string ToString()
    {
        return "A Circle with radius " + _radius + " , which is a subclass of " + base.ToString();
    }
}