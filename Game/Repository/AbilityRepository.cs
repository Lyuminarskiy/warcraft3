using Game.Entity;
using Game.Entity.Type;

namespace Game.Repository;

public class AbilityRepository : IAbilityRepository
{
    public Ability Get(Abilities type)
    {
        // В этом методе может происходить обращение к базе данных
        // или файлу конфигурации для получения информации о юнитах.

        var builder = new AbilityBuilder();
        return (type switch
        {
            Abilities.Slow => builder
                .SetBaseData(type, AbilityClass.Magical, AbilityCastType.Autocast, 50, "Slow", 9, "W")
                .SetTiming(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(1))
                .SetAttackData(AbilityTargetType.UnitTarget, 700, 0, new []
                {
                    AttackTargetType.Air,
                    AttackTargetType.Ground,
                    // Enemy
                }),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        }).Build();
    }
}