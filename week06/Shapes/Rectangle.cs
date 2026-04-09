using System;

class Rectangule :Shape
{
    double _Width;
    double _length;

    public Rectangule(string color, double width, double length)
    {
        _color = color;
        _Width = width;
        _length = length;
    }
    public override double GetArea()
    {
        return _length * _Width;
    }
}