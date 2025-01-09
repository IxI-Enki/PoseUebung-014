namespace TestUebung.Logic.Items;

public sealed class ManaPotion(string name , int value = 0) : Potion(name , value)
{
        public new StatType Type => StatType.Mana;
}