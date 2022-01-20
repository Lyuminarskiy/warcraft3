using Game.Entity.Type;
using Game.Repository;

namespace Game.Entity;

public class UnitBuilder: IBuilder<Unit>
{
    private readonly Unit _unit;

    public UnitBuilder()
    {
        _unit = new Unit();
    }

    public UnitBuilder(Unit unit)
    {
        _unit = unit;
    }

    public Unit Build() => _unit;

    public UnitBuilder SetHitPoints(double max, double regeneration = 0.25, double? initial = null)
    {
        _unit.HasHitPoint = true;
        _unit.HitPoints = initial ?? max;
        _unit.HitPointsMax = max;
        _unit.HitPointsRegeneration = regeneration;
        _unit.HitPointsInitial = initial ?? max;
        return this;
    }

    public UnitBuilder SetMana(double max, double regeneration, double? initial = null)
    {
        _unit.HasMana = true;
        _unit.Mana = initial ?? max;
        _unit.ManaMax = max;
        _unit.ManaInitial = initial ?? max;
        _unit.ManaRegeneration = regeneration;
        return this;
    }

    public UnitBuilder SetPrice(int gold = 0, int lumber = 0, int food = 0)
    {
        _unit.Gold = gold;
        _unit.Lumber = lumber;
        _unit.Food = food;
        return this;
    }

    public UnitBuilder SetArmor(ArmorType type, double armor = 0)
    {
        _unit.ArmorType = type;
        _unit.Armor = armor;
        return this;
    }

    public UnitBuilder SetBaseData(Units type, Race race, int level, string name)
    {
        _unit.Type = type;
        _unit.Race = race;
        _unit.Level = level;
        _unit.Name = name;
        return this;
    }

    public UnitBuilder SetBuildData(Units builtFrom, TimeSpan buildTime,
        string hotKey, IEnumerable<Units>? requirements = null)
    {
        _unit.BuiltFrom = builtFrom;
        _unit.Requirements = requirements != null ? new HashSet<Units>(requirements) : null;
        _unit.BuildTime = buildTime;
        _unit.HotKey = hotKey;
        return this;
    }

    public UnitBuilder AddAttack(double damageMin, double damageMax, AttackType attackType, WeaponType weaponType,
        double range, double cooldown, IEnumerable<AttackTargetType> targets, IEnumerable<AttackTargetType>? areaTargets = null)
    {
        // У юнита не может быть больше двух типов аттак.
        if (_unit.Attacks.Count == 2) return this;
        
        _unit.Attacks.Add(new Attack
        {
            DamageMax = damageMax,
            DamageMin = damageMin,
            AttackType = attackType,
            WeaponType = weaponType,
            Range = range,
            Cooldown = cooldown,
            Targets = new HashSet<AttackTargetType>(targets),
            AreaTargets = areaTargets != null ? new HashSet<AttackTargetType>(areaTargets) : null
        });
        return this;
    }
    
    public UnitBuilder AddAbilities(params Abilities[] abilities)
    {
        var repository = new AbilityRepository();
        foreach (var ability in abilities)
        {
            _unit.Abilities.Add(repository.Get(ability));
        }

        return this;
    }

    public UnitBuilder AddBasicAbilities()
    {
        return this;
    }
}