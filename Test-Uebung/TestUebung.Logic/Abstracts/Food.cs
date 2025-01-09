
namespace TestUebung.Logic.Abstracts;

public abstract class Food(string name) : IFood
{
        public ItemCategory Category => ItemCategory.Food;

        public StatType Type { get; }

        public string Name { get; } = name;
}