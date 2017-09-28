namespace RestaurantDiscount
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName;
            double priceHall = 0;
            double pricePackage = 0;
            double discount = 0;

            if (groupSize <= 50) { priceHall = 2500; hallName = "Small Hall"; }
            else if (groupSize <= 100) { priceHall = 5000; hallName = "Terrace"; }
            else { priceHall = 7500; hallName = "Great Hall"; }          

            switch (package)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = 5;
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = 10;
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = 15;
                    break;
            }

            double totalPrice = pricePackage + priceHall;
            double totalDiscount = totalPrice - totalPrice * discount / 100;
            double personPrice = totalDiscount / groupSize;

            if (groupSize > 120)
                Console.WriteLine("We do not have an appropriate hall.");
            else
            {
                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", personPrice);
            }
                
        }
    }
}
