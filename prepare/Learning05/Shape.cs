using System;
using System.Drawing;

public abstract class Shape
{
    private string _color;
    // protected int side;

    public Shape(string color)
    {
        
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color ;
    }


    public abstract double GetArea();
    // {
    //     return -1;
    // }


}