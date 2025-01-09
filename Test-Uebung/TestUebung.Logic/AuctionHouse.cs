
namespace TestUebung.Logic;

public sealed class AuctionHouse
{
        #region FIELDS

        private readonly static AuctionHouse _instance;

        #endregion

        #region PROPERTIES

        public static AuctionHouse Instance { get => _instance; }

        #endregion

        #region CONSTRUCTOR

        static AuctionHouse() => _instance = new AuctionHouse();

        private AuctionHouse()
        {

        }

        #endregion

        #region METHODS

        public void OpenAuctionHouse()
        {
                Thread runAuctionHouse = new(RunAuctionHouse)
                {
                        IsBackground = true
                };
                runAuctionHouse.Start();
        }

        private void RunAuctionHouse()
        {
                Console.WriteLine("AuctionHouse opened".ForegroundColor("green"));
                while (true)
                {
                        Thread.Sleep(1000);
                        Console.WriteLine("Tick");
                }
        }

        #endregion

        #region OVERRIDES

        public override string ToString() => "Welcome to IxI´s Auction House";

        #endregion
}