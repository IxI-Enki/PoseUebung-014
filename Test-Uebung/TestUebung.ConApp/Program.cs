namespace TestUebung.ConApp;

internal class Program
{
        static void Main()
        {
                Console.WriteLine(AuctionHouse.Instance);
                AuctionHouse.Instance.OpenAuctionHouse();

                HealthPotion HPotion = new("smallHealthPotion" , value: 15);
                ManaPotion MPotion = new("smallManaPotion" , value: 13);



                Console.ReadLine();
        }
}
