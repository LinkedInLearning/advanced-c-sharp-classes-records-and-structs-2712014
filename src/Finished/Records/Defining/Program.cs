// Advanced C#: Classes, Records, and Structs by Joe Marini
// Defining Records Example


// Create a new instance of a record
var r1 = new Rectangle(0,0,100,200);
Console.WriteLine($"{r1}");

var c1 = new Circle() {Radius = 20};
Console.WriteLine($"{c1}");


// Records can be defined as if they are regular classes
public record Circle() {
    public int Radius { get; init; } 
}

// Defining a record in one line
public record Rectangle(int Top, int Left, int Right, int Bottom);
