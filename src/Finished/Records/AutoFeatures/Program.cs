// Advanced C#: Classes, Records, and Structs by Joe Marini
// Automatic Records Features Example
using System.Text;


// Create a few records
var r1 = new Rectangle(0, 0, 10, 20);
var r2 = new Rectangle(0, 0, 10, 20);
var r3 = new Rectangle(0, 0, 30, 30);


// Value-based Equality Checking
Console.WriteLine($"r1 == r2: {r1 == r2}");
Console.WriteLine($"r2 == r3: {r1 == r3}");
Console.WriteLine($"r1 != r3: {r2 != r3}");

// Synthesized GetHashCode()
Console.WriteLine($"Hash code: {r1.GetHashCode()}");

// Built-in Formatting (ToString and PrintMembers)
Console.WriteLine($"{r1}");

// Define a Record type
public record Rectangle(int Top, int Left, int Right, int Bottom) {
    protected virtual bool PrintMembers(StringBuilder stringBuilder)
    {
        stringBuilder.Append($"Top, Left: {Top},{Left} Bottom, Right: {Bottom},{Right}");
        return true;
    }
}
