namespace TestUebung.ConApp;

internal class Program
{
        static void Main()
        {
                Console.WriteLine(AuctionHouse.Instance);
                AuctionHouse.Instance.OpenAuctionHouse();

                HealthPotion HPpotion = new("smallHealthPotion" , value: 15);
                ManaPotion MPpotion = new("smallManaPotion" , value: 13);



                Console.ReadLine();
        }
}
