using System;


public class Fractions
{
    private int _top;
    private int _bottom;

    public void SetFraction()
    {
        _bottom = 1;
        _top = 1;
    }
    public void SetFraction(int number)
    {
        _bottom = 1;
        _top = number;
    
    }
    public void SetFraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }


    public int GetTop()
    {
        return (_top);    
    }
    public void SetTop(int number)
    {
        _top = number;
    }
    public int GetBottom()
    {
        return (_bottom);    
    }
    public void SetBottom(int number)
    {
        _bottom = number;
    }

    public string GetFractionString()
    {
        string _sTop = _top.ToString();
        string _sBottom = _bottom.ToString();

        Console.WriteLine($"{_sTop}/{_sBottom}");
        return ($"{_sTop}/{_sBottom}");
    }

    public double GetDecimalvalue()
    {
        double _decimal = (double)_top / _bottom;

        Console.WriteLine(_decimal);
        return (_decimal);

    }
}