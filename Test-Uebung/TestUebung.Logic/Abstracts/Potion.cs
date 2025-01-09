namespace TestUebung.Logic.Abstracts;

public abstract class Potion(string name) : IPotion
{
        public ItemCategory Category => ItemCategory.Potion;

        public StatType Type { get; }

        public string Name => name;
}