class Polynomial
{
    public double a;
    public double b;
    public double c;

    public Polynomial(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Calculate(double x)
    {
        return this.a * Math.Pow(x, 2) + this.b * x + this.c;
    }

    public static Polynomial operator + (Polynomial pOne, Polynomial pTwo)
    {
        return new Polynomial(pOne.a + pTwo.a, pOne.b + pTwo.b, pOne.c + pTwo.c);
    }

    public static Polynomial operator - (Polynomial pOne, Polynomial pTwo)
    {
        return new Polynomial(pOne.a - pTwo.a, pOne.b - pTwo.b, pOne.c - pTwo.c);
    }

    public static Polynomial operator * (Polynomial pOne, Polynomial pTwo)
    {   
        double newA = pOne.a * pTwo.a;
        double newB = pOne.a * pTwo.b + pOne.b * pTwo.a;
        double newC = pOne.a * pTwo.c + pOne.b * pTwo.b + pOne.c * pTwo.a;

        return new Polynomial(newA, newB, newC);
    }

    public void Print()
    {
        Console.WriteLine($"{this.a}x^2 + {this.b}x + {this.c}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Polynomial poly1 = new Polynomial(2, -3, 4);
        Polynomial poly2 = new Polynomial(-1, 5, -2);

        double result = poly1.Calculate(3);
        Console.WriteLine($"Значение полинома для x = 3: {result}");

        Polynomial sum = poly1 + poly2;
        sum.Print();

        Polynomial diff = poly1 - poly2;
        diff.Print();

        Polynomial product = poly1 * poly2;
        product.Print();
    }
}
