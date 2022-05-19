using System;
namespace VegetablesStore
{
	public class MyRandom
	{

		public List<string> RandomVegetable()
        {
			string[] vegetableList = { "Cucumber", "Eggplant", "Tomato", "Potato" };
			Random random = new();
			int number = random.Next(1,5);
			List<string> vegetables = new();

            for (int i = 0; i < number; i++)
			{ 
				int index = random.Next(0,vegetableList.Length);
				vegetables.Add(vegetableList[index]);
            }
			return vegetables;
        }

		public int RandomVegetableKG(int kg)
        {
			Random random = new();
			int number = random.Next(1,kg);
			return number;
		}

	}
}

