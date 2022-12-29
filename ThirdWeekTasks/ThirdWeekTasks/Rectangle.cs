namespace ThirdWeekTasks;

public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle()
    {
        _width = 1.0;
        _length = 1.0;
    }

    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }

    public Rectangle(double width, double length, string color, bool isFilled)
    {
        _width = width;
        _length = length;
        Color = color;
        IsFilled = isFilled;
    }

    public virtual double Width
    {
        get => _width;
        set => _width = value;
    }

    public virtual double Length
    {
        get => _length;
        set => _length = value;
    }

    public virtual double GetArea()
    {
        return _width * _length;
    }

    public virtual double GetPerimeter()
    {
        return 2 * (_width + _length);
    }

    public override string ToString()
    {
        return "A Rectangle with width = " + _width + " and length = " + _length + " , which is a subclass of " + base.ToString();
    }
}