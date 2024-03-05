class Item
{
    public string productName;
    public int count; 

    public Item(string productName, int count)
    {
        this.productName = productName;
        this.count = count;
    }

    public string Info()
    {
        return $"Название: {productName} \nКоличество: {count}";
    }
}

class Toy: Item
{
    public string type;

    public Toy(string productName, int count, string type): base(productName, count)
    {
        this.type = type;
    }

    public string Info()
    {
        return $"Название: {this.productName} \nКоличество: {this.count} \nТип: {this.type}";
    }
}

class Product: Item
{
    public DateTime productionDate;

    public Product(string productName, int count, DateTime productionDate): base(productName, count)
    {
        this.productionDate = productionDate;
    }

    public string Info()
    {
        return $"Название: {this.productName} \nКоличество: {this.count} \nДата производства: {this.productionDate}";
    }
    
}

class MilkProduct: Product
{
    public DateTime expiryDate;

    public MilkProduct(string productName, int count, DateTime productionDate, DateTime expiryDate): base(productName, count, productionDate)
    {
        this.expiryDate = expiryDate;
    }

    public bool IsExpired()
    {
        return DateTime.Now > this.expiryDate;
    }

    public string Info()
    {
        return $"Название: {this.productName} \nКоличество: {this.count} \nДата производства: {this.productionDate} \nГоден до: {this.expiryDate}";
    }   
    
}

class Program
{
    static void Main(string[] args)
    {
        Item i = new Item("Что-то", 1);
        Console.WriteLine(i.Info());

        Toy t = new Toy("Машинка", 1, "Крутая");
        Console.WriteLine(t.Info());

        DateTime productionDate = new DateTime(2024, 1, 15);
        DateTime expiryDate = new DateTime(2024, 2, 11);

        MilkProduct mp = new MilkProduct("Творог", 1, productionDate, expiryDate);
        Console.WriteLine(mp.Info());
        Console.WriteLine(mp.IsExpired());

    }
}
