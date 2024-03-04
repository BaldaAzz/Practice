

class Month
{
    private int currentDay;
    private int numOfMonth;
    public int daysUntilTheEndOfTheMounth;

    public int DaysUntilTheEndOfTheMounth
    {
        get {return daysUntilTheEndOfTheMounth;}
    }

    public Month(int currentDay, int numOfMonth)
    {
        this.currentDay = currentDay;
        this.numOfMonth = numOfMonth;
        this.daysUntilTheEndOfTheMounth = CalculateDaysUntilTheEndOfTheMounth();
    }

    private int CalculateDaysUntilTheEndOfTheMounth()
    {
        if(numOfMonth == 1 || numOfMonth == 3 || numOfMonth == 5 || numOfMonth == 7 || numOfMonth == 8 || numOfMonth == 10 || numOfMonth == 12)
        { 
            return 31 - this.currentDay;
        }
        if(numOfMonth == 4 || numOfMonth == 6 || numOfMonth == 9 || numOfMonth == 11 )
        {
            return 30 - this.currentDay;
        }
        if (numOfMonth == 2)
        {
            return 28 - this.currentDay;
        }

        throw new Exception("Неверный месяц");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Month m = new Month(27, 2);
        Console.WriteLine($"Оталось дней: {m.DaysUntilTheEndOfTheMounth}");
    }
}