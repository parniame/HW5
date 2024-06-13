using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace HW_W5_01.B;

sealed public class equilateralTriangle : Triangle // متساوی الساقین
{
    public decimal Side { get; set; }

    private static decimal HeightCalculator(decimal side)
    {
        return (decimal)Math.Sqrt(3) * side/2; 
    }
    private  decimal HeightCalculator()
    {
        return (decimal)Math.Sqrt(3) * Side / 2;
    }
    public equilateralTriangle(decimal dside) : base(dside, HeightCalculator( dside))
    {
        Side = dside;
    }

    public equilateralTriangle(int side) : this(dside: side)
    {
        
    }

    public override decimal Area() //The area of an equilateral triangle is √3 a2/ 4. 
    {
        Console.WriteLine("In equilateralTriangle!");
        return ((decimal)Math.Sqrt(3) / 4 * Side*Side);
        //return base.Area(); //THe same!
    }

    public override void Area(decimal base_, decimal height)
    {
        Console.WriteLine("In equilateralTriangle!");
        Console.WriteLine($"Area : {(decimal)(Math.Sqrt(3) / 4 * Math.Pow((double)Side, 2))}");
        //base.Area(base_, height); //The Same!
    }
}