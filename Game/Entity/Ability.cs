using Game.Entity.Type;

namespace Game.Entity;

public class Ability
{
    public string Name { get; set; } = "Default Name";
    public Abilities Type { get; set; }
    public AbilityClass Class { get; set; }
    public AbilityCastType CastType { get; set; }
    public string? HotKey { get; set; }
    public int Position { get; set; }

    public double ManaCost { get; set; }

    public bool IsInstant { get; set; }
    public bool IsChanneling { get; set; }
    public TimeSpan CastTime { get; set; }
    public TimeSpan Cooldown { get; set; }
    
    
    public AbilityTargetType TargetType { get; set; }
    public double Range { get; set; }
    public double AreaOfEffect { get; set; }
    public HashSet<AttackTargetType>? TargetsAllowed { get; set; } = new();
}