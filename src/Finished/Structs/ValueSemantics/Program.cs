// Example file for C#: Records, Classes, and Structs by Joe Marini
// Understanding struct value semantics

Rectangle r1, r2;

r1.Top = 0;
r1.Left = 0;
r1.Right = 100;
r1.Bottom = 200;

r2.Top = 0;
r2.Left = 0;
r2.Right = 100;
r2.Bottom = 200;

// Equality comparison is performed on struct values
Console.WriteLine($"{r1.Equals(r2)}");

// Objects do not refer to the same memory block
Rectangle r3 = r2;
r3.Bottom = 20;
Console.WriteLine($"{r2.Bottom}, {r3.Bottom}");

// structs cannot be declared as constants
// const Rectangle r3 = new();

// define a struct to represent a Rectangle
struct Rectangle {
    public int Top;
    public int Left;
    public int Bottom;
    public int Right;
}
