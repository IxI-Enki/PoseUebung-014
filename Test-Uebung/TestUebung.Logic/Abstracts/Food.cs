﻿
namespace TestUebung.Logic.Abstracts;

public abstract class Food(string name , int value) : IFood
{
        public ItemCategory Category => ItemCategory.Food;

        public StatType Type { get; }

        public string Name { get; } = name;

        public int Value { get; } = value;

        public abstract int Duration { get; }
}