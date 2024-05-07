// Example file for C#: Records, Classes, and Structs by Joe Marini
// Creating immutable structs

// Instantiate a new instance of the Rectangle
Rectangle r1 = new(){Top=0,Right=20,Left=0,Bottom=30};
Console.WriteLine($"{r1}");

// Create another rectangle but with only two parameters
Rectangle r2 = new(){Right=10, Bottom=10};
Console.WriteLine($"{r2}");

// Try to change a property (causes an error on readonly struct)
// r2.Top = 5;
// Console.WriteLine($"{r2}");

// Use non-destructive mutation to modify specific values:
Rectangle r3 = r2 with {Top = 5, Left = 2};
Console.WriteLine($"{r3}");

// The .NET DateTime is actually a struct
var dt = new DateTime(2030,4,1);
Console.WriteLine($"{dt}");
var newdt = dt.AddDays(15);
Console.WriteLine($"{newdt}");

// define a struct to represent a Rectangle
// - Use the "readonly" modifier to indicate to the compiler that it is immutable
// - Ensure that all property accessors are "get" or "init"
// - Other members are private 
readonly struct Rectangle {
    public int Top {get; init;}
    public int Left {get; init;}
    public int Bottom {get; init;}
    public int Right {get; init;}

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
