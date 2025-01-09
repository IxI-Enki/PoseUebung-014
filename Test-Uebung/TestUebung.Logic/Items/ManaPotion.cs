namespace TestUebung.Logic.Items;

public sealed class ManaPotion(string name , int value = 1) : Potion(name , value)
{
        public new static StatType Type => StatType.Mana;
}