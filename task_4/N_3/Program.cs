namespace N_3
{
    class Program
    {
        static int AddLeftDigit(int D, int K)
        {
            if (D == 0)
            {
                throw new DivideByZeroException("Попытка деления на ноль.");
            }
            return Convert.ToInt32(Convert.ToString(D) + Convert.ToString(K));
        }

        static void Main(string[] args)
        {
            int K = 123; 
            int D1 = 5; 
            int D2 = 7; 

            K = AddLeftDigit(D1, K);
            Console.WriteLine($"После добавления {D1}: {K}");

            K = AddLeftDigit(D2, K);
            Console.WriteLine($"После добавления {D2}: {K}");
        }   
    }
}