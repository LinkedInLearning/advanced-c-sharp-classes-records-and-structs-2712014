// Advanced C#: Classes, Records, and Structs by Joe Marini
// Immutability of Records Example


// Create a new instance of a record
var r1 = new Rectangle(0,0,100,200);
Console.WriteLine($"{r1}");

var c1 = new Circle() {Radius = 20};
Console.WriteLine($"{c1}");

// Try to set a property of a record
c1.Radius = 10;
Console.WriteLine($"{c1}");

// Use the "with" expression to create a new record based on another
var r2 = r1 with {
    Top = r1.Top + 5,
    Bottom = r1.Bottom + 20
};
Console.WriteLine($"{r2}");

// Create a non-mutated copy of an existing Rectangle
var r3 = r1 with {};
Console.WriteLine($"{r3}");

// Define a record for Rectangle
public record Rectangle(int Top, int Left, int Right, int Bottom);

// Records can be defined as if they are regular classes
// You can specify a "setter" property to make them mutable, but not advisable
public record Circle() {
    public int Radius { get; set; } 
}
