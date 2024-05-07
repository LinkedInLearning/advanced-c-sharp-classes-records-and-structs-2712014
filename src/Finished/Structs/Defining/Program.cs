// Example file for C#: Records, Classes, and Structs by Joe Marini
// Defining and initializing structs

// Instantiate a new instance of the Rectangle - note that you have to initialize
// all of the instance variables before you can use the struct
Rectangle r1;
r1.Top = 0;
r1.Left = 0;
r1.Right = 100;
r1.Bottom = 200;
Console.WriteLine($"Area: {(r1.Bottom - r1.Top) * (r1.Right - r1.Left)}");

// Change some values
r1.Top = 50;
r1.Left = 50;
Console.WriteLine($"Area: {(r1.Bottom - r1.Top) * (r1.Right - r1.Left)}");

Rectangle r2 = new();
Console.WriteLine($"Area: {(r2.Bottom - r2.Top) * (r2.Right - r2.Left)}");

// define a struct to represent a Rectangle
struct Rectangle {
    public int Top;
    public int Left;
    public int Bottom;
    public int Right;
}
