﻿namespace TestUebung.ConApp;

internal class Program
{
        static void Main()
        {
                Console.WriteLine(AuctionHouse.Instance);

                AuctionHouse.Instance.OpenAuctionHouse();

                Console.ReadLine();
        }
}
