namespace HW_W5_01.B;

public class Triangle
{
    protected decimal Base { get; set; } //قاعده
    protected decimal Height { get; set; }


    public Triangle(decimal dbase_, decimal dheight)
    {
        Base = dbase_;
        Height = dheight;
    }
    public Triangle(int base_, int height) : this(dbase_: base_, dheight: height)
    {

    }
    public virtual decimal Area()
    {
        return Base * Height / 2;
    }
    public virtual void Area(decimal base_ , decimal height)
    {
        Console.WriteLine($"Area is : {base_ * height / 2}");
    }
    
    
}