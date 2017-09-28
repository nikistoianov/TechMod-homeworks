
namespace NeighbourWars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100, healthGosho = 100, roundCount = 0;

            do
            {
                roundCount += 1;
                if (roundCount % 2 == 0)
                {
                    healthPesho -= damageGosho;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", roundCount);
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
                }
                else
                {
                    healthGosho -= damagePesho;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", roundCount);
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthGosho);
                }

                if (roundCount % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
            } while (healthPesho > 0 && healthGosho > 0);
        }
    }
}
