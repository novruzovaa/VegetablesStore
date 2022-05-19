using System;
namespace VegetablesStore.Vegetables
{
    public class Eggplant : Vegetable
    {
        public Eggplant(string? name, double price, double kg) : base(name, price, kg)
        {

        }

        public override bool IsHas()
        {
            return true;
        }
    }
}

