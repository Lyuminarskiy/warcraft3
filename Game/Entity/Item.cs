using Game.Entity.Type;

namespace Game.Entity;

public class Item
{
    public string Name { get; init; } = "Default Name";
    public Items Type { get; init; }
    public ItemClass Class { get; init; }
    public int Level { get; init; }
    public int Cost { get; init; }
    public int SellValue { get; init; }
}