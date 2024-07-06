using Assignment2.AbstractClasses;
using Assignment2.Inheritance;

// Inheritance 
Animal animal = new Animal();
animal.MakeSound();

Dog dog = new Dog();
dog.MakeSound();

Cat cat = new Cat();
cat.MakeSound();


// Abstract classes
Circle circle = new()
{
   Radius = 7,
};
Console.WriteLine($"Area of circle : {circle.GetArea():f2}");

Rectangle rectangle = new()
{
   Length = 10,
   Width = 5,
};

Console.WriteLine($"Area of rectangle : {rectangle.GetArea():f2}");

