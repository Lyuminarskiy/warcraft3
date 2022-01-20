using Game.Entity.Type;

namespace Game.Entity;

public class Attack
{
    public double DamageMin { get; set; }
    public double DamageMax { get; set; }
    public AttackType AttackType { get; set; }
    public WeaponType WeaponType { get; set; }
    public double Range { get; set; }
    public double Cooldown { get; set; }
    public HashSet<AttackTargetType> Targets { get; init; } = new();
    public HashSet<AttackTargetType>? AreaTargets { get; set; }
}