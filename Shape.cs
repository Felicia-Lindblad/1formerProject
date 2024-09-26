namespace _1formerProject
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Square : Shape
    {
        public double side;
        public override double CalculateArea()
        {
            return side*side;
        }
    }

    public class Rectangle : Shape
    {
        public double side1;
        public double side2;
        public override double CalculateArea()
        {
            return side1 * side2;
        }
    }

    public class Cercle : Shape
    {
        public double radius;
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

}
