namespace TestUebung.ConApp;

internal class Program
{
        static void Main()
        {
                Console.WriteLine(AuctionHouse.Instance);
                AuctionHouse.Instance.OpenAuctionHouse();

                HealthPotion HPpotion = new("smallHealthPotion");

                Console.WriteLine(HPpotion.Name);

                if (HPpotion.Category is ItemCategory.Potion)
                {
                        Console.WriteLine(nameof(HPpotion) + " is a potion");
                        if (HPpotion.Type is StatType.Health)
                                Console.WriteLine(nameof(HPpotion) + " heals");
                }

                Console.ReadLine();
        }
}
