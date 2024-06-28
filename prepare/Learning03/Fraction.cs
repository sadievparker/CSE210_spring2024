
using System;

public class Fraction 
{
    private int _topnum;
    private int _bottom;
    public Fraction()
    {
        _topnum = 1;
        _bottom = -1;
    }
    public Fraction(int wholeNumber)
    {
        _topnum = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topnum = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_topnum}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topnum / (double)_bottom;
    }
    
    
}
