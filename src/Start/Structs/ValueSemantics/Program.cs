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


// Objects do not refer to the same memory block


// structs cannot be declared as constants


// define a struct to represent a Rectangle
struct Rectangle {
    public int Top;
    public int Left;
    public int Bottom;
    public int Right;
}
