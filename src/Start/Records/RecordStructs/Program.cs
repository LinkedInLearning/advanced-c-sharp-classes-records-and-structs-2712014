// Advanced C#: Classes, Records, and Structs by Joe Marini
// Defining Record Structs Example
using System.Text;


var r1 = new Rectangle(0, 0, 10, 20);
var r2 = new Rectangle(0, 0, 10, 20);
var r3 = new Rectangle(0, 0, 30, 30);

// Automatic Formatting
Console.WriteLine($"{r1}");

// Value-based Equality Checking
Console.WriteLine($"r1 == r2: {r1 == r2}");
Console.WriteLine($"r2 == r3: {r1 == r3}");
Console.WriteLine($"r1 != r3: {r2 != r3}");

// Simple Declaration and custom output formatting
public record Rectangle(int Top, int Left, int Right, int Bottom);
