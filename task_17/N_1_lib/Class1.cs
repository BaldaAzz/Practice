namespace Figures;

public abstract class Figure
{
    public abstract double CalculatePerimeter();
    public abstract double CalculateSquare();
}

public class Triangle: Figure
{
    private double sideA, sideB, sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if(this.IsExist(sideA, sideB, sideC)) 
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        else {throw new ArgumentException("Треугольник с данными сторонами не может существовать!");}
    }
    private bool IsExist(double inputSideA, double inputSideB, double inputSideC)
    {
        if((inputSideA + inputSideB < inputSideC) ||
            (inputSideA + inputSideC < inputSideB) ||
            (inputSideB + inputSideC < inputSideA))
        {
            return false;
        }

        return true;
    }
    
    public override double CalculatePerimeter()
    {
        return this.sideA + this.sideB + this.sideC;
    }

    public override double CalculateSquare()
    {
        double semiperimeter =this.CalculatePerimeter() / 2;

        return Math.Sqrt(
            semiperimeter * (semiperimeter - this.sideA) * (semiperimeter - this.sideB) * (semiperimeter - this.sideC));
    }

    public string GetTypeTriangle()
    {
        if(this.sideA == this.sideB && this.sideA == this.sideC)
            return "Равносторонний";

        else if (this.sideA != this.sideB && this.sideA != this.sideC)
            return "Разносторонний";

        return "Равнобедренный";
    }
}

public class Rectangle : Figure
{
    private double width, height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double CalculatePerimeter() => (this.width + this.height) * 2;
    public override double CalculateSquare() => this.width * this.height;
}
