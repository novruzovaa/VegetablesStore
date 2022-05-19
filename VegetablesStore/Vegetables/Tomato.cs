using System;
namespace VegetablesStore.Vegetables
{
    public class Tomato : Vegetable
    {
        public Tomato(string? name, double price, double kg) : base(name, price, kg)
        {

        }

        public override bool IsHas()
        {
            return true;
        }
    }
}

