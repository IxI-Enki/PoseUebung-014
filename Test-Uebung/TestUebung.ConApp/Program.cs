namespace TestUebung.ConApp;

internal class Program
{
        static void Main()
        {
                Console.WriteLine(AuctionHouse.Instance);
                AuctionHouse.Instance.OpenAuctionHouse();

                HealthPotion HPpotion = new("smallHealthPotion" , value: 10);

                Console.WriteLine(HPpotion.Name);
                Console.WriteLine(HPpotion.Value);

                if (HPpotion.Category is ItemCategory.Potion)
                {
                        Console.WriteLine(nameof(HPpotion) + " is a potion");
                        if (HPpotion.Type is StatType.Health)
                                Console.WriteLine(nameof(HPpotion) + " heals");
                }

                Console.ReadLine();
        }
}
