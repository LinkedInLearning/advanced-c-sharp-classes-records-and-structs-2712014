// Example file for C#: Records, Classes, and Structs by Joe Marini
// Creating immutable structs

// Instantiate a new instance of the Rectangle
Rectangle r1 = new(){Top=0,Right=20,Left=0,Bottom=30};
Console.WriteLine($"{r1}");

// Create another rectangle but with only two parameters
Rectangle r2 = new(){Right=10, Bottom=10};
Console.WriteLine($"{r2}");

// Try to change a property (causes an error on readonly struct)
r2.Top = 5;
Console.WriteLine($"{r2}");

// Use non-destructive mutation to modify specific values:


// The .NET DateTime is actually a struct


// define a struct to represent a Rectangle
// - Use the "readonly" modifier to indicate to the compiler that it is immutable
// - Ensure that all property accessors are "get" or "init"
// - Other members are private 
struct Rectangle {
    public int Top {get; set;}
    public int Left {get; set;}
    public int Bottom {get; set;}
    public int Right {get; set;}

    public Rectangle(int t, int l, int r, int b) {
        Top = t;
        Left = l;
        Right = r;
        Bottom = b;
    }

    public int Area {
        get => (Bottom - Top) * (Right - Left);
    }

    public override string ToString() => $"Rectangle Area:{Area},Top:{Top},Left:{Left},Right:{Right},Bottom:{Bottom}";
}
