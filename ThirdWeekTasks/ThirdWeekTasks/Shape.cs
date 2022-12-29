namespace ThirdWeekTasks;

public class Shape
{
    private string _color;
    private bool _filled;

    public Shape()
    {
        _color = "green";
        _filled = true;
    }

    public Shape(string color, bool filled)
    {
        _color = color;
        _filled = filled;
    }

    public bool IsFilled
    {
        get => _filled;
        set => _filled = value;
    }

    public string Color
    {
        get => _color;
        set => _color = value;
    }

    public new virtual string ToString()
    {
        string filledOrNot = _filled ? "filled" : "Not filled";
        return "A Shape with color of " + _color + " and " + filledOrNot;
    }
}