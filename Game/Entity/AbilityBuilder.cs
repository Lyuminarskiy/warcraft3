using Game.Entity.Type;

namespace Game.Entity;

public class AbilityBuilder : IBuilder<Ability>
{
    private readonly Ability _ability;

    public AbilityBuilder()
    {
        _ability = new Ability();
    }

    public AbilityBuilder(Ability ability)
    {
        _ability = ability;
    }

    public Ability Build() => _ability;

    public AbilityBuilder SetBaseData(Abilities type, AbilityClass @class,  AbilityCastType castType,
        double manaCost, string name, int position, string? hotKey = null)
    {
        _ability.Type = type;
        _ability.Class = @class;
        _ability.CastType = castType;
        _ability.ManaCost = manaCost;
        _ability.Name = name;
        _ability.Position = position;
        _ability.HotKey = hotKey;
        return this;
    }

    public AbilityBuilder SetTiming(TimeSpan castTime, TimeSpan cooldown, bool isInstant = false,
        bool isChanneling = false)
    {
        _ability.CastTime = castTime;
        _ability.Cooldown = cooldown;
        _ability.IsInstant = isInstant;
        _ability.IsChanneling = isChanneling;
        return this;
    }

    public AbilityBuilder SetAttackData(AbilityTargetType targetType, double range, double areaOfEffect, IEnumerable<AttackTargetType>? targets = null)
    {
        _ability.TargetType = targetType;
        _ability.Range = range;
        _ability.AreaOfEffect = areaOfEffect;
        _ability.TargetsAllowed = targets != null ? new HashSet<AttackTargetType>(targets) : null;
        return this;
    }
}