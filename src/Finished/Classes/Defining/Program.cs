// Example file for C#: Records, Classes, and Structs by Joe Marini
// Class definition

var r1 = new Rectangle(0, 0, 100, 200);
Console.WriteLine($"{r1}");
r1.Resize(50,50);
Console.WriteLine($"{r1}");

var c1 = new Circle(10);
Console.WriteLine($"{c1}");
c1.Resize(10);
Console.WriteLine($"{c1}");


public class Rectangle {
    // internal class member to hold the ID of an instance
    private string _id;

    // Constructor to create the class
    public Rectangle(int T, int R, int L, int B) {
        Top = T;
        Right = R;
        Left = L;
        Bottom = B;

        _id = Guid.NewGuid().ToString();
    }

    // Classes can expose Properties that can be get, set, or init
    // Immutability requires init-only properties
    public int Top {
        get; set;
    }

    public int Right {
        get; set;
    }

    public int Left {
        get; set;
    }

    public int Bottom {
        get; set;
    }

    public string ID => _id;

    // Classes can override superclass methods
    public override string ToString() => $"Rectangle Top:{Top}, Left:{Left}, Right:{Right}, Bottom:{Bottom}, ID:{ID}";

    // Classes typically contain logic and behavior
    public void Resize(int Width, int Height) {
        Right += Width;
        Bottom += Height;
    }
}

public class Circle {
    // internal class member to hold the ID of an instance
    private string _id;

    public Circle(int radius) {
        Radius = radius;
        _id = Guid.NewGuid().ToString();
    }

    public int Radius {
        get; set;
    }

    public string ID => _id;

    public float Area {
        get => (float)(Math.PI * (Radius * Radius));
    }

    public override string ToString() => $"Circle Radius:{Radius}, Area:{Area}, ID:{ID}";

    public void Resize(int Size) {
        Radius += Size;
    }
}
