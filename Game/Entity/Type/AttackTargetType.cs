namespace Game.Entity.Type;

public enum AttackTargetType
{
    /// <summary>
    /// Air units, for example Gryphon Rider.
    /// </summary>
    Air,
    /// <summary>
    /// Rock Chunks and other destroyable objects.
    /// </summary>
    Derbis,
    /// <summary>
    /// Ground units, for example Archer.
    /// </summary>
    Ground,
    /// <summary>
    /// Items, for example Runed Bracers.
    /// </summary>
    Item,
    /// <summary>
    /// Buildings, for example Graveyard.
    /// </summary>
    Structure,
    /// <summary>
    /// Trees and Mushrooms, from which lumber can be harvested.
    /// </summary>
    Tree,
    /// <summary>
    /// Wards, for example Healing Wards.
    /// </summary>
    Ward
}