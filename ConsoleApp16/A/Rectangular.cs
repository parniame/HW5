namespace HW_W5_01.A;

public class Rectangular : Shape
{
    public float Height { get; set; }

    public float Width { get; set; }

    public Rectangular(float height, float width)
    {
        Height = height;
        Width = width;
    }
    public override float Area()
    {
        Console.WriteLine("In Rectangular !");
        return Height * Width;
    }

    public override float Circumtance()
    {
        Console.WriteLine("In Rectangular !");
        return (Height + Width) * 2;
    }

}