using System;

class Vector
{
    public string Name { get; set; }
    public double Length { get; set; }

    public Vector(string name, double length)
    {
        Name = name;
        Length = length;
    }

    public virtual void Calculate()
    {
        // Виртуальная функция для расчета чего-то в базовом классе
        Console.WriteLine($"Расчет для вектора {Name} с длиной {Length}");
    }

    public virtual void PrintResult()
    {
        // Виртуальная функция для вывода результатов
        Console.WriteLine($"Вектор {Name}: Длина = {Length}");
    }
}

class TwoDimensionalVector : Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public TwoDimensionalVector(string name, double length, double x, double y)
        : base(name, length)
    {
        X = x;
        Y = y;
    }

    public override void Calculate()
    {
        base.Calculate();
        // Дополнительные расчеты для двумерного вектора
        Console.WriteLine($"Компоненты: X = {X}, Y = {Y}");
    }
}

class ThreeDimensionalVector : Vector
{
    public double Dimension { get; set; }

    public ThreeDimensionalVector(string name, double length, double dimension)
        : base(name, length)
    {
        Dimension = dimension;
    }

    public override void Calculate()
    {
        base.Calculate();
        // Дополнительные расчеты для трехмерного вектора
        Console.WriteLine($"Размерность: {Dimension}");
    }
}

class Program
{
    static void Main()
    {
        Vector[] vectors = new Vector[]
        {
            new TwoDimensionalVector("AB", 5.0, 3.0, 4.0),
            new ThreeDimensionalVector("XYZ", 7.0, 3.0),
        };

        foreach (var vector in vectors)
        {
            vector.Calculate();
            vector.PrintResult();
            Console.WriteLine();
        }
    }
}
