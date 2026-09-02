Shape circle = new Circle(5);
Shape rectangle = new Rectangle(4, 6);

Console.WriteLine($"Circle area: {circle.GetArea():F2}");
Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");

abstract class Shape
{
	public abstract double GetArea();
}

class Circle : Shape
{
	private readonly double radius;

	public Circle(double radius)
	{
		this.radius = radius;
	}

	public override double GetArea()
	{
		return Math.PI * radius * radius;
	}
}

class Rectangle : Shape
{
	private readonly double length;
	private readonly double width;

	public Rectangle(double length, double width)
	{
		this.length = length;
		this.width = width;
	}

	public override double GetArea()
	{
		return length * width;
	}
}
