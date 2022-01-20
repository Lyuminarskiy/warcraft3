using Game.Entity.Type;

namespace Game.Entity;

public class Unit
{
    #region Unit Information

    public bool IsUnit { get; set; }
    public bool IsHero { get; set; }
    public bool IsBuilding { get; set; }
    
    public Units Type { get; set; }
    public Race Race { get; set; }
    public int Level { get; set; }
    public string Name { get; set; } = "Default name";
        
    public Units BuiltFrom { get; set; }
    public TimeSpan BuildTime { get; set; }
    public string? HotKey { get; set; }
    public HashSet<Units>? Requirements { get; set; }

    public int Gold { get; set; }
    public int Lumber { get; set; }
    public int Food { get; set; }

    public bool HasHitPoint { get; set; }
    public double HitPoints { get; set; }
    public double HitPointsMax { get; set; }
    public double HitPointsRegeneration { get; set; }
    public double HitPointsInitial { get; set; }

    public bool HasMana { get; set; }
    public double Mana { get; set; }
    public double ManaMax { get; set; }
    public double ManaRegeneration { get; set; }
    public double ManaInitial { get; set; }
        
    public ArmorType ArmorType { get; set; }
    public double Armor { get; set; }

    public double SightRangeDay { get; set; }
    public double SightRangeNight { get; set; }

    public double AcquisitionRange { get; set; }
    public int SelectionPriority { get; set; }
    public int FormationRank { get; set; }
        
    #endregion
        
    #region Combat

    public HashSet<Attack> Attacks { get; set; } = new();
    
    #endregion

    #region Movement

    public MoveType MoveType { get; set; }
    public double Speed { get; set; }
    public double TurnRate { get; set; }
    public double CollisionSize { get; set; }
    public double CargoSize { get; set; }

    #endregion

    #region Abilities
    
    public HashSet<Ability> Abilities { get; set; } = new();

    #endregion

    #region Hero

    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }

    public double Experience { get; set; }

    #endregion

    #region Visuals

    public byte[] Icon { get; set; }
    public byte[] Model3D { get; set; }

    #endregion
}