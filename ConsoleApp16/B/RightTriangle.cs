namespace HW_W5_01.B;

sealed public class RightTriangle : Triangle // قائم الزاویه
{
    public RightTriangle(decimal dbase_, decimal dheight) : base(dbase_, dheight)
    {
    }

    public RightTriangle(int base_, int height) : this(dbase_: base_,height)
    {
    }

    public override decimal Area()
    {
        Console.WriteLine("In RightTriangle!");
        return Base * Height / 2;
        return base.Area(); //The same!
    }
    public override void Area(decimal base_, decimal height)
    {
        Console.WriteLine("In RightTriangle!");
        Console.WriteLine($"Area is : {base_ * height / 2}");
        //base.Area(base_, height); //The same!
    }

}