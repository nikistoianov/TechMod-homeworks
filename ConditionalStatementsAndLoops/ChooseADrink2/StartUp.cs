namespace ChooseADrink2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            string drink = "";
            double price = 0;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.7;
                    break;
                default:
                    drink = "Tea";
                    price = 1.2;
                    break;
            }

            Console.WriteLine("The {0} has to pay {1:F2}.", profession, price * quantity);
        }
    }
}
