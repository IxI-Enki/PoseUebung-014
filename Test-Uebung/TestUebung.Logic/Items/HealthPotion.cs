namespace TestUebung.Logic.Items;

public sealed class HealthPotion(string name , int value = 1) : Potion(name , value)
{
        public new static StatType Type => StatType.Health;
}