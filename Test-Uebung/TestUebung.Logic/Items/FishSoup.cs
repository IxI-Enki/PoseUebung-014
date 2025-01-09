namespace TestUebung.Logic.Items;

public sealed class FishSoup(string name , int value = 1) : Food(name , value)
{
        public new static StatType Type => StatType.Mana;

        public override int Duration => 30;
}