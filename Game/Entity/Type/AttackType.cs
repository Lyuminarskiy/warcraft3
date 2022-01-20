namespace Game.Entity.Type;

public enum AttackType
{
    /// <summary>
    /// Mainly used by melee or short ranged units.
    /// Effective against most ground ranged units.
    /// Examples: Knights, Huntresses
    /// </summary>
    Normal,
    /// <summary>
    /// Primarily used by ranged attackers, ground, air, or structure.
    /// Effective against air units and spellcasters.
    /// Examples: Crypt Fiends, Hippogryph Riders
    /// </summary>
    Piercing,
    Magic,
    Siege,
    Hero,
    Chaos
}