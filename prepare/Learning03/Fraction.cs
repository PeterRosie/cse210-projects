class Fraction
{
    private int _top;
    private int _bottom;
    double num = 0;
    public Fraction()
    {

        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        _bottom = 1;
        WholeNumber = _top / _bottom;
    }
    public Fraction(int top, int bottom)
    {
        int frac = top / bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double result = (double)_top / _bottom;
        return result;
    }
}