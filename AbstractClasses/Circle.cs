namespace Assignment2.AbstractClasses;

public class Circle : Shape
{
   public double Radius { get; set; } = 0;
   public override double GetArea()
   {
      return Math.PI * Math.Pow(Radius, 2);
   }
}