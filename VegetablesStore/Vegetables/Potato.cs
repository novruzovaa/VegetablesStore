using System;
namespace VegetablesStore.Vegetables
{
    public class Potato : Vegetable
    {
        public Potato(string? name, double price, double kg) : base(name, price, kg)
        {

        }

        public override bool IsHas()
        {
            return true;
        }
    }
}

