namespace LiskovSubstitutionExample
{
    public class Rectangle : Shape
    {
        public double With { get; set; }
        public double Height { get; set; }

        public Rectangle(double with, double height)
        {
            With = with;
            Height = height;
        }

        public override double CalculateArea() => With * Height;
        
    }
}
