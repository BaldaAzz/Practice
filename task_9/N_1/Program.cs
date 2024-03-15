namespace N_1
{
    interface Ix
    {
        void IxF0(double x);
        void IxF1();
    }

    interface Iy
    {
        void F0(double x);
        void F1();

    }

    interface Iz
    {
        void F0(double x);
        void F1();
    }

    class TestClass: Ix, Iy, Iz
    {
        private int xVal = 125;

        public void IxF0(double x) => Console.WriteLine(Math.Log(x));
        public void IxF1() => Console.WriteLine(Math.Log(xVal));

        // Неявная реализация интерфейса Iy
        public void F0(double x) => Console.WriteLine(2/x);
        public void F1() => Console.WriteLine(2/xVal);

        // Явная реализация интерфейса Iz
        void Iz.F0(double x) => Console.WriteLine(Math.Pow(x, 3));
        void Iz.F1() => Console.WriteLine(Math.Pow(xVal, 3));
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            TestClass x = new TestClass();

            x.IxF0(4);
            x.IxF1();

            // Неявное приведения к типу интерфейсов Iy и Iz
            x.F0(4);
            x.F1();
            
            // Явное приведение к типу интрефейса Iz
            (x as Iz).F0(4);
            (x as Iz).F1();
        }
    }
}