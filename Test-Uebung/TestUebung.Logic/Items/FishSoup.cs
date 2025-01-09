namespace TestUebung.Logic.Items;

public sealed class FishSoup(string name , int value) : Food(name , value)
{
        public new StatType Type => StatType.Mana;

        public override int Duration => 30;
}