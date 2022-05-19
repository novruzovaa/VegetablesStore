using VegetablesStore;
using VegetablesStore.Vegetables;

Tomato tomatoes = new("Tomato", 0.50, 200);
Eggplant eggplants = new("Eggplant", 0.80, 200);
Cucumber cucumbers = new("Cucumber", 0.40, 200);
Potato potatoes = new("Potato", 0.60, 200);

List<Vegetable> vegetables = new();

vegetables.Add(tomatoes);
vegetables.Add(eggplants);
vegetables.Add(cucumbers);
vegetables.Add(potatoes);



MyStruct ms = new(1,0,0,0,0,0,0,0,0,0);

Console.WriteLine("\t\tWelcome to Store");


void Customer()
{
    Console.WriteLine();
    Console.WriteLine($"{ms.customerCount + 1}.Musteri");
    Console.WriteLine();
    MyRandom my = new();

    foreach (var vegetable in my.RandomVegetable())
    {
        int kg = my.RandomVegetableKG(5);
        double price = 0;
        if(vegetable == "Tomato")
        {
            vegetables[0].KG -= kg;
            ms.tDailyKg += kg;
            price = vegetables[0].Price * kg;
            ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2} AZN");
        }

        else if (vegetable == "Eggplant")
        {
            vegetables[1].KG -= kg;
            ms.eDailyKg += kg;
            price = vegetables[1].Price * kg;
            ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2} AZN");
        }

        else if (vegetable == "Cucumber")
        {
            vegetables[2].KG -= kg;
            ms.cDailyKg += kg;
            price = vegetables[2].Price * kg;
            ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2}.2 AZN");
        }

        else if (vegetable == "Potato")
        {
            vegetables[3].KG -= kg;
            ms.pDailyKg += kg;
            price = vegetables[3].Price * kg;
            ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2} AZN");
        }
    }
}

int c = 10;
while (ms.week < 4)
{
    while(ms.customerCount < c)
    {
        Customer();
        ms.customerCount++;
        Thread.Sleep(2000);
    }
    if (ms.day == 7)
    {
        ms.week++;
        c+=10;
        ms.monthlyPrice += ms.weeklyPrice;
        ms.weeklyPrice = 0;
        ms.day = 0;
        continue;
    }
    
    Console.WriteLine();
    Console.WriteLine("\t\tGUNDELIK HESABAT");
    ms.ShowDaily();
    Thread.Sleep(10000);
    ms.day++;
    ms.weeklyPrice += ms.dailyPrice;
    ms.eDailyKg = 0;
    ms.tDailyKg = 0;
    ms.pDailyKg = 0;
    ms.cDailyKg = 0;
    ms.dailyPrice = 0;
    ms.customerCount = 0;
}