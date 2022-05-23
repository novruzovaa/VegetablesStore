using System;
namespace VegetablesStore
{
	public struct MyStruct
	{
        public int day;
        public int week;
        public double weeklyPrice;
        public double dailyPrice;
        public double monthlyPrice;
        public int customerCount;
        public int cDailyKg;
        public int eDailyKg;
        public int pDailyKg;
        public int tDailyKg;
        public int rating;
        
       
        public MyStruct(int day, int week, double weeklyPrice, double dailyPrice,double monthlyPrice, int customerCount, int cDailyKg, int eDailyKg, int pDailyKg, int tDailyKg,int rating)
        {
            this.day = day;
            this.week = week;
            this.weeklyPrice = weeklyPrice;
            this.dailyPrice = dailyPrice;
            this.monthlyPrice = monthlyPrice;
            this.customerCount = customerCount;
            this.cDailyKg = cDailyKg;
            this.eDailyKg = eDailyKg;
            this.pDailyKg = pDailyKg;
            this.tDailyKg = tDailyKg;
            this.rating = rating;
        }

        public void ShowDaily()
        {
            Console.WriteLine($"Gundelik {customerCount} musteri gelib\n" +
                $"{cDailyKg} kg Xiyar satilib\n" +
                $"{eDailyKg} kg Badimcan satilib\n" +
                $"{pDailyKg} kg Kartoska satilib\n" +
                $"{tDailyKg} kg Pomidor satilib\n" +
                $"Gunluk qazanc - {dailyPrice} AZN\n" +
                $"Rating - {rating}");
        }


    }

}


