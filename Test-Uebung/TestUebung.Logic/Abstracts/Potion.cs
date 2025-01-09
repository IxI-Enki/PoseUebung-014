namespace TestUebung.Logic.Abstracts;

public abstract class Potion(string name, int value) : IPotion
{
        public ItemCategory Category => ItemCategory.Potion;

        public StatType Type { get; }

        public string Name { get; } = name;

        public int Value { get; } = value;
}