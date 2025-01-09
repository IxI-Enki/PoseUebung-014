namespace TestUebung.Logic.Items;

public sealed class HealthPotion(string name) : Potion(name)
{
        public new StatType Type => StatType.Health;


}