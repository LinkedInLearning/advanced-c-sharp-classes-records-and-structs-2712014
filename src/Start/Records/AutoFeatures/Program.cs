// Advanced C#: Classes, Records, and Structs by Joe Marini
// Automatic Records Features Example
using System.Text;


// Create a few records
var r1 = new Rectangle(0, 0, 10, 20);
var r2 = new Rectangle(0, 0, 10, 20);
var r3 = new Rectangle(0, 0, 30, 30);


// Value-based Equality Checking


// Synthesized GetHashCode()


// Built-in Formatting (ToString and PrintMembers)


// Define a Record type
public record Rectangle(int Top, int Left, int Right, int Bottom);

