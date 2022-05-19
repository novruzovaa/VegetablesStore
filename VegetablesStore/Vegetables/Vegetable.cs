using System;
namespace VegetablesStore.Vegetables
{
	public class Vegetable
	{
        public Vegetable(string? name, double price, double kg)
        {
            Name = name;
            Price = price;
            KG = kg;
        }

        public string? Name { get; set; }

        public double Price { get; set; }

        public double KG { get; set; }

        public virtual bool IsHas()
        {
            return true;
        }

    }
}

