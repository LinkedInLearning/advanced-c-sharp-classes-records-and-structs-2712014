// Advanced C#: Classes, Records, and Structs by Joe Marini
// Records Inheritance Example

var r1 = new Rectangle(5,0,0,100,200);
Console.WriteLine($"{r1}");

var c1 = new Circle(10, 20);
Console.WriteLine($"{c1}");

// Equality depends upon the run-time type


// Define a base record for a common property


// Define two records that inherit from Shape
public record Rectangle(int Border, int Top, int Left, int Right, int Bottom);
public record Circle(int Border, int Radius);
