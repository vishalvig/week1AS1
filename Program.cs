// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;
int numberOfShapes = 10;

// Create an array of Shape objects
Shape[] shapes = new Shape[numberOfShapes];

for (int i = 0; i < numberOfShapes; i++)
{
    shapes[i] = new Shape(); // Create a new Shape
    ShapeColourHelper.SetRandomColour(shapes[i]); // Assign a random color
    
}

// Print out each shape with its color
Console.WriteLine("Shapes and their colors:");
for (int i = 0; i < shapes.Length; i++)
{
    Console.WriteLine($"Shape {i + 1} Colour: {shapes[i].Colour}");
}


var square = new Square(9);

try
{


    square.SetArea(2);


    Console.WriteLine("The area is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




var circle = new Circle(2);

ShapeColourHelper.SetRandomColour(circle);


Console.WriteLine("The area of circle is " + Math.Round(circle.GetArea(),2));
Console.WriteLine(circle.Colour);


ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);


Console.ReadLine();




