

using LiskovSubstitutionExample;

Shape rectangle = new Rectangle(6, 10);
Shape square = new Square(8);

Console.WriteLine($"Área de rectángulo: {rectangle.CalculateArea()}");
Console.WriteLine($"Área de cuadrado: {square.CalculateArea()}");
