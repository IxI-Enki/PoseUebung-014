namespace TestUebung.Logic.Items;

public sealed class HealthPotion(string name , int value = 0) : Potion(name , value)
{
        public new StatType Type => StatType.Health;
}