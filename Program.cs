namespace _1formerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            Console.WriteLine("Write the lenght of the squares side in cm:");
            square.side = Convert.ToDouble(Console.ReadLine());

            double squareArea = square.CalculateArea();
            Console.WriteLine($"Area of the square is {squareArea} cm.");

            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Write the lenght of the rectangle in cm here:");
            rectangle.side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write the height of the rectangle here:");
            rectangle.side2 = Convert.ToDouble(Console.ReadLine());

            double rectangleArea = rectangle.CalculateArea();
            Console.WriteLine($"Area of the rectangle is {rectangleArea} cm.");

            Cercle cercle = new Cercle();

            Console.WriteLine("Write the lenght of the cercles radie in cm:");
            cercle.radius = Convert.ToDouble(Console.ReadLine());

            double cercleArea = cercle.CalculateArea();
            Console.WriteLine($"Area of the cercle is {cercleArea} cm.");
        }
    }
}
