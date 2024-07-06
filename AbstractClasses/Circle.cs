namespace Assignment2.AbstractClasses;

public abstract class Circle : Shape
{
   double radius;
   public override double GetArea()
   {
      return Math.PI * Math.Pow(radius, 2);
   }
}