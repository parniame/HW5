namespace HW_W5_01.A;

public class Square : Shape
{
    public float Side { get;private set; }

    public Square(float side)
    {
        Side = side;
    }
    public override float Area()
    {
        Console.WriteLine("In Square");
        return (float)Math.Pow(Side, 2);
    }

    public override float Circumtance()
    {
        Console.WriteLine("In Square");
        return Side * 4;
    }

}