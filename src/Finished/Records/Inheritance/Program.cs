// Advanced C#: Classes, Records, and Structs by Joe Marini
// Records Inheritance Example

var r1 = new Rectangle(5,0,0,100,200);
Console.WriteLine($"{r1}");

var c1 = new Circle(10, 20);
Console.WriteLine($"{c1}");

// Equality depends upon the run-time type
Shape r2 = new Rectangle(1, 5, 5, 10, 10);
Shape c2 = new Circle(1, 5);
Console.WriteLine($"{r2 == c2}");

// Define a base record for a common property
public abstract record Shape(int Border);

// Define two records that inherit from Shape
public record Rectangle(int Border, int Top, int Left, int Right, int Bottom)
    : Shape(Border);
public record Circle(int Border, int Radius)
    : Shape(Border);
