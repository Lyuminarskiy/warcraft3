namespace Game.Entity.Type;

public enum ItemClass
{
    /// <summary>
    /// Most permanent items give the Hero a bonus while carried.
    /// Some items can be used without consuming the item.
    /// </summary>
    Permanent,
    /// <summary>
    /// Can be activated for a temporary effect.
    /// After all charges are consumed the item disappears.
    /// </summary>
    Charged,
    /// <summary>
    /// Power Ups cannot be carried in the inventory and are used immediately by the Hero.
    /// Tomes are Power Up items that grant the hero a permanent bonus.
    /// </summary>
    PowerUp,
    /// <summary>
    /// Permanent items of level seven and eight are called Artifacts.
    /// </summary>
    Artifact,
    /// <summary>
    /// Items that are available in shops.
    /// </summary>
    Purchasable,
    Miscellaneous
}