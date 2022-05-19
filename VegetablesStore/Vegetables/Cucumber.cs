using System;
namespace VegetablesStore.Vegetables
{
    public class Cucumber : Vegetable
    {
        public Cucumber(string? name, double price, double kg) : base(name, price, kg)
        {

        }

        public override bool IsHas()
        {
            return true;
        }
    }
}

