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
                Console.WriteLine("AuctionHouse opened".ForegroundColor("green"));
        }

        #endregion

        #region OVERRIDES

        public override string ToString() => "Welcome to IxI´s Auction House";

        #endregion
}