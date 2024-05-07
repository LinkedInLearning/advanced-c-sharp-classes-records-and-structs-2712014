// Example file for C#: Records, Classes, and Structs by Joe Marini
// Equality comparison in class objects


Circle c1 = new Circle(5);
Circle c2 = new Circle(5);
Circle c3 = null;
Circle c4 = new Circle(10);
Circle c5 = null;

// Default equality checking compares references, not values
// Implementing the Equals operator overrides can resolve this
Console.WriteLine($"{c1 == c2}");
Console.WriteLine($"{c3 == c5}");
Console.WriteLine($"{c4 == c2}");
Console.WriteLine($"{c4 != c2}");

// Test using Equals methods
Console.WriteLine($"{object.Equals(c1, c2)}");
Console.WriteLine($"{c1.Equals(c2)}");


// 1. Define a class that implements the IEquatable interface
public class Circle {
    public Circle(int radius) {
        Radius = radius;
    }

    public int Radius {
        get; set;
    }

    public float Area {
        get => (float)(Math.PI * (Radius * Radius));
    }

    public override string ToString() => $"Circle Radius:{Radius}, Area:{Area}";

    public void Resize(int Size) {
        Radius += Size;
    }

    // Checking value equality requires overriding Equals and GetHashCode, along with == and !=
    // 2. Override the Equals method on object


    // 3. Implement an Equals function for this class


    // 4. Override GetHashCode


    // 5. Implement the == operator


    // 6. Implement the != operator

}
