namespace CaloriesCounter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int ingredientsCount = int.Parse(Console.ReadLine());
            double totalCalories = 0;

            for (int i = 1; i <= ingredientsCount; i++)
            {
                string ingredient = Console.ReadLine();
                switch (ingredient.ToLower())
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break;
                    case "pepper":
                        totalCalories += 50;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Total calories: {0}", totalCalories);
        }
    }
}
