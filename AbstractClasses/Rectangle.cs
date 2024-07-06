namespace Assignment2.AbstractClasses;

public class Rectangle : Shape
{
   public double Length { get; set; } = 0;
   public double Width { get; set; } = 0;
   public override double GetArea()
   {  
      return Length * Width;
   }
}