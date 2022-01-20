namespace Game.Entity.Type;

public enum ArmorType
{
    /// <summary>
    /// Primarily used by melee units, long-ranged siege weaponry, and summoned units.
    /// Examples: Druids of the Claw, Demolishers
    /// </summary>
    Heavy,
    /// <summary>
    /// Primarily used by ground ranged units.
    /// Examples: Riflemen, Spell Breakers
    /// Also used by Workers.
    /// </summary>
    Medium,
    /// <summary>
    /// Used by most air units, and Scout Towers.
    /// Examples: Destroyers, Frost Wyrms
    /// </summary>
    Light,
    Unarmored,
    Fortified,
    Hero
}