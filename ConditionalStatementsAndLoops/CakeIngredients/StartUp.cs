namespace CakeIngredients
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string ingredient = Console.ReadLine();
            int ingredientCount = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredientCount += 1;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", ingredientCount);
        }
    }
}
