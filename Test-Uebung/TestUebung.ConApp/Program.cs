namespace TestUebung.ConApp;

internal class Program
{
        static void Main()
        {
                Console.WriteLine(AuctionHouse.Instance);
                AuctionHouse.Instance.OpenAuctionHouse();

                HealthPotion smallHealthPotion = new("smallHealthPotion");

                Console.WriteLine(smallHealthPotion.Name);

                if (smallHealthPotion.Category is ItemCategory.Potion)
                {
                        Console.WriteLine(nameof(smallHealthPotion) + " is a potion");
                        if (smallHealthPotion.Type is StatType.Health)
                                Console.WriteLine(nameof(smallHealthPotion) + " heals");
                }

                Console.ReadLine();
        }
}
