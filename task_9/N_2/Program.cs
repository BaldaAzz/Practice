using System;
using System.Collections.Generic;

namespace N_2
{
    class Product : IComparable<Product>
    {
        public string ProductName {get;}
        public string StoreName {get;}
        public decimal PriceRubles {get;}

        public Product(string productName, string storeName, decimal priceRubles)
        {
            this.ProductName = productName;
            this.StoreName = storeName;
            this.PriceRubles = priceRubles;
        }          

        public int CompareTo(Product other)
        {
            return this.PriceRubles.CompareTo(other.PriceRubles);
        }
    }

    class Storege
    {
        private Product[] products;

        public Storege(Product[] products) => this.products = products;

        public void DisplayProductInfo(int index)
        {
            if (index >= 0 && index < products.Length)
            {
                Product product = products[index];
                Console.WriteLine($"Товар: {product.ProductName}");
                Console.WriteLine($"Магазин: {product.StoreName}");
                Console.WriteLine($"Цена: {product.PriceRubles} руб.");
            }
            else
            {
                Console.WriteLine("Товар с таким номером не найден.");
            }
        }

        public void Print()
        {
            foreach (Product pr in products)
            {
                Console.WriteLine($"Название {pr.ProductName}, магазин {pr.StoreName}, цена {pr.PriceRubles}");
            }
        }

        public Storege SortByProductName()
        { 
            return new Storege(products.OrderBy(x => x.ProductName).ToArray());
        }

        public Storege SortByStoreName()
        {
            return new Storege(products.OrderBy(x => x.StoreName).ToArray());
        }

        public Storege SortByPrice()
        {   
            Array.Sort(this.products);
            return new Storege(this.products);
        }
    }

    class Program
    {
        static void Main()
        {
            Product[] products = new Product[]
            {
                new Product("Product C", "Store 1", 100.5m ),
                new Product ("Product B", "Store 3", 20.75m ),
                new Product ("Product A", "Store 2", 15.25m )
            };

            Storege st = new Storege(products);
            st.DisplayProductInfo(1);
            st.Print();

            Console.WriteLine("\nСортировка по названию");

            st.SortByProductName().Print();
            
            Console.WriteLine("\nСортировка по названию магазина");

            st.SortByStoreName().Print();

            Console.WriteLine("\nСортировка по нцене");

            st.SortByPrice().Print();
        }
    }
}