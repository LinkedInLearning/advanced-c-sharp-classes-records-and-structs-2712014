// Example file for C#: Records, Classes, and Structs by Joe Marini
// Class-based inheritance


var r1 = new Rectangle(5, 0, 100, 0, 200);
Console.WriteLine($"{r1}");

var c1 = new Circle(3, 10);
Console.WriteLine($"{c1}");

var s1 = new Shape(5);

// Base classes let us centralize behavior in one place
// Making them abstract prevents instantiation
public class Shape {
    protected string _id;

    public Shape (int BorderSize) {
        BorderSize = BorderSize;
        _id = Guid.NewGuid().ToString();
    }

    public string ID => _id;

    public virtual float Area { get => 0; }

    public int BorderSize {
        get; set;
    }
}

public class Rectangle : Shape {
    public Rectangle(int BS, int T, int R, int L, int B) : base(BS) {
        Top = T;
        Right = R;
        Left = L;
        Bottom = B;
    }
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

    public override string ToString() => $"Rectangle Top:{Top}, Left:{Left}, Right:{Right}, Bottom:{Bottom}, Area: {Area}, ID:{ID}";
}

// Sealing a class prevents the class from being derived from
public class Circle : Shape {
    public Circle(int BS, int radius) : base(BS) {
        Radius = radius;
    }

    public int Radius {
        get; set;
    }

    public override float Area {
        get => (float)(Math.PI * (Radius * Radius));
    }

    public override string ToString() => $"Circle Radius:{Radius}, Area:{Area}, ID:{ID}";
}

public class BetterCircle : Circle {
    public BetterCircle(int b, int r):base(b, r) {}
}
