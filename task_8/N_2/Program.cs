namespace N_2
{
    class Program
    {
        public enum EmployeePosition
        {
            Manager = 160,
            Developer = 180,
            Designer = 150,
            Analyst = 170
        }

        static void Main(string[] args)
        {
            EmployeePosition position = EmployeePosition.Manager;

            Console.WriteLine($"Работник на должности {position} должен отработать {(int)position} часов");
        }
    }
}
