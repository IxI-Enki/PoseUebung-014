namespace TestUebung.Logic.Abstracts;

internal abstract class Item(string name) : IItem
{
        string IItem.Name { get; } = name;
        public abstract ItemCategory Category { get; }
}