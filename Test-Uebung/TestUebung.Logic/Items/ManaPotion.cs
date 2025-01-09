namespace TestUebung.Logic.Items;

public sealed class ManaPotion(string name) : Potion(name)
{
        public new StatType Type => StatType.Mana;
}