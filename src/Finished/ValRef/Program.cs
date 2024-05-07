// Example file for C#: Records, Classes, and Structs by Joe Marini
// Simple demonstration of value and reference types


int x = 10;

void ModifyTheValType(int theVal) {
    theVal += 10;
    Console.WriteLine($"Value: {theVal}");
}

Console.WriteLine($"x: {x}");
ModifyTheValType(x);
Console.WriteLine($"x: {x}");

// ---------------------------------------------------

Person p1 = new();
p1.Name = "John Doe";
Person p2 = p1;

void ModifyTheRefType(Person person) {
    person.Name = "Jane Doh";
}

Console.WriteLine($"p1: {p1.Name}");
Console.WriteLine($"P2: {p2.Name}");
ModifyTheRefType(p2);
Console.WriteLine($"p1: {p1.Name}");
Console.WriteLine($"p2: {p2.Name}");

public class Person {
    public string Name;
}
