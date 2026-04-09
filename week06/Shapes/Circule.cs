using System;

class Circule :Shape
{
    double _radius;

    public Circule(string color, double radius)
    {
        _color = color;
        _radius = radius;
    }
    public override double GetArea()
    {
        return (_radius * _radius) *  Math.PI;
    }
}