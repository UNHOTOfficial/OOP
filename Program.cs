using System;

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculateCircumference();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double CalculateArea()
    {
        return side * side;
    }

    public override double CalculateCircumference()
    {
        return 4 * side;
    }
}

public class Triangle : Shape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double CalculateCircumference()
    {
        return side1 + side2 + side3;
    }
}

public class Trapezius : Shape
{
    private double base1;
    private double base2;
    private double height;
    private int districtCount;

    public Trapezius(double base1, double base2, double height, int districtCount)
    {
        this.base1 = base1;
        this.base2 = base2;
        this.height = height;
        this.districtCount = districtCount;
    }

    public override double CalculateArea()
    {
        return ((base1 + base2) / 2) * height;
    }

    public override double CalculateCircumference()
    {
        return base1 + base2 + (2 * districtCount * height);
    }
}

public class Oval : Shape
{
    private double semiMajorAxis;
    private double semiMinorAxis;

    public Oval(double semiMajorAxis, double semiMinorAxis)
    {
        this.semiMajorAxis = semiMajorAxis;
        this.semiMinorAxis = semiMinorAxis;
    }

    public override double CalculateArea()
    {
        return Math.PI * semiMajorAxis * semiMinorAxis;
    }

    public override double CalculateCircumference()
    {
        double a = semiMajorAxis;
        double b = semiMinorAxis;
        return 2 * Math.PI * Math.Sqrt((a * a + b * b) / 2);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the shape number: ");
        Console.WriteLine("1 - Circle");
        Console.WriteLine("2 - Square");
        Console.WriteLine("3 - Triangle");
        Console.WriteLine("4 - Trapezius");
        Console.WriteLine("5 - Oval");

        int shapeNumber = int.Parse(Console.ReadLine());

        switch (shapeNumber)
        {
            case 1:
                Console.WriteLine("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine("Enter 1 to calculate the area or 2 to calculate the circumference: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                    Console.WriteLine("Area of the circle: " + circle.CalculateArea());
                else if (option == 2)
                    Console.WriteLine("Circumference of the circle: " + circle.CalculateCircumference());
                break;
            case 2:
                Console.WriteLine("Enter the side length of the square: ");
                double side = double.Parse(Console.ReadLine());
                Square square = new Square(side);
                Console.WriteLine("Enter 1 to calculate the area or 2 to calculate the circumference: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                    Console.WriteLine("Area of the square: " + square.CalculateArea());
                else if (option == 2)
                    Console.WriteLine("Circumference of the square: " + square.CalculateCircumference());
                break;
            case 3:
                Console.WriteLine("Enter the lengths of the triangle's sides: ");
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double side3 = double.Parse(Console.ReadLine());
                Triangle triangle = new Triangle(side1, side2, side3);
                Console.WriteLine("Enter 1 to calculate the area or 2 to calculate the circumference: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                    Console.WriteLine("Area of the triangle: " + triangle.CalculateArea());
                else if (option == 2)
                    Console.WriteLine("Circumference of the triangle: " + triangle.CalculateCircumference());
                break;
            case 4:
                Console.WriteLine("Enter the lengths of the bases and the height of the trapezius: ");
                double base1 = double.Parse(Console.ReadLine());
                double base2 = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the district count of the trapezius: ");
                int districtCount = int.Parse(Console.ReadLine());
                Trapezius trapezius = new Trapezius(base1, base2, height, districtCount);
                Console.WriteLine("Enter 1 to calculate the area or 2 to calculate the circumference: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                    Console.WriteLine("Area of the trapezius: " + trapezius.CalculateArea());
                else if (option == 2)
                    Console.WriteLine("Circumference of the trapezius: " + trapezius.CalculateCircumference());
                break;
            case 5:
                Console.WriteLine("Enter the semi-major and semi-minor axes of the oval: ");
                double semiMajorAxis = double.Parse(Console.ReadLine());
                double semiMinorAxis = double.Parse(Console.ReadLine());
                Oval oval = new Oval(semiMajorAxis, semiMinorAxis);
                Console.WriteLine("Enter 1 to calculate the area or 2 to calculate the circumference: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                    Console.WriteLine("Area of the oval: " + oval.CalculateArea());
                else if (option == 2)
                    Console.WriteLine("Circumference of the oval: " + oval.CalculateCircumference());
                break;
            case 6:
                Console.WriteLine("Enter the shape district count: ");
                int districtCountShape = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1 to calculate the area or 2 to calculate the circumference: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                    Console.WriteLine("Area of the shape district: " + CalculateDistrictArea(districtCountShape));
                else if (option == 2)
                    Console.WriteLine("Circumference of the shape district: " + CalculateDistrictCircumference(districtCountShape));
                break;
            default:
                Console.WriteLine("Invalid shape number!");
                break;
        }
    }

    public static double CalculateDistrictArea(int districtCount)
    {
        // Your implementation for calculating the district area
        // Add your code here
        return 0;
    }

    public static double CalculateDistrictCircumference(int districtCount)
    {
        // Your implementation for calculating the district circumference
        // Add your code here
        return 0;
    }
}
