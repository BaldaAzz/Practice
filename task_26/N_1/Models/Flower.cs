using System.Text;

namespace N_1.Models
{
    public class Flower
    {
        public string FlowerName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .Append($"Flower is {FlowerName}")
                .Append($"Flower price is {Price:f4} rub")
                .ToString();
        }
    }
}
