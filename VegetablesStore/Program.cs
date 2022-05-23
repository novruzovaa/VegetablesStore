using Newtonsoft.Json;
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

var str = JsonConvert.SerializeObject(vegetables, Newtonsoft.Json.Formatting.Indented);
File.WriteAllText("veg.json", str);


MyStruct ms = new(1,0,0,0,0,0,0,0,0,0,0);
Random random = new();

Console.WriteLine("\t\tWelcome to Store");


void Customer()
{

    Console.WriteLine();
    Console.WriteLine($"{ms.customerCount + 1}.Musteri");
    Console.WriteLine();
    MyRandom my = new();

    

    int n = random.Next(10);
    string veg;
    if (n == 1)
        veg = my.ToxicVegetable();
    else if (n == 2)
        veg = my.RottenVegetable();
    else
        veg = null;

    bool b = false;

    foreach (var vegetable in my.RandomVegetable())
    {
        int kg = my.RandomVegetableKG(5);
        double price = 0;

        if (vegetable == veg && n == 1)
        {
            Console.WriteLine("Toxic terevez cixdi");
            b = true;
            ms.rating--;
            continue;
        }
        else if (vegetable == veg && n == 2)
        {
            Console.WriteLine("Curuk terevez cixdi");
            b = true;
            ms.rating--;
            continue;
        }

        if (vegetable == "Tomato")
        {
            
            vegetables[0].KG -= kg;
            ms.tDailyKg += kg;
            price = vegetables[0].Price * kg;
            ms.rating++;
            if (b == true)
                ms.dailyPrice += 0;
            else
                ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2} AZN");
            
        }

        else if (vegetable == "Eggplant")
        {

            vegetables[1].KG -= kg;
            ms.eDailyKg += kg;
            price = vegetables[1].Price * kg;
            ms.rating++;
            if (b == true)
                ms.dailyPrice += 0;
            else
                ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2} AZN");
        }

        else if (vegetable == "Cucumber")
        {
            vegetables[2].KG -= kg;
            ms.cDailyKg += kg;
            price = vegetables[2].Price * kg;
            ms.rating++;
            if (b == true)
                ms.dailyPrice += 0;
            else
                ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2}.2 AZN");
        }

        else if (vegetable == "Potato")
        {
            vegetables[3].KG -= kg;
            ms.pDailyKg += kg;
            price = vegetables[3].Price * kg;
            ms.rating++;
            if (b == true)
                ms.dailyPrice += 0;
            else
                ms.dailyPrice += price;
            Console.WriteLine($"{vegetable}  {kg} kg, {price:F2} AZN");
        }
    }
    if(b == true && n == 1)
    {
        Console.WriteLine("Toxic terevez oldugu ucun musterinin alis verisi legv olunmusdur");
        Thread.Sleep(2000);
    }
    else if(b == true && n == 2)
    {
        Console.WriteLine("Curuk terevez oldugu ucun musterinin alis verisi legv olunmusdur");
        Thread.Sleep(2000);
    }
        
}

int c = 10;
int k = 200;
int d = 0;


while (ms.week < 4)
{
    
    while (ms.customerCount < c)
    {
        Customer();
        ms.customerCount++;
        Thread.Sleep(2000);
    }

    if (ms.day == 7)
    {
        Console.WriteLine();
        Console.WriteLine("\t\tHEFTELIK HESABAT");
        Console.WriteLine($"Heftelik umumi qazanc - {ms.weeklyPrice}\n" +
            $"Satilanlar: \n" +
            $"Pomidor - {200 - vegetables[0].KG}\n" +
            $"Xiyar - {200 - vegetables[2].KG}\n" +
            $"Badimcan - {200 - vegetables[1].KG}\n" +
            $"Kartoska - {200 - vegetables[3].KG}\n");
        Thread.Sleep(10000);
        foreach (var veg in vegetables)
        {
            k += 200;
            veg.KG = k;
        }

        if(ms.rating > d)
        {
            c += 10;
            d = ms.rating;
        }
            
        else if(ms.rating < d)
        {
            c -= 2;
            d = ms.rating;
        }
        
        ms.week++;
        ms.monthlyPrice += ms.weeklyPrice;
        ms.weeklyPrice = 0;
        ms.day = 0;

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
    ms.rating = 0;  

}