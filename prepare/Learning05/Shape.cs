abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return $"{_color}";
    }
    public void SetColor(string col)
    {
        _color = col;
    }
    public abstract double GetArea();
}