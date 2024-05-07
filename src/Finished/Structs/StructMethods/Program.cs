// Example file for C#: Records, Classes, and Structs by Joe Marini
// Defining members within structs


// Create the rectangle
Rectangle r = new(0, 0, 50, 60);

// Access the property
Console.WriteLine($"{r.Area}");

// Invoke the ToString() method
Console.WriteLine($"{r}");

// define a struct to represent a Rectangle
// struct members can be public, internal, or private
struct Rectangle {
    int Top;
    int Left;
    int Bottom;
    int Right;

    // Provide a constructor to support object initializer
    public Rectangle(int t, int l, int r, int b) {
        Top = t;
        Left = l;
        Right = r;
        Bottom = b;
    }

    // Define a property
    public int Area {
        get => (Bottom - Top) * (Right - Left);
    }

    // Override the ToString method from the base object
    public override string ToString() => $"Rectangle Area:{Area},Top:{Top},Left:{Left},Right:{Right},Bottom:{Bottom}";
}
