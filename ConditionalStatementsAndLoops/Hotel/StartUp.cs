namespace Hotel
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;
            //double discountStudio;
            //double discountDouble;
            //double discountSuite;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    if (nightsCount > 7) priceStudio *= 0.95;
                    break;
                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    if (nightsCount > 14) priceDouble *= 0.9;
                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;
                    if (nightsCount > 14) priceSuite *= 0.85;
                    break;
            }

            if (nightsCount > 7 && (month == "September" || month == "October"))
                Console.WriteLine("Studio: {0:F2} lv.", priceStudio * (nightsCount - 1));
            else
                Console.WriteLine("Studio: {0:F2} lv.", priceStudio * nightsCount);

            Console.WriteLine("Double: {0:F2} lv.", priceDouble * nightsCount);
            Console.WriteLine("Suite: {0:F2} lv.", priceSuite * nightsCount);

        }
    }
}
