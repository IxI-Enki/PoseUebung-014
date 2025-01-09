
namespace TestUebung.ConApp;

internal class Program
{
        static void Main()
        {
                Console.WriteLine(AuctionHouse.Instance);

                AuctionHouse.Instance.OpenAuctionHouse();

                ManaPotion smallManaPotion = new();

                HealthPotion smallHealthPotion = new();

                

                Console.WriteLine();

                Console.ReadLine();
        }
}
