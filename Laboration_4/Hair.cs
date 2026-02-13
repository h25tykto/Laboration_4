using System.ComponentModel.DataAnnotations;

namespace Laboration_4;

public struct Hair
{
    public string Color;
    public string Lenght;
    public Hair(string color, string lenght)
    {
        this.Color = color;
        this.Lenght = lenght;
    }
}